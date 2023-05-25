using System.ComponentModel.DataAnnotations;

namespace Restaurants_MinimalAPI_Mediator.Model
{
    public class Approval
    {
        [Key]
        public int ApprovalID { get; set; }
        public string ApprovalType { get; set; }

    }
}
