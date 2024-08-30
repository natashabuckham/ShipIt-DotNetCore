﻿﻿using ShipIt.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShipIt.Models.ApiModels
{
    public class StockAlteration
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Weight { get; set; }

        public StockAlteration(int productId, int quantity, double weight)
        {
            this.ProductId = productId;
            this.Quantity = quantity;
            this.Weight = weight;

            if (quantity < 0)
            {
                throw new MalformedRequestException("Alteration must be positive");
            }
        }
    }
}