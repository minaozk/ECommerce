using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Etic.Entities;
using IconEtic.Business.Helpers;
using IconEtic.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace IconEtic.Business.ControllerHandler
{
    public class ApiControllerHandler : IApiControllerHandler
    {
        private IBasketService _basketService;
        private IBasketProductService _basketProductService;
        private ICookieHelper _cookieHelper;
        private IProductService _productService;
        private IProductImageService _productImageService;


        public ApiControllerHandler(IBasketService basketService, IBasketProductService basketProductService, ICookieHelper cookieHelper, IProductService productService, IProductImageService productImageService)
        {
            _basketService = basketService;
            _basketProductService = basketProductService;
            _cookieHelper = cookieHelper;
            _productService = productService;
            _productImageService = productImageService;
        }


        public Guid CheckBasket(HttpRequest request, HttpResponse response)
        {

            var cookie = _cookieHelper.Read(CookieTypes.Basket, request);
            if (cookie == null)
            {
                Guid guid = Guid.NewGuid();
                CreateBasket(guid);
                _cookieHelper.Create(CookieTypes.Basket,guid.ToString(), DateTime.Now.AddYears(1), response );
                return guid;
            }
            else
            {
                var checkBasketForDb = _basketService.CheckBasket(Guid.Parse(cookie));
                if (!checkBasketForDb)
                {
                    Guid guid = Guid.NewGuid();
                    CreateBasket(guid);
                    _cookieHelper.Create(CookieTypes.Basket, guid.ToString(), DateTime.Now.AddYears(1), response);
                    return guid;
                }
                else
                {
                    return Guid.Parse(cookie);
                }
            }
        }

        public void CreateBasket(Guid guid)
        {
            _basketService.CreateBasket(guid);
        }

        public void AddBasketProduct(int productId, int quantity, string guidKey)
        {
            _basketProductService.Add(productId, quantity, guidKey);
        }

        public IList<BasketProduct> GetBasketProducts(string guidKey)
        {
            return _basketProductService.List(guidKey);
        }

        public IList<Product> GetBasketProductCalculatePrice(int[] products)
        {
            IList<Product> result = new List<Product>();
            foreach (var item in products)
            {
             var product = _productService.GetById(item);
             result.Add(product);
            }

            return result;


        }

        public string GetProductImage(int productId)
        {
            var image = _productImageService.GetById(productId);
            return "/" + image.ImageUrl;
        }


        /* public string GenerateProducts(IList<Product> products, BasketModel model)
         {
             string template = System.IO.File.ReadAllText(Environment.CurrentDirectory+"/TextTemplates/BasketProduct.txt");

             string temp = template;
             string result = null;

             foreach (var item in products)
             {
                 template = template.Replace("[link]", "/product/" + item.SeoLink);
                 template = template.Replace("[img]", _apiControllerHandler.GetProductImage(item.Id));
                 template = template.Replace("[name]", item.Name);
                 template = template.Replace("[price]", item.Price.ToString());
                 var q = model.BasketProducts.FirstOrDefault(x => x.ProductId == item.Id).Quantity;

                 template = template.Replace("[total]", (q * item.Price).ToString("C"));

                 template = template.Replace("[quantity]", q.ToString());
                 result += template;
                 template = temp;

             }

             return result;
         } */
    }

    public interface IApiControllerHandler
    {
        Guid CheckBasket(HttpRequest request, HttpResponse response);
        void CreateBasket(Guid guid);
        void AddBasketProduct(int productId, int quantity, string guidKey);
        IList<BasketProduct> GetBasketProducts(string guidKey);
        IList<Product> GetBasketProductCalculatePrice(int[] products);

        string GetProductImage(int productId);


    }
}
