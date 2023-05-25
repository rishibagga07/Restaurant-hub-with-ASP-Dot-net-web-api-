using System.ComponentModel.DataAnnotations;

namespace Restaurants_MinimalAPI_Mediator.Model.DTO
{
    public class RoleDTO
    {
        [Key]
        public int RoleID { get; set; }

        public string RoleName { get; set; }
    }
}
