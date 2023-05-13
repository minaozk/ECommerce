using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IconEtic.Core;

namespace Etic.Entities
{
	public class Product : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string SeoLink { get; set; }
        public string? ProductDescription { get; set; }

    }
}
