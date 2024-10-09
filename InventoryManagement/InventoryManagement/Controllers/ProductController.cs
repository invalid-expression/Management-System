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
            var Product = await _iproduct.GetProduct();
            return View(Product);
        }

        public IActionResult AddProduct()
        {
            return View("Add/AddProduct");
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _iproduct.AddProduct(product);
            return RedirectToAction("Index");
        }
    }
}
