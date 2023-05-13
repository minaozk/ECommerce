using System.Reflection.PortableExecutable;
using Etic.Entities;

namespace IconEtic.Web.Models
{
    public class ShopSectionModel
    {
        public IList<ProductCategory> ProductCategories { get; set; }
        public IList<Product> Products { get; set; }
        public IList<Category> Categories { get; set; }
        public IList<ProductImage> ProductImages { get; set; }
     


    }
}
