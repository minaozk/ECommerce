using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Data.Abstract;

namespace IconEtic.Business.Services
{
	public class ProductCategoryService : IProductCategoryService	
	{
        IProductCategoryDal _productCategoryDal;


        public ProductCategoryService(IProductCategoryDal productCategoryDal)
        {
            _productCategoryDal = productCategoryDal;
        }

        public IList<ProductCategory> GetProductsWithCategory(int categoryId)
        {
            return _productCategoryDal.GetAll(x => x.CategoryId == categoryId);
        }
    }

    public interface IProductCategoryService
    {
        IList<ProductCategory> GetProductsWithCategory(int categoryId);
    }
}
