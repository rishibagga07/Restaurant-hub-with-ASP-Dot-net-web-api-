using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Restaurants_MinimalAPI_Mediator.Model;
using Restaurants_MinimalAPI_Mediator.Model.DTO;
using Restaurants_MinimalAPI_Mediator.Queries.RestaurantsQuery;
using Restaurants_MinimalAPI_Mediator.Queries.UserQueries;

namespace Restaurants_MinimalAPI_Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
        public class RestaurantController : ControllerBase
        {
            private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;
            public RestaurantController(IUnitOfWork unitOfWork, IMediator mediator)
            {
                _unitOfWork = unitOfWork;
            _mediator = mediator;
            }


        [HttpGet("/api/restaurant/iunitofwork")]


        public async Task<IActionResult> GettAllRestaurants()
        {
            var restaurantslist = await _mediator.Send(new GetAllRestaurants());
            return Ok(restaurantslist);
        }

        //[HttpGet("/api/restaurant/iunitofwork")]

        //public IActionResult GetAll()
        //{
        //    var RestaurantList = _unitOfWork.RestaurantRepo.GetAll(includeProperties: "City.State.Country").Select(r => new
        //    {
        //        r.RestID,
        //        r.RestName,
        //        r.RestImage,
        //        r.CityID,
        //        r.City.CityName,
        //        r.City.State.StateName,
        //        r.City.State.Country.CountryName,
        //        r.ApprovalID,
        //        r.RoleID,
        //        r.FeedBack
        //    });
        //    return Ok(RestaurantList);
        //}

        [HttpGet("/api/restaurant/RestaurantGetByCity_ID/{CityID}")]


        public async Task<IActionResult> RestaurantGetByCityID(int CityID)
        {
            var restaurantsbycityID = await _mediator.Send(new RestaurantGetByCityID { CityID = CityID });
            return Ok(restaurantsbycityID);
        }

        //[HttpGet("/api/restaurant/RestaurantGetByCity_ID/{id}")]
        //    public IActionResult RestaurantGetByCity_ID(int id)
        //    {
        //        var CiyId = _unitOfWork.RestaurantRepo.GetAll(includeProperties: "City").Where(r => r.CityID == id);
        //    var top3Restaurants = CiyId.OrderByDescending(r => r.FeedBack).Take(3).ToList();   

        //        return Ok(top3Restaurants);
        //    }

        [HttpPatch]
        public async Task<IActionResult> FeedBackByUserToCompany(FeedBackByUserToCompany request)
        {
            return Ok(await _mediator.Send(request));
        }


        //[HttpPatch]
        //public IActionResult FeedBackByUserToCompany(FeedBackDTO feedBackDTO )
        //{
        //    var feedback = _unitOfWork.RestaurantRepo.FirstOrDefault(f => f.RestID == feedBackDTO.CompanyId);
        //  feedback.FeedBack = feedback.FeedBack + feedBackDTO.FeedBack;


        //    _unitOfWork.RestaurantRepo.update(feedback);
        //    _unitOfWork.Save();
        //    return Ok();
        //}


        [HttpPatch("/api/restaurantCompanyRequestApprovedByAdmin")]
        public async Task<IActionResult> CompanyRequestApprovedByAdmin(CompanyRequestApprovedByAdmin request)
        {
            
            return Ok(await _mediator.Send(request));
        }


        //[HttpPatch("/api/restaurant/RequestApprovedAdmin")]

        //    public IActionResult CompanyRequestApprovedAdmin(ApprovedDTO approvedDTO)
        //    {
        //       var Approval = _unitOfWork.RestaurantRepo.FirstOrDefault(r => r.RestID == approvedDTO.UserOrCompanyID);


        //        Approval.ApprovalID = approvedDTO.ApprovalID;


        //        _unitOfWork.RestaurantRepo.update(Approval);
        //        _unitOfWork.Save();

        //        return Ok();

        //    }


        [HttpGet("/api/restaurant/GetRestaurantsByApprovedID/{ApprovalID}")]
        public async Task<IActionResult> GetRestaurantsByApprovedID (int ApprovalID)
        {
            var GetRestaurantsByApprovedID = await _mediator.Send(new GetRestaurantsByApprovedID { ApprovalID = ApprovalID });
            return Ok(GetRestaurantsByApprovedID);
        }



        //[HttpGet("/api/restaurant/GetRestaurantsByApprovedID")]

        //    public IActionResult GetRestaurantsByApprovedID(int id)
        //    {
        //        if (id == 0) return BadRequest();

        //        if (id == 1)
        //        {
        //            var Approved = _unitOfWork.RestaurantRepo.GetAll().Where(r => r.ApprovalID == id);

        //            return Ok(Approved);
        //        }
        //        else if (id == 2)
        //        {
        //            var Disapproved = _unitOfWork.RestaurantRepo.GetAll().Where(r => r.ApprovalID == id);
        //            return Ok(new { Disapproved, message = "Your Request Is Disapproved" });

        //        }
        //        else
        //        {
        //            var Blocked = _unitOfWork.RestaurantRepo.GetAll().Where(r => r.ApprovalID == id);
        //            return Ok(new { Blocked, message = "Your Request Is Blocked" });
        //        }


        //        return Ok();
        //    }


        [HttpPost("/api/restaurant/AddRestaurant")]

        public async Task<IActionResult> AddRestaurant (AddRestaurant request)
        {
            return Ok (await _mediator.Send(request));
        }


        //[HttpPost("/api/restaurant/AddRestaurant")] 

        //    public IActionResult AddRestaurant(AddRestaurants addRestaurants)
        //    {
        //        if (addRestaurants == null) return BadRequest();

        //        RestaurantsRegi restaurantRegi = new RestaurantsRegi();


        //        restaurantRegi.RestName = addRestaurants.Rest_Name;
        //        restaurantRegi.RestImage = addRestaurants.Rest_Image;
        //        restaurantRegi.RestAddress = addRestaurants.Rest_Address;
        //        restaurantRegi.RestEmail = addRestaurants.Rest_EmailAddress;
        //        restaurantRegi.CityID = addRestaurants.CityID;
        //        restaurantRegi.ApprovalID = addRestaurants.ApprovedID;
        //        restaurantRegi.RoleID = addRestaurants.RoleID;

        //        _unitOfWork.RestaurantRepo.Add(restaurantRegi);
        //        _unitOfWork.Save();

        //        return Ok();
        //    }


        [HttpPut("/api/restaurant/UpdateRestaurant")]

        public async Task<IActionResult> UpdateRestaurant(UpdateRestaurant request)
        {
            return Ok(await _mediator.Send(request));
        }

        //[HttpPut("/api/restaurant/UpdateRestaurant")]

        //    public IActionResult UpdateRestaurant(AddRestaurants addRestaurants)
        //    {

        //        RestaurantsRegi restaurantRegi = new RestaurantsRegi();
        //        restaurantRegi.RestID = addRestaurants.Rest_ID;
        //        restaurantRegi.RestName = addRestaurants.Rest_Name;
        //        restaurantRegi.RestImage = addRestaurants.Rest_Image;
        //        restaurantRegi.CityID = addRestaurants.CityID;
        //        _unitOfWork.RestaurantRepo.update(restaurantRegi);
        //        _unitOfWork.Save();
        //        return Ok();
        //    }



        [HttpGet("/api/restaurant/GetAllCity")]

        public async Task<IActionResult> GetAllCity()
        {
            var GetAllCities = await _mediator.Send(new GetAllCity());

            return Ok(GetAllCities);
        }


        [HttpPatch("/api/restaurant/GetFeedBackFromUser")]

        public async Task<IActionResult> GetFeedBackFromUser(FeedBackDTO feedBackDTO)
        {
            var getfeedback = _unitOfWork.RestaurantRepo.FirstOrDefault(x => x.RestID == feedBackDTO.RestID);
            getfeedback.FeedBack = getfeedback.FeedBack + feedBackDTO.FeedBack;
            _unitOfWork.RestaurantRepo.update(getfeedback);
            _unitOfWork.Save();

            return Ok(getfeedback);
        }



    }


    
}
