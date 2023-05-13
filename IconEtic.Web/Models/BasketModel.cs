﻿using System.Security.AccessControl;
using Etic.Entities;

namespace IconEtic.Web.Models
{
    public class BasketModel
    {
        public IList<BasketProduct> BasketProducts { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public string ProductHtml { get; set; }


    }
}
