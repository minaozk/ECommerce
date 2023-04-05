using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Data.Abstract;

namespace IconEtic.Business.Services
{
	public class ProductImageService : IProductImageService
    {
        private IProductImageDal _productImageDal;

        public ProductImageService(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public IList<ProductImage> GetAllByProductId(int productId)
        {
            var result = _productImageDal.GetAll(x => x.ProductId == productId).OrderBy(o => o.Sort).ToList();
            return result;
        }

        public ProductImage GetById(int productId)
        {
            var result = _productImageDal.Get(x => x.ProductId == productId);
            return result;
        }
    }

    public interface IProductImageService
    {
        IList<ProductImage> GetAllByProductId(int productId);
        ProductImage GetById(int productId);
    }
}
