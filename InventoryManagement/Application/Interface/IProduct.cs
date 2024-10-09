using Application.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IProduct
    {
        public void AddProduct(Product product);
        public Task<IEnumerable<Product>> GetProduct();
    }
}
