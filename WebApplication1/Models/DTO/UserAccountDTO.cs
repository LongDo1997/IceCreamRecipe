using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.DTO
{
    public class UserAccountDTO : BaseDTO
    {
   
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public byte Type { get; set; }
        public int? BudgetId { get; set; }
        public double? Balance { get; set; }

    }
}
