using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Data.Abstract;

namespace IconEtic.Business.Services
{
	public class BasketProductService : IBasketProductService
    {
        private IBasketProductDal _basketProductDal;

        public BasketProductService(IBasketProductDal basketProductDal)
        {
            _basketProductDal = basketProductDal;
        }

        public void Add(int productId, int quantity, string guidKey)
        {
            var checkProduct = _basketProductDal.Get(x => x.ProductId == productId && x.Status != false && x.BasketId == Guid.Parse(guidKey));
            if (checkProduct != null)
            {
                checkProduct.Quantity += quantity;
                _basketProductDal.Update(checkProduct);
                return;

            }
            BasketProduct basketProduct = new BasketProduct();
            basketProduct.ProductId = productId;
            basketProduct.Quantity = quantity;
            basketProduct.AddDate = DateTime.Now;
            basketProduct.BasketId = Guid.Parse(guidKey);

            _basketProductDal.Add(basketProduct);
        }

        public IList<BasketProduct> List(string guidKey)
        {
            return _basketProductDal.GetAll(x => x.BasketId == Guid.Parse(guidKey)&& x.Status != false);

        }
    }

    public interface IBasketProductService
    {
        void Add(int productId, int quantity, string guidKey);
        IList<BasketProduct> List(string guidKey);
    }
}
