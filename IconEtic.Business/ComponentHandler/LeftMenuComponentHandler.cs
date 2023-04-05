using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Business.Services;

namespace IconEtic.Business.ComponentHandler
{
    public class LeftMenuComponentHandler : ILeftMenuComponentHandler
    {
        private ICategoryService _categoryService;

        public LeftMenuComponentHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IList<Category> getCategories()
        {
            return _categoryService.getAllCategories();
        }
    }

    public interface ILeftMenuComponentHandler
    {
        IList<Category> getCategories();
    }
}
