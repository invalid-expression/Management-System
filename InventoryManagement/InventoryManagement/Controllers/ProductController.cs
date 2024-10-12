using Application.Entity.Model;
using Application.Interface;
using Infrastructure.Context;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InventoryManagement.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _iproduct;
        public ProductController(IProduct iproduct)
        {
            _iproduct = iproduct;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var Product = await _iproduct.GetProduct();
                return View(Product);
            }
            catch (Exception ex) { return Ok(ex.Message); }
            
        }

        public IActionResult AddProduct()               
        {
            return View("Add/AddProduct");
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _iproduct.AddProduct(product);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (Exception ex) { return Ok(ex.Message); }
        }

        public async Task<IActionResult> Edit(int ID)
        {
            try
            {
                var ProductData = await _iproduct.Edit(ID);
                return View("Update/Edit", ProductData);
            }
            catch (Exception ex) { return Ok(ex.Message); }
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _iproduct.Update(product);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (Exception ex) { return Ok(ex.Message); }
            
        } 
    }
}
