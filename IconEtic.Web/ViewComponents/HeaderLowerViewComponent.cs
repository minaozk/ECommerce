using IconEtic.Business.ComponentHandler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IconEtic.Web.ViewComponents
{
    public class HeaderLowerViewComponent : ViewComponent
    {
        private ILeftMenuComponentHandler _leftMenuComponentHandler;
        public HeaderLowerViewComponent(ILeftMenuComponentHandler leftMenuComponentHandler)
        {
            _leftMenuComponentHandler = leftMenuComponentHandler;
        }
        public ViewViewComponentResult Invoke()
        {
            var result = _leftMenuComponentHandler.getCategories();
            return View(result);
        }
    }
}
