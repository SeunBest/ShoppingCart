using ShoppingCart.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Libraries
{
    /// <summary>
    /// This class creates an instance of the Connection class using the 
    /// interface it is implementing
    /// </summary>
    public static class Config
    {
        public static IConnection conte => new Connection();
    }
}
