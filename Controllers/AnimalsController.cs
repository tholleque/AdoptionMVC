using AdoptionMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdoptionMVC.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly AnimalsDbContext _context;
        public AnimalsController(AnimalsDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
