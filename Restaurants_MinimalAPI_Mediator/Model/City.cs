using System.ComponentModel.DataAnnotations;

namespace Restaurants_MinimalAPI_Mediator.Model
{
    public class City
    {

        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int StateID { get; set; }
        public State State { get; set; }

    }
}
