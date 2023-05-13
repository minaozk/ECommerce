using Microsoft.AspNetCore.Mvc;

namespace IconEtic.Web.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
