using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DataModels
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Username { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Password { get; set; }


        [StringLength(200)]
        public string Picture { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Adddress { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string Phone { get; set; }

        public bool IsAdmin { get; set; }

        public bool Active { get; set; }

    }
}
