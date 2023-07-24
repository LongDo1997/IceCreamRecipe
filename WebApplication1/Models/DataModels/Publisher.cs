using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DataModels
{
    [Table("Publisher")]
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}