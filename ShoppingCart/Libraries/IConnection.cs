﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ShoppingCart.Libraries
{
    public interface IConnection
    {
        public void OpenConnection();
        public void CloseConnection();
        public void ExecuteQueries(string query);
        public void InsertPro(string name, int cost);
        public void EditPro(string name, int cost, int id);
        public List<Product> GetProducts();
        public List<Cart> GetCart();
        public void DelCart(int cid);
        public void DelProd(int pid);
       
        public void InsertCart(int ProductId, int qty);
        public SqlDataReader DataReader(string Query_);

        public object ShowDataInGridView(string Query_);
        public void ClearCart();
        public List<Product> FilterProducts(string name);
        public List<Product> FilterPrice(decimal cost);
    }
}
