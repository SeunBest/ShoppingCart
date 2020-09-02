using ShoppingCart.Helpers;
using ShoppingCart.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Declaration of global variables used to track productid
        /// customerid,textbox values and an instance of IConnection interface
        /// </summary>
        int pid;
        int cid;
        int cur;
        decimal price;
        string name = null;
        IConnection Cont;

        //Construct form with 
        public Form1(IConnection cont)
        {
            InitializeComponent();
            Cont = cont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(ProCost.Text, out int d);

            if (d > 0)
            {
                Cont.OpenConnection();
                Cont.InsertPro(ProNa.Text, d);
                this.Products.DataSource = Cont.GetProducts();
                Cont.CloseConnection();
                MessageBox.Show("Product added successfully");
            }
            else
            {
                MessageBox.Show("Enter a number greater than 0");
            }

        }

        private void FormLoad(object sender, EventArgs e)
        {
            Cont.OpenConnection();
            this.Products.DataSource = Cont.GetProducts();
            Cont.CloseConnection();

            Cont.OpenConnection();
            Cart.DataSource = Cont.GetCart();
            Cont.CloseConnection();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int.TryParse(EPrice.Text, out int c);

            if (c > 0 && pid > 0 && EName.Text != "")
            {
                Cont.OpenConnection();
                Cont.EditPro(EName.Text, c, pid);
                this.Products.DataSource = Cont.GetProducts();
                Cont.CloseConnection();
                MessageBox.Show("Product edited successfully");
                pid = 0;
            }
            else
            {
                MessageBox.Show("Please highlight a product and also input a new product name and a new product price");
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Products.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Products.CurrentRow.Selected = true;
                name = Products.Rows[e.RowIndex].Cells["ProductName"].FormattedValue.ToString();
                price = Decimal.Parse(Products.Rows[e.RowIndex].Cells["CostPrice"].FormattedValue.ToString());
                pid = Convert.ToInt32(Products.Rows[e.RowIndex].Cells["ProductId"].FormattedValue.ToString());
               // MessageBox.Show($"{name}, {price}, {pid}");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
           int qty = (int)Qty.Value;
           if (name != null)
            {
                Cont.OpenConnection();
                Cont.InsertCart(pid, qty);
                this.Cart.DataSource = Cont.GetCart();
                Cont.CloseConnection();
                MessageBox.Show("Product added successfully to cart");
                name = null;
                Qty.Value = 1;
                pid = 0;
            }
            else
            {
                MessageBox.Show("Highlight a product");
            }
        }

        private void DelClick(object sender, EventArgs e)
        {
            if (cid != 0)
            {
                Cont.OpenConnection();
                Cont.DelCart(cid);
                this.Cart.DataSource = Cont.GetCart();
                Cont.CloseConnection();
                MessageBox.Show("Product successfully removed from cart");
                cid = 0;
            } else
            {
                MessageBox.Show("Please highlight product to remove from cart");
            }
        }

        private void CartCell(object sender, DataGridViewCellEventArgs e)
        {
            if (Cart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Cart.CurrentRow.Selected = true;
               // name = Products.Rows[e.RowIndex].Cells["ProductName"].FormattedValue.ToString();
                //price = Decimal.Parse(Products.Rows[e.RowIndex].Cells["CostPrice"].FormattedValue.ToString());
                cid = Convert.ToInt32(Cart.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                // MessageBox.Show($"{name}, {price}, {pid}");
            }
        }

        private void ProDel(object sender, EventArgs e)
        {
            if (pid != 0)
            {
                Cont.OpenConnection();
                Cont.DelProd(pid);
                this.Products.DataSource = Cont.GetProducts();
                Cont.CloseConnection();
                MessageBox.Show("Product successfully removed from cart");
                pid = 0;
            }
            else
            {
                MessageBox.Show("Please highlight the product you want to remove");
            }
        }

        private void ClearCart(object sender, FormClosingEventArgs e)
        {
            Cont.OpenConnection();
            Cont.ClearCart();
            Cont.CloseConnection();
        }

        private void FiNa_Click(object sender, EventArgs e)
        {
            Cont.OpenConnection();
            Products.DataSource = Cont.FilterProducts(Filter.Text);
            Cont.CloseConnection();
        }

        private void Fip(object sender, EventArgs e)
        {

            int.TryParse(Filter.Text, out int c);

            if (c > 0)
            {
                Cont.OpenConnection();
                this.Products.DataSource = Cont.FilterPrice(c);
                Cont.CloseConnection();
            }
            else
            {
                MessageBox.Show("The filter price button only works with decimals, try filter by name for text");
            }
        }

        private void Cleca(object sender, EventArgs e)
        {
            Cont.OpenConnection();
            Cont.ClearCart();
            Cont.CloseConnection();

            Cont.OpenConnection();
            Cart.DataSource = Cont.GetCart();
            Cont.CloseConnection();
        }

        private void Nex(object sender, EventArgs e)
        {
            Cont.OpenConnection();
            var co = Cont.GetProducts();
            Cont.CloseConnection();
            int cos = co.Count();
            if (cur <= cos)
            {
                Cont.OpenConnection();
                Products.DataSource = Cont.GetProductsPage(cur, 5);
                Cont.CloseConnection();
                cur += 5;
            }
            else
            {
                MessageBox.Show("End of Pages");
            }
        }
    }
}
