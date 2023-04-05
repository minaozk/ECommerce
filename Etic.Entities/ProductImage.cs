using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using IconEtic.Core;

namespace Etic.Entities
{
	public class ProductImage : IEntity
	{
		public int Id { get; set; }

        public int ProductId { get; set; }
		public string ImageUrl { get; set; }
		public int Sort { get; set; }

	}
}
