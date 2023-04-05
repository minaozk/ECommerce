using IconEtic.Business.ComponentHandler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IconEtic.Web.ViewComponents
{
    public class CollectionSectionViewComponent : ViewComponent
    {
        private ICollectionSectionComponentHandler _collectionSectionComponentHandler;
        public CollectionSectionViewComponent(ICollectionSectionComponentHandler collectionSectionComponentHandler)
        {
            _collectionSectionComponentHandler = collectionSectionComponentHandler;
        }
        public ViewViewComponentResult Invoke()
        {
            var result = _collectionSectionComponentHandler.getSlider();
           
            return View(result.OrderBy(x => x.Sort).ToList());
        }
    }
}
