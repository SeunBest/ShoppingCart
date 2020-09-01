using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ShoppingCart.Libraries;

namespace ShoppingCart.Helpers
{
    public class Connection : IConnection
    {
        string ConnectionString = "Data Source=OLUWASEUN\\MSSQLSERVER07;Initial Catalog=Store;Integrated Security=True";
        SqlConnection con ;

        public void OpenConnection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public void InsertPro(string name, int cost)
        {
            string query = $"INSERT INTO Product (ProductName, CostPrice) VALUES('{name}', '{cost}')";
            using var cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public void EditPro(string name, int cost, int id)
        {
            string query = $"UPDATE Product SET ProductName = '{name}', CostPrice = '{cost}' WHERE ProductId = '{id}'";
            using var cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

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

        public void InsertCart(string name, int cost)
        {
            string query = $"INSERT INTO Product (ProductName, CostPrice) VALUES('{name}', '{cost}')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}
