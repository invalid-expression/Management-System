using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Application.Entity.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public long Quantity {  get; set; }

        public long Price { get; set; }
        
        public DateTime AddedDate { get; set; }

        public long AddedBy { get; set; }

        public DateTime UpdateDateTime { get; set; }

        public long UpdatedBy { get; set; }

        public bool IsActive { get; set; } 

    }
}
