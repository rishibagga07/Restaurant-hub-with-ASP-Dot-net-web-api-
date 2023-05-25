using System.ComponentModel.DataAnnotations;

namespace Restaurants_MinimalAPI_Mediator.Model.DTO
{
    public class AddRestaurantsDTO
    {
        [Key]
        public int RestID { get; set; }
        public string RestName { get; set; }
        public string RestImage { get; set; }

        public string RestAddress { get; set; }
        public string RestEmail { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }

        public int? FeedBack { get; set; }
        public int? RoleID { get; set; }
        public Role Role { get; set; }

        public int? ApprovalID { get; set; }

        public Approval Approval { get; set; }
    }
}
