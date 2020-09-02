using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Libraries
{
    public class Cart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        //public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfOrder { get; set; }
    }
}
