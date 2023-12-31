﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Entity
{
    [Table("Order")]
    public class Order : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        [Required]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(200)]
        [Required]
        public string Address { get; set; }
        [DefaultValue(0.0)]
        public double Cost { get; set; }
        [Column(TypeName = "tinyint")]
        [DefaultValue(1)]
        public byte PayingOption { get; set; }
        [Column(TypeName = "ntext")]
        [StringLength(200)]
        [Required]
        public string Note { get; set; }
        [Column(TypeName = "tinyint")]
        [DefaultValue(1)]
        public byte? Type { get; set; }
        [ForeignKey("UserAccount")]
        public int UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
