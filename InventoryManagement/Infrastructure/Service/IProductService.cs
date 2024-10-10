using Application.Entity.Model;
using Application.Interface;
using Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class IProductService : IProduct
    {
        private readonly ApplicationContext _applicationContext;
        public IProductService(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void AddProduct(Product product)
        {
            _applicationContext.Product.Add(product);
            _applicationContext.SaveChanges();
        }

        public async Task<IEnumerable<Product>> GetProduct()
        {
            var Products = await _applicationContext.Product.ToListAsync();
            return Products;
        }

        public async Task<Product> Edit(int ID)
        {
            var Products = await _applicationContext.Product.FirstOrDefaultAsync(x => x.Id == ID);
            return Products;
        }

        


    }
}
