using Etic.Entities;

namespace IconEtic.Web.Models
{
    public class ProductDetailModel
    {
        Product Product { get; set; }
        List<ProductImage> Images { get; set; }
    }
}
