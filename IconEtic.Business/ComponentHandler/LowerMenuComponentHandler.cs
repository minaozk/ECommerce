using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Business.Services;

namespace IconEtic.Business.ComponentHandler
{
    public class LowerMenuComponentHandler : ILowerMenuComponentHandler
    {
        private ILowerCategoryService _lowerCategoryService;

        public LowerMenuComponentHandler(ILowerCategoryService lowerCategoryService)
        {
            _lowerCategoryService = lowerCategoryService;
        }

        public IList<LowerCategory> getLowerCategories()
        {
            return _lowerCategoryService.GetLowerCategories();
        }
    }

    public interface ILowerMenuComponentHandler
    {
        IList<LowerCategory> getLowerCategories();
    }
}
