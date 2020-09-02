using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Libraries
{
    /// <summary>
    /// Creates the cart template for the result of 
    /// querying the database for products and cart information
    /// </summary>
    public class Cart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfOrder { get; set; }
    }
}
