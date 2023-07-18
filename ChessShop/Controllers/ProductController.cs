using Microsoft.AspNetCore.Mvc;

namespace ChessShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewData["PageTitle"] = "Product";
            return View();
        }
    }
}
