using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IconEtic.Web.ViewComponents
{
	public class ShopSectionViewComponent : ViewComponent
	{
        public ShopSectionViewComponent()
        {
            
        }

        public ViewViewComponentResult Invoke()
        {
            return View();
        }
	}
}
