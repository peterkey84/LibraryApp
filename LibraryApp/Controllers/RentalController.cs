using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    public class RentalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
