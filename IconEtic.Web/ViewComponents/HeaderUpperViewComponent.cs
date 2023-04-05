using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IconEtic.Web.ViewComponents
{
    public class HeaderUpperViewComponent : ViewComponent
    {
        public HeaderUpperViewComponent()
        {
            
        }
        public ViewViewComponentResult Invoke()
        {

            return View();
        }
    }
}
