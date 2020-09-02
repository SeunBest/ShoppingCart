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
        int pid;
        decimal price;
        string name = null;
        IConnection Cont;
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
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int.TryParse(EPrice.Text, out int c);
            int.TryParse(id.Text, out int d);

            if (c > 0 && d > 0)
            {
                Cont.OpenConnection();
                Cont.EditPro(EName.Text, c, d);
                this.Products.DataSource = Cont.GetProducts();
                Cont.CloseConnection();
                MessageBox.Show("Product edited successfully");
            }
            else
            {
                MessageBox.Show("Check either your id or new price values");
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
            }
            else
            {
                MessageBox.Show("Highlight a product");
            }
        }
    }
}
