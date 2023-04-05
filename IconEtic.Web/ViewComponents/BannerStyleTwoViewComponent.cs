using IconEtic.Business.ComponentHandler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IconEtic.Web.ViewComponents
{
    public class BannerStyleTwoViewComponent : ViewComponent
    {
        private IBannerStyleTwoComponentHandler _bannerStyleTwoComponentHandler;
        public BannerStyleTwoViewComponent(IBannerStyleTwoComponentHandler bannerStyleTwoComponentHandler)
        {
            _bannerStyleTwoComponentHandler = bannerStyleTwoComponentHandler;
        }
        public ViewViewComponentResult Invoke()
        {
            var result = _bannerStyleTwoComponentHandler.getSlider();
            return View(result.OrderBy(x => x.Sort).ToList());
        }
    }
}
