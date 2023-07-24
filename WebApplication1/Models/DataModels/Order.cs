using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DataModels
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public DateTime OrderDate { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public bool Status { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }

        public Account Account { get; set; }
    }
}