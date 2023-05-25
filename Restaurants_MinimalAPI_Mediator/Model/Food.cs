namespace Restaurants_MinimalAPI_Mediator.Model
{
    public class Food
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int FoodPrice { get; set; }
        public string FoodImage { get; set; }
        public int FoodCategoryID { get; set; }

        public FoodCategory  FoodCategory { get; set; }

    }
}
