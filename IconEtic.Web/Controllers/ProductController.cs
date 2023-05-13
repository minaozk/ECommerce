using IconEtic.Business.ComponentHandler;
using Microsoft.AspNetCore.Mvc;

namespace IconEtic.Web.Controllers
{
    public partial class ProductController : Controller
    {
        private readonly IProductControllerHandler _productControllerHandler;

        public ProductController(IProductControllerHandler productControllerHandler)
        {
            _productControllerHandler = productControllerHandler;
        }

        public IActionResult Index(string name)
        {

            return View(_productControllerHandler.Get(name));
        }
    }
}
