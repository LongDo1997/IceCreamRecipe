using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.DTO
{
    public class BaseDTO
    {
        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
        public int? UserModifyId { get; set; }
        public int? UserCreatedId { get; set; }
        [DefaultValue(1)]
        public int? Status { get;set; }

    }
}
