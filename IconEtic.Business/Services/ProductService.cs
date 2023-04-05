using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Data.Abstract;

namespace IconEtic.Business.Services
{
	public class ProductService : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IList<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetBySeoUrl(string seoUrl)
        {
            var result = _productDal.Get(x => x.SeoLink == seoUrl);
            return result;
        }
    }

    public interface IProductService
    {
        IList<Product> GetAll();
        Product GetBySeoUrl(string seoUrl);

    }
}
