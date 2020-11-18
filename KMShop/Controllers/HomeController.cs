using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KMShop.Models;
using KMShop.Data.Repository;
using System.Threading.Tasks;
using KMShop.Data.Interfaces;

namespace KMShop.Controllers
{
    public class HomeController : Controller
    {
        CarDbContext db;
        public HomeController(CarDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Cars.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int? id)
        { 
            if (id == null) return RedirectToAction("Index");
            ViewBag.CarId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return "Спасибо " + order.User + " за покупку!";
        }
    }
}
