using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DataModels
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Author { get; set; }

        public int? Release { get; set; }

        public float? Price { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [StringLength(100)]
        public string Picture { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }

        public Publisher Publisher { get; set; }

        public Category Category { get; set; }
    }
}