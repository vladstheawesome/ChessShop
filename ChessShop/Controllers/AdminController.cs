using Microsoft.AspNetCore.Mvc;

namespace ChessShop.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
