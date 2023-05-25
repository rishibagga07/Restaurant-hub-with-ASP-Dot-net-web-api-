using System.ComponentModel.DataAnnotations;

namespace Restaurants_MinimalAPI_Mediator.Model.DTO
{
    public class AddRestaurants
    {
        [Key]
        public int Rest_ID { get; set; }
        public string Rest_Name { get; set; }
        public string Rest_Image { get; set; }
        public string Rest_Address { get; set; }
        public string Rest_EmailAddress { get; set; }
        public int CityID { get; set; }

        public int RoleID { get; set; }
        public int? ApprovedID { get; set; }
    }
}
