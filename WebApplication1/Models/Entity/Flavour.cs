using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Models.Entity
{
    [Table("Flavour")]
    public class Flavour : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; } = null;
        public string ImageList { get; set; } = null;
        //public ICollection<Recipe> Recipes { get; set; }
    }
}
