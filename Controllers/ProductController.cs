using Microsoft.AspNetCore.Mvc;

namespace DOTNET_PROJECT.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Display list of products
            return View();
        }

        public IActionResult Create()
        {
            // Allow admin to create a new product
            return View();
        }

        // Other actions for updating, deleting, and viewing products
    }
}
