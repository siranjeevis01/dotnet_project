using Microsoft.AspNetCore.Mvc;

namespace DOTNET_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Other action methods for the home page
    }
}
