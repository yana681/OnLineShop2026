using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        readonly IUsersRepository usersRepository;

        public UserController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public IActionResult Index()
        {
            var users = usersRepository.GetAll();
            return View(users);
        }

        public IActionResult Profile(Guid id)
        {
            var user = usersRepository.TryGetById(id);
            if (user == null) 
                return RedirectToAction("Index");

            return View(user);
        }

    }
}
