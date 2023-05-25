using System.ComponentModel.DataAnnotations;

namespace Restaurants_MinimalAPI_Mediator.Model
{
    public class State
    {

        [Key]
        public int StateID { get; set; }
        public string StateName { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }

    }
}
