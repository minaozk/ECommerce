using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IconEtic.Web.ViewComponents
{
    public class StickyHeaderViewComponent : ViewComponent
    {
        public StickyHeaderViewComponent()
        {
            
        }
        public ViewViewComponentResult Invoke()
        {

            return View();
        }
    }
}
