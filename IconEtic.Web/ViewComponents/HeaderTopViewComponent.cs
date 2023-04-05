using IconEtic.Business.ComponentHandler;
using IconEtic.Business.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IconEtic.Web.ViewComponents
{
    public class HeaderTopViewComponent : ViewComponent
    {
        private IHeaderTopComponentHandler _headerTopComponentHandler;
        public HeaderTopViewComponent(IHeaderTopComponentHandler headerTopComponentHandler)
        {
            _headerTopComponentHandler = headerTopComponentHandler;
        }

        public ViewViewComponentResult Invoke()
        {
            var result = _headerTopComponentHandler.GetUserData(null, Request);
            return View(result);
        }
    }
}
