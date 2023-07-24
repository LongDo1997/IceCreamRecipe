using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Entity
{
    public class BaseEntity
    {
        [DataType(DataType.Date)]
        [DisplayFormatAttribute(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormatAttribute(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime? UpdatedAt { get; set; }
        public int? UserModifyId { get; set; }
        public int? UserCreatedId { get; set; }
        [DefaultValue(1)]
        public int? Status { get;set; }

        public void prePersist()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public void preUpdate()
        {
            this.UpdatedAt = DateTime.Now;
        }
    }
}
