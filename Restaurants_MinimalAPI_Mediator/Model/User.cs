using FluentValidation;
using Stripe;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Restaurants_MinimalAPI_Mediator.Model
{
    public class User
    {

        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public string UserAddress { get; set; }
        public string UserEmail { get; set; }

        public string UserPassword { get; set; }

        public int CityID { get; set; }
        public City City { get; set; }

        public int RoleID { get; set; }

        public Role Role { get; set; }

        public int? ApprovalID { get; set; }
       
        public Approval Approval { get; set; }

        [NotMapped]
        public string Token { get; set; }


    }


   

}
