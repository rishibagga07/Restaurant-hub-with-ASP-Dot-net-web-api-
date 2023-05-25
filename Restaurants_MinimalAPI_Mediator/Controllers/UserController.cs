
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurants_MinimalAPI_Mediator.Data;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.IRepository.Repository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Model.DTO;
using Restaurants_MinimalAPI_Mediator.Queries;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_Minimal_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMediator _mediator;
        private readonly IJWT _jWT;
       
       
        private readonly IUnitOfWork _unitOfWork;
        public UserController(ApplicationDbContext context,  IUnitOfWork unitOfWork , IMediator mediator , IJWT jWT )
        {
            _context = context;
           _mediator= mediator;
            _unitOfWork = unitOfWork;
            _jWT = jWT;
        }



        //[HttpGet("/api/users/repository/iunitofwork")]
        //public IActionResult getAllUserr()
        //{
        //    var u = _unitOfWork.UserRepo.GetAll();
        //    var users = _unitOfWork.UserRepo.GetAll(includeProperties: "City.State.Country")
        //        .Select(u => new
        //        {
        //            u.UserID,
        //            u.UserName,
        //            u.UserAge,
        //            u.UserAddress,
        //            u.UserEmail,
        //            u.RoleID,
        //            u.CityID,
        //            u.City.StateID,
        //            u.City.State.CountryID,
        //            u.City.State.Country.CountryName,
        //             u.City.State.StateName,
        //             u.City.CityName,
        //             u.ApprovalID

        //        });
        //    return Ok(users);
        //}

        [HttpGet("/api/users/repository/iunitofwork")]

        public async Task<IActionResult> GetAllUser ()
        {
            var users = await _mediator.Send(new UserGettAll());

            return Ok(users);
        }



        //[HttpGet("/api/country/iunitofwork")]

        //public async Task<IActionResult> GetAllCountry()
        //{
        //    var CountryList = _unitOfWork.CountryRepo.GetAllCountry();
        //    return Ok(CountryList);
        //}

        [HttpGet("/api/country/GetAllCountry")]
        public async Task<IActionResult> GetAllCountry()
        {
            var CountryList = await _mediator.Send(new GetAllCountry());
            return Ok(CountryList);
        }




        //[HttpGet("/api/stateGetByCountryID/{id}")]

        //public async Task<IActionResult> StateGetByCountryID(int id)
        //{
        //    var StateListByCountryID = _unitOfWork.StateRepo.GetAll(includeProperties: "Country").Where(State => State.CountryID == id);
        //    return Ok(StateListByCountryID);
        //}

        [HttpGet("/api/stateGetByCountryID/{CountryID}")]

        public async Task<IActionResult> StateGetByCountryID(int CountryID) 
        {
         var StateListByCountryID = await _mediator.Send(new GetStateByCountryID { CountryID  = CountryID });
            return Ok(StateListByCountryID);
        }


        //[HttpGet("/api/CityGetByStateID/{id}")]
        //public async Task<IActionResult> CityGetByStateID(int id)
        //{
        //    var StateListByCountryID = _unitOfWork.CityRepo.GetAll(includeProperties: "State").Where(city => city.StateID == id);
        //    return Ok(StateListByCountryID);
        //}

        [HttpGet("/api/CityGetByStateID/{StateID}")]
        public async Task<IActionResult> CityGetByStateID(int StateID)
        {
            var CityListByStateID = await _mediator.Send(new GetCityByState { StateID= StateID });
            return Ok(CityListByStateID);
        }


        //[HttpPost("/api/users/AddUser")]

        //public IActionResult AddUser(uu uu)
        //{

        //    User user = new User();
        //    user.UserName = uu.User_Name;
        //    user.UserAge = uu.User_Age;
        //    user.UserAddress = uu.User_Address;
        //    user.UserEmail = uu.User_Email;
        //    user.CityID = uu.CityID;
        //    user.RoleID = uu.RoleID;

        //    _unitOfWork.UserRepo.Add(user);
        //    _unitOfWork.Save();

        //    return Ok();


        //}

        [HttpPost("/api/users/AddUser")]
        public async Task<IActionResult> AddUser(AddNewUser request)
        {
            return Ok ( await _mediator.Send(request));
        }



        //[HttpGet("/api/GetUserByApprovedID/{id}")]

        //public IActionResult GetUserByApprovedID(int id)
        //{
        //    if (id == 0) return BadRequest();

        //    if (id == 1)
        //    {
        //        var Approved = _unitOfWork.UserRepo.GetAll().Where(r => r.ApprovalID == id);

        //        return Ok(Approved);
        //    }
        //    else if (id == 2)
        //    {
        //        var Disapproved = _unitOfWork.UserRepo.GetAll().Where(r => r.ApprovalID == id);
        //        return Ok(new { Disapproved, message = "Your Request Is Disapproved" });

        //    }
        //    else
        //    {
        //        var Blocked = _unitOfWork.UserRepo.GetAll().Where(r => r.ApprovalID == id);
        //        return Ok(new { Blocked, message = "Your Request Is Blocked" });
        //    }


        //    return Ok();
        //}


        //[HttpPatch("/api/users/UserApprovedByAdminn/")]

        //public IActionResult UserApprovedByAdmin(ApprovedDTO approvedDTO)
        //{
        //    var approval = _unitOfWork.UserRepo.FirstOrDefault(a => a.UserID ==  approvedDTO.UserOrCompanyID);
        //    approval.ApprovalID = approvedDTO.ApprovalID;
        //    _unitOfWork.UserRepo.update(approval);
        //    _unitOfWork.Save();
        //    return Ok();
        //}

        [HttpGet("/api/GetUserByApprovedID/{ApprovalID}")]

        public async Task<IActionResult> UserGetByApprovalID(int ApprovalID)
        {
            var userByApprovalid = await _mediator.Send(new GetUserByApprovedID { ApprovalID = ApprovalID });
            return Ok(userByApprovalid);
        }
            

        [HttpPatch("/api/users/UserApprovedByAdminn/")]

        public async Task<IActionResult> UserApprovedByAdmin(UserApprovedByAdmin request)
        {
            return Ok (await _mediator.Send(request));
        }



        //[HttpPut("/api/users/AddUser/UpdateUser")]

        //public IActionResult UpdateUser(uu uu)
        //{
        //    if (uu.User_ID == 0)
        //    {
        //        return BadRequest();
        //    }
        //    else
        //    {
        //        User user = new User();
        //        user.UserID = uu.User_ID;
        //        user.UserName = uu.User_Name;
        //        user.UserAge = uu.User_Age;
        //        user.UserAddress = uu.User_Address;
        //        user.UserEmail = uu.User_Email;
        //        user.CityID = uu.CityID;
        //        user.RoleID = uu.RoleID;
        //        _unitOfWork.UserRepo.update(user);
        //    }

        //    _unitOfWork.Save();
        //    return Ok();
        //}


        [HttpPut("/api/users/AddUser/UpdateUser")]
        public async Task<IActionResult> UpdateUser(UpdateUser request)
        {
            return Ok(await _mediator.Send(request));
        }


        //[HttpDelete("/api/users/AddUser/RemoveUser")]

        //public IActionResult RemoveUser(int id)
        //{
        //    var IdFromDb = _unitOfWork.UserRepo.Get(id);
        //    if (IdFromDb == null) return BadRequest();
        //    _unitOfWork.UserRepo.Remove(IdFromDb);
        //    _unitOfWork.Save();
        //    return Ok(new { message = "User Delete Successfuly" });
        //}


        [HttpDelete("/api/users/AddUser/RemoveUser/{UserID}")]

        public async Task<IActionResult> RemoveUse(int UserID)
        {
            var UserFromDb = await _mediator.Send(new RemoveUser { UserID = UserID });
            return Ok(new { UserFromDb, message = " Data Successfuly Delete" });
        }



        //[HttpGet("/api/users/AddUser/UserLogin")]

        [HttpPost("/api/users/UserLogin")]

    
        public async Task<IActionResult> UserLogin(Login login)
        {
            var Ulogin = _unitOfWork.UserRepo.FirstOrDefault(e => e.UserEmail== login.Email && e.UserPassword == login.password);
            if (Ulogin == null)
                return BadRequest(new { message = "Username or password is incorrect" });          
            return Ok(Ulogin);
        }



        // JWT

        [HttpPost("/api/Authenticate")]
        public IActionResult Authenticate(Login model)
        {
            var response = _jWT.Authenticate(model);
            

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }


    }
}
