using GITPractice.Data;
using GITPractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace GITPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }

        // POST (Form Save)
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}