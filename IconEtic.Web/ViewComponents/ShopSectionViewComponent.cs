using IconEtic.Business.ComponentHandler;
using IconEtic.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace IconEtic.Web.ViewComponents
{
	public class ShopSectionViewComponent : ViewComponent
    {
        private IShopSectionComponentHandler _shopSectionComponentHandler;


        public ShopSectionViewComponent(IShopSectionComponentHandler shopSectionComponentHandler)
        {
            _shopSectionComponentHandler = shopSectionComponentHandler;
        }

        public ViewViewComponentResult Invoke()
        {
            ShopSectionModel model = new ShopSectionModel();
            model.Categories = _shopSectionComponentHandler.GetCategories().Where(x => x.ParentId == 0).ToList();
            model.ProductCategories = _shopSectionComponentHandler.getProductCategories();
            model.Products = _shopSectionComponentHandler.GetProducts();
            model.ProductImages = _shopSectionComponentHandler.getProductImages();
            
            return View(model);

        }
	}
}
