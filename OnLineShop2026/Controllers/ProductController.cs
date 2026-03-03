using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index(int id)
        {
            Product pie = new Product("Пирожок", "с котятами", 50);
            Product cheburec = new Product("Чебурек", "с вишней", 80);
            if (id == 1) return View(pie);
            return View(cheburec);
        }

        //public IActionResult Index()
        //{
        //    Product pie = new Product("Пирожок", "с котятами", 50);
        //    ViewData["pie"] = pie;
        //    return View();
        //}

        //public IActionResult Index()
        //{
        //    Product pie = new Product("Пирожок", "с котятами", 50);
        //    ViewBag.Pie = pie;
        //    return View();
        //}

        //public string Index()
        //{
        //    Product pie = new Product("Пирожок", "с котятами", 50);
        //    return pie.ToString();
        //}
    }
}
