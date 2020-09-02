using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ShoppingCart.Libraries
{
    /// <summary>
    /// This interface defines the sql methods
    /// </summary>
    public interface IConnection
    {
        //This method opens the connection
        public void OpenConnection();
        //This method closes the connection
        public void CloseConnection();
        //This method executes given query string
        public void ExecuteQueries(string query);
        //This method inserts into product table
        public void InsertPro(string name, int cost);
        //This method edits on the product table
        public void EditPro(string name, int cost, int id);
        //This method gets the products
        public List<Product> GetProducts();
        //This method gets the cart
        public List<Cart> GetCart();
        //This method deletes an item from the cart
        public void DelCart(int cid);
        //This method deletes an item from the product
        public void DelProd(int pid);
        //This method adds to cart
        public void InsertCart(int ProductId, int qty);
        //This method reads from query
        public SqlDataReader DataReader(string Query_);
        //This method displays the gridview data
        public object ShowDataInGridView(string Query_);
        //This method clears the cart
        public void ClearCart();
        //This method filters products based on name
        public List<Product> FilterProducts(string name);
        //This method filters products based on cost
        public List<Product> FilterPrice(decimal cost);
        public List<Product> GetProductsPage(int offs, int sp);
        
    }
}
