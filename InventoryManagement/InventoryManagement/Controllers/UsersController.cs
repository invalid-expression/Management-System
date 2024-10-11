using Application.Entity.Model;
using Application.Interface;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsers _users;
        public UsersController(IUsers users)
        {
            _users = users;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            return View("Create/CreateUser");
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(Users users)
        {
            try
            {
                await _users.CreateUser(users);
            }
            catch (Exception ex) { return Ok(ex.Message); }
            return RedirectToAction("Index", "Home");
        }

		public IActionResult GetUser()
		{
			return View("Get/GetUser");
		}

		[HttpPost]
        public async Task<IActionResult> GetUser(int id)
        {
            var Data = await _users.GetUserByID(id);
            return View("Index", Data);
        }

    }
}