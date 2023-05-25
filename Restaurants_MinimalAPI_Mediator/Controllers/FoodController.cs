using MediatR;

using Microsoft.AspNetCore.Mvc;
using Restaurants_MinimalAPI_Mediator.Queries;
using Restaurants_MinimalAPI_Mediator.IRepository;
using Microsoft.AspNetCore.Authorization;

namespace Restaurants_MinimalAPI_Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FoodController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;
        public FoodController(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        //      public record FoodResponse(int FoodID, string FoodName, string FoodImage, decimal FoodPrice, string FoodCategoryName);
       // [Authorize]
        [HttpGet("GetAllFoods", Name = nameof(GetAllFoods))]
        public async Task<IActionResult> GetAllFoods() => Ok(await _mediator.Send(new GetAllFood()));

        [HttpGet("GetAllFoodsCategory", Name = nameof(GetAllFoodsCategory))]

        public async Task<IActionResult> GetAllFoodsCategory() => Ok(await _mediator.Send(new GetAllFoodCategory()));

        [HttpGet("GetFoodByFoodCategoryID/{foodID}", Name = nameof(GetFoodByFoodCategoryID))]
        public async Task<IActionResult> GetFoodByFoodCategoryID(int foodID) => Ok(await _mediator.Send(new GetFoodByFoodCategoryID { ID = foodID }));

        [HttpPost("AddNewFood", Name = nameof(AddNewFood))]
        public async Task<IActionResult> AddNewFood(AddNewFood request) => Ok(await _mediator.Send(request));

        [HttpPut("EditFood", Name = nameof(EditFood))]
        public async Task<IActionResult> EditFood(UpdateFood request) => Ok(await _mediator.Send(request));

        [HttpDelete("DeleteFood/{foodID}", Name = nameof(DeleteFood))]
        public async Task<IActionResult> DeleteFood(int foodID)
        {
            var FoodFromDb = await _mediator.Send(new DeleteFood { FoodID = foodID });
            return Ok(new { FoodFromDb, message = " Data Successfuly Delete" });
        }



    }
}
//----------------------------------------------------------------------------------------



//using MediatR;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Restaurants_MinimalAPI_Mediator.Queries;
//using Restaurants_MinimalAPI_Mediator.IRepository;
//using Restaurants_MinimalAPI_Mediator.Model;
//using Restaurants_MinimalAPI_Mediator.Model.DTO;

//namespace Restaurants_MinimalAPI_Mediator.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class FoodController : ControllerBase
//    {
//        private readonly IMediator _mediator;
//        private readonly IUnitOfWork _unitOfWork;
//        public FoodController(IUnitOfWork unitOfWork, IMediator mediator)
//        {
//            _unitOfWork = unitOfWork;
//            _mediator = mediator;
//        }


//        [HttpGet("/api/food/GetAllFoods/")]

//        public async Task<IActionResult> GetAllFoods()
//        {
//            // Send the query to MediatR
//            var foods = await _mediator.Send(new GetAllFood());

//            // Return the foods as a response
//            return Ok(foods);
//        }

//        //[HttpGet("/api/food/GetAllFood/")]        

//        //public IActionResult GetAllFood()
//        //{
//        //    var food = _unitOfWork.FoodRepo.GetAll(includeProperties:"FoodCategory").Select(f => new
//        //    {
//        //       f.FoodID,
//        //       f.FoodName,f.FoodImage,f.FoodPrice , f.FoodCategory.FoodCategoryName
//        //    });
//        //    return Ok(food);
//        //}

//        //[HttpGet("/api/food/GetFoodByFoodCategoryIDs/{foodID}/")]

//        //public IActionResult GetFoodByFoodCategoryIDs (int foodID)
//        //{
//        //    var FoodCategoryID = _unitOfWork.FoodRepo.GetAll(includeProperties: "FoodCategory").Where(f => f.FoodCategoryID == foodID).Select(f => new
//        //    {
//        //        f.FoodID, f.FoodName , f.FoodPrice, f.FoodImage , f.FoodCategoryID , f.FoodCategory.FoodCategoryName
//        //    });
//        //    return Ok(FoodCategoryID);
//        //}

//        [HttpGet("/api/food/GetFoodByFoodCategoryID/{foodID}/")]
//        public async Task<IActionResult> GetFoodByFoodCategoryID(int foodID)
//        {
//            var foods = await _mediator.Send(new GetFoodByFoodCategoryID { ID = foodID });
//            return Ok(foods);
//        }

//        //[HttpPost("/api/food/AddNewFoods/")]
//        //public IActionResult AddNewFoods(FoodDTO foodDTO)
//        //{
//        //    if (foodDTO == null) return BadRequest();

//        //    Food foods = new Food(); 

//        //    foods.FoodName = foodDTO.FoodName;
//        //    foods.FoodImage = foodDTO.FoodImage;
//        //    foods.FoodPrice = foodDTO.FoodPrice;
//        //    foods.FoodCategoryID = foodDTO.FoodCategoryID;


//        //    _unitOfWork.FoodRepo.Add(foods);
//        //    _unitOfWork.Save();    
//        //    return Ok(foods);
//        //}


//        [HttpPost("/api/food/AddNewFood/")]

//        public async Task<IActionResult> AddNewFood(AddNewFood request)
//        {
//            return Ok(await _mediator.Send(request));
//        }


//        //[HttpPut("/api/food/EditFood/")]
//        //public IActionResult EditFood(FoodDTO foodDTO)
//        //{

//        //    Food foods = new Food();
//        //    foods.FoodID = foodDTO.FoodID;
//        //    foods.FoodName = foodDTO.FoodName;
//        //    foods.FoodImage = foodDTO.FoodImage;
//        //    foods.FoodPrice = foodDTO.FoodPrice;
//        //    foods.FoodCategoryID = foodDTO.FoodCategoryID;


//        //    _unitOfWork.FoodRepo.update(foods);
//        //    _unitOfWork.Save();
//        //    return Ok(foods);

//        //}

//        [HttpPut("/api/food/EditFood/")]
//        public async Task<IActionResult> EditFood(UpdateFood request)
//        {
//            return Ok(await _mediator.Send(request));
//        }


//        [HttpDelete("/api/food/DeleteFood/{foodID}/")]

//        public async Task<IActionResult> DeleteFood(int foodID)
//        {
//            var FoodFromDb = await _mediator.Send(new DeleteFood { FoodID = foodID });
//            return Ok(new { FoodFromDb, message = " Data Successfuly Delete" });
//        }
//    }
//}
