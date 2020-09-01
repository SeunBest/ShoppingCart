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
    }
}
