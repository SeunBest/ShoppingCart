﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ShoppingCart.Libraries;

namespace ShoppingCart.Helpers
{
    /// <summary>
    /// This class handles the business logic behind the form
    /// </summary>
    public class Connection : IConnection
    {
        string ConnectionString = "Data Source=OLUWASEUN\\MSSQLSERVER07;Initial Catalog=Store;Integrated Security=True";
        SqlConnection con ;

        //This method opens the connection
        public void OpenConnection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }

        //This method closes the connection
        public void CloseConnection()
        {
            con.Close();
        }

        //This method inserts into product table
        public void InsertPro(string name, int cost)
        {
            string query = $"INSERT INTO Product (ProductName, CostPrice) VALUES('{name}', '{cost}')";
            using var cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        //This method edits product table
        public void EditPro(string name, int cost, int id)
        {
            string query = $"UPDATE Product SET ProductName = '{name}', CostPrice = '{cost}' WHERE ProductId = '{id}'";
            using var cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        //This method gets the product table
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            string query = $"select* from Product";
            using var cmd = new SqlCommand(query, con);
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                var product = new Product();
                product.ProductId = (int)result[0];
                product.ProductName = (string)result[1];
                product.CostPrice = (decimal)result[2];
                product.DateAdded = (DateTime)result[3];
                products.Add(product);
            }
            return products;
        }

        //This method filters the product table by name
        public List<Product> FilterProducts(string name)
        {
            List<Product> products = new List<Product>();
            string query = $"SELECT * FROM Product WHERE ProductName LIKE '%{name}%'";
            using var cmd = new SqlCommand(query, con);
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                var product = new Product();
                product.ProductId = (int)result[0];
                product.ProductName = (string)result[1];
                product.CostPrice = (decimal)result[2];
                product.DateAdded = (DateTime)result[3];
                products.Add(product);
            }
            return products;
        }

        //This method filters the product table by price
        public List<Product> FilterPrice(decimal cost)
        {
            List<Product> products = new List<Product>();
            string query = $"SELECT * FROM Product WHERE CostPrice<='{cost}'";
            using var cmd = new SqlCommand(query, con);
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                var product = new Product();
                product.ProductId = (int)result[0];
                product.ProductName = (string)result[1];
                product.CostPrice = (decimal)result[2];
                product.DateAdded = (DateTime)result[3];
                products.Add(product);
            }
            return products;
        }

        //This method gets the cart details into a list
        public List<Cart> GetCart()
        {
            List<Cart> carts = new List<Cart>();
            string query = $"SELECT Cart.Id, Product.ProductName, Product.CostPrice, Cart.Quantity, Cart.DateOfOrder FROM Product INNER JOIN Cart ON Product.ProductId = Cart.ProductId; ";
            using var cmd = new SqlCommand(query, con);
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                var cart = new Cart();
                cart.Id = (int)result[0];
                cart.Name = (string)result[1];
                cart.Cost = (decimal)result[2];
                cart.Quantity = (int)result[3];
                cart.DateOfOrder = (DateTime)result[4];
                carts.Add(cart);
            }
            return carts;
        }

        //This method adds to cart
        public void InsertCart(int ProductId, int qty)
        {
            string query = $"INSERT INTO Cart (ProductId, Quantity) VALUES('{ProductId}', '{qty}')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        //This method from the cart
        public void DelCart(int cid)
        {
            string query = $"DELETE FROM Cart WHERE Id='{cid}'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        //This method clears the cart
        public void ClearCart()
        {
            string query = $"DELETE FROM Cart";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        //This method deletes a product
        public void DelProd(int pid)
        {
            string query = $"DELETE FROM Product WHERE ProductId='{pid}'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        //This method executes given query string
        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }

        //This method reads from query
        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        //This method displays the result of query on the grid view
        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        public List<Product> GetProductsPage(int offs, int sp)
        {
            List<Product> products = new List<Product>();
            string query = $"select * from Product order by ProductName offset {offs} rows fetch next {sp} rows only;";
            using var cmd = new SqlCommand(query, con);
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                var product = new Product();
                product.ProductId = (int)result[0];
                product.ProductName = (string)result[1];
                product.CostPrice = (decimal)result[2];
                product.DateAdded = (DateTime)result[3];
                products.Add(product);
            }
            return products;
        }
    }
}
