using System.ComponentModel.DataAnnotations;

namespace Restaurants_MinimalAPI_Mediator.Model
{
    public class AuthenticateResponse
    {

        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public string UserAddress { get; set; }
        public string UserEmail { get; set; }

        public int CityID { get; set; }
       
        public int RoleID { get; set; }

        public int? ApprovalID { get; set; }

        public string Token { get; set; }   


        public AuthenticateResponse(User user, string token)
        {


            UserID = user.UserID;
            UserName = user.UserName;
            UserAge = user.UserAge;
            UserAddress = user.UserAddress;
            UserEmail = user.UserEmail;
            CityID = user.CityID;
            RoleID = user.RoleID;
            ApprovalID = user.ApprovalID;
            Token = token;
        }



    }
}
