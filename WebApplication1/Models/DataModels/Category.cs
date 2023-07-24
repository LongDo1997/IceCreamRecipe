using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DataModels
{
    [Table("Category")]
    public class Category
    {
    
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}