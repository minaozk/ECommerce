using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Data.Abstract;

namespace IconEtic.Business.Services
{
    public class LowerCategoryService : ILowerCategoryService
    {
        private ILowerCategoryDal _lowerCategoryDal;


        public LowerCategoryService(ILowerCategoryDal lowerCategoryDal)
        {
            _lowerCategoryDal = lowerCategoryDal;
        }

        public IList<LowerCategory> GetLowerCategories()
        {
            return _lowerCategoryDal.GetAll();
        }
    }

    public interface ILowerCategoryService
    {
        IList<LowerCategory> GetLowerCategories();
    }
}
