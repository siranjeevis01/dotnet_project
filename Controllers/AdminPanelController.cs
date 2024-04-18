using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DOTNET_PROJECT.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            // Display admin panel dashboard
            return View();
        }

        // Actions for managing users, roles, permissions, etc.
    }
}
