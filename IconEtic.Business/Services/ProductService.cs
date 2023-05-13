using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Data;
using IconEtic.Data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace IconEtic.Business.Services
{
	public class ProductService : IProductService
    {
        private readonly IProductDal _productDal;
        private IconEticContext db = new IconEticContext();
        private ICategoryDal _categoryDal;

        public ProductService(IProductDal productDal, ICategoryDal categoryDal)
        {
            _productDal = productDal;
            _categoryDal = categoryDal;
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

        public Product GetById(int productId)
        {
            var result = _productDal.Get(x => x.Id == productId);
            return result;
        }
    }

    public interface IProductService
    {
        IList<Product> GetAll();
        Product GetBySeoUrl(string seoUrl);
        Product GetById(int productId);

    }
}
