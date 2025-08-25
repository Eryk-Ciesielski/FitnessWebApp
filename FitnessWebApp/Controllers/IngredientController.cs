using Microsoft.AspNetCore.Mvc;

namespace FitnessWebApp.Controllers
{
    public class IngredientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
