using Etic.Entities;
using IconEtic.Business.ComponentHandler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IconEtic.Web.ViewComponents
{
    public class MainMenuNavbarViewComponent : ViewComponent
    {
        private ILowerMenuComponentHandler _lowerMenuComponentHandler;
        public MainMenuNavbarViewComponent(ILowerMenuComponentHandler lowerMenuComponentHandler)
        {
            _lowerMenuComponentHandler = lowerMenuComponentHandler;
        }
        public ViewViewComponentResult Invoke()
        {
            var result = _lowerMenuComponentHandler.getLowerCategories();
            return View(result);
        }
    }
  
}

