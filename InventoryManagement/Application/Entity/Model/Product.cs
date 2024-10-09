using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public long? Quantity {  get; set; }

        [Required]
        public long? Price { get; set; }
        
        public DateTime? AddDateTime { get; set; }

        public long? AddedBy { get; set; }

        public DateTime? UpdateDateTime { get; set; }

        public long? UpdatedBy { get; set; }

        public bool? IsActive { get; set; } 

    }
}
