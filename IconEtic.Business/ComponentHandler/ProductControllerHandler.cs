using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Business.Models;
using IconEtic.Business.Services;

namespace IconEtic.Business.ComponentHandler
{
    public class ProductControllerHandler : IProductControllerHandler
    {
        private IProductService _productService;
        private IProductImageService _productImageService;


        public ProductControllerHandler(IProductService productService, IProductImageService productImageService)
        {
            _productService = productService;
            _productImageService = productImageService;
        }

        public ProductControllerHandlerModel Get(string name)
        {
            var productDetail = _productService.GetBySeoUrl(name);
            var productImages = _productImageService.GetAllByProductId(productDetail.Id);

            ProductControllerHandlerModel model = new ProductControllerHandlerModel();
            model.Images = productImages;
            model.Product = productDetail;
            return model;


        }


    }

    public interface IProductControllerHandler
    {
        ProductControllerHandlerModel Get(string name);
        
    }
}