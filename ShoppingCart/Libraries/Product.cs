using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ShoppingCart.Libraries
{
    /// <summary>
    /// Creates the product template for the result of 
    /// querying the database for products
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal CostPrice { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
