using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Etic.Entities;
using IconEtic.Business.Services;

namespace IconEtic.Business.ComponentHandler
{
    public class ShopSectionComponentHandler : IShopSectionComponentHandler
    {
        private ICategoryService _categoryService;
        private IProductCategoryService _productCategoryService;
        private IProductService _productService;
        private IProductImageService _productImageService;


        public ShopSectionComponentHandler(ICategoryService categoryService, IProductCategoryService productCategoryService, IProductService productService, IProductImageService productImageService)
        {
            _categoryService = categoryService;
            _productCategoryService = productCategoryService;
            _productService = productService;
            _productImageService = productImageService;
        }

        public IList<Product> GetProducts()
        {
            return _productService.GetAll();
        }

        public IList<Category> GetCategories()
        {
            return _categoryService.getAllCategories();
        }

        public IList<ProductCategory> getProductCategories()
        {
            return _productCategoryService.GetAll();
        }

        public IList<ProductImage> getProductImages()
        {
            return _productImageService.GetAll();
        }

       
    }

    public interface IShopSectionComponentHandler
    {
        IList<Product> GetProducts();
        IList<Category> GetCategories();
        IList<ProductCategory> getProductCategories();
        IList<ProductImage> getProductImages();
        

    }
}

