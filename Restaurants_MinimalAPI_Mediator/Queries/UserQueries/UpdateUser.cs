using MediatR;
using Restaurants_MinimalAPI_Mediator.Model;
using System.ComponentModel.DataAnnotations;

namespace Restaurants_MinimalAPI_Mediator.Queries.UserQueries
{
    public class UpdateUser : IRequest<IEnumerable<User>>
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
    }
}
