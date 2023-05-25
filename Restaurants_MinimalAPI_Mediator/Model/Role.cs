using System.ComponentModel.DataAnnotations;

namespace Restaurants_MinimalAPI_Mediator.Model
{
    public class Role
    {

        [Key]
        public int RoleID { get; set; }

        public string RoleName { get; set; }

    }
}
