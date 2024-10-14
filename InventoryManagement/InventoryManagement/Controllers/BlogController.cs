using Application.Entity.Model;
using Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationContext _context;
        public BlogController(ApplicationContext context)
        {
            _context = context; 
        }
        public IActionResult Index()
        {
            var Post = _context.Posts.ToList();
            return View(Post);
        }
    }
}
