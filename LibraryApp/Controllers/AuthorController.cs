using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
