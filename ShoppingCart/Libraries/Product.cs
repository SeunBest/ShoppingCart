using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ShoppingCart.Libraries
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal CostPrice { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
