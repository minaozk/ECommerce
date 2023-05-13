using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using IconEtic.Core;

namespace Etic.Entities
{
	public class BasketProduct : IEntity	
	{
        public int Id { get; set; }
        public Guid BasketId { get; set; }
        public int  ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime AddDate { get; set; }
        public bool? Status { get; set; }

        
        
        
    }
}
