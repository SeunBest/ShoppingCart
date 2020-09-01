using ShoppingCart.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Libraries
{
    public static class Config
    {
        public static IConnection conte => new Connection();
    }
}
