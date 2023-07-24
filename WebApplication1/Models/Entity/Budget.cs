using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Entity
{
    [Table("Budget")]
    public class Budget
    {
        /*     [Key]
             [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
             public int Id { get; set; }*/
        [Key]
        [ForeignKey("UserAccount")]
        public int UserId { get; set; }
        [DefaultValue(0.0)]
        public double? Balance { get; set; }
        public virtual UserAccount UserAccount { get; set; }
        
    }
}
