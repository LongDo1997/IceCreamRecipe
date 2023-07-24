using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Entity
{
    [Table("RecipeFlavour")]
    public class RecipeFlavour : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Flavour")]
        public int FlavourId { get; set;}
        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string unit { get; set; } = null;
        [Column(TypeName = "ntext")]
        public string Description { get; set; } = null;
        public Recipe Recipe { get; set; }
        public Flavour Flavour { get; set; }

    }
}
