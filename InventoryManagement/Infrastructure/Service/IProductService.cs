using Application.Entity.Model;
using Application.Interface;
using Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

		/*****************************************
            TO ADD THE PRODUCT IN TABLE
        *****************************************/
		public void AddProduct(Product product)
        {
                _applicationContext.Product.Add(product);
                _applicationContext.SaveChanges();
        }


		/*****************************************
            TO VIEW THE PRODUCT IN VIEW PAGE
        *****************************************/
		public async Task<IEnumerable<Product>> GetProduct()
        {
            var Products = await _applicationContext.Product.ToListAsync();
            return Products;
        }


		/********************************************************
            TO ADD THE DATA IN FORM OF VIEW PAGE TO DO CHANGES
        *********************************************************/
		public async Task<dynamic> Edit(int ID)
        {
            var Products = await _applicationContext.Product.FirstOrDefaultAsync(x => x.Id == ID);
            return Products;
        }


		/********************************************************
            TO UPDATE THE EXISTING DATA
        *********************************************************/
		public dynamic Update(Product product)
        {
            var Data =  _applicationContext.Product.Update(product);
                       _applicationContext.SaveChanges();
            return Data;
        }
    }
}
