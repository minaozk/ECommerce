using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IconEtic.Web.ViewComponents
{
    public class MobileMenuViewComponent : ViewComponent
    {
        public MobileMenuViewComponent()
        {
            
        }
        public ViewViewComponentResult Invoke()
        {

            return View();
        }
    }
}
