namespace ShoppingCart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.ProNa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProCost = new System.Windows.Forms.TextBox();
            this.Products = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EPrice = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Cart = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.TextBox();
            this.Fina = new System.Windows.Forms.Button();
            this.Fipa = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(149, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProNa
            // 
            this.ProNa.Location = new System.Drawing.Point(122, 6);
            this.ProNa.Name = "ProNa";
            this.ProNa.Size = new System.Drawing.Size(329, 27);
            this.ProNa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // ProCost
            // 
            this.ProCost.Location = new System.Drawing.Point(59, 44);
            this.ProCost.Name = "ProCost";
            this.ProCost.Size = new System.Drawing.Size(72, 27);
            this.ProCost.TabIndex = 1;
            // 
            // Products
            // 
            this.Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Products.Location = new System.Drawing.Point(12, 317);
            this.Products.Name = "Products";
            this.Products.RowHeadersWidth = 51;
            this.Products.Size = new System.Drawing.Size(439, 316);
            this.Products.TabIndex = 3;
            this.Products.Text = "dataGridView1";
            this.Products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(160, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRODUCTS";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(11, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(439, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Edit Product";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "New product name";
            // 
            // EName
            // 
            this.EName.Location = new System.Drawing.Point(149, 91);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(302, 27);
            this.EName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "New product price";
            // 
            // EPrice
            // 
            this.EPrice.Location = new System.Drawing.Point(149, 124);
            this.EPrice.Name = "EPrice";
            this.EPrice.Size = new System.Drawing.Size(301, 27);
            this.EPrice.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(457, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 54);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add To Cart";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cart
            // 
            this.Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cart.Location = new System.Drawing.Point(741, 47);
            this.Cart.Name = "Cart";
            this.Cart.RowHeadersWidth = 51;
            this.Cart.Size = new System.Drawing.Size(517, 666);
            this.Cart.TabIndex = 3;
            this.Cart.Text = "dataGridView1";
            this.Cart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartCell);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(457, 472);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(278, 54);
            this.button4.TabIndex = 0;
            this.button4.Text = "Remove From Cart";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.DelClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(965, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "CART";
            // 
            // Qty
            // 
            this.Qty.Location = new System.Drawing.Point(678, 363);
            this.Qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(57, 27);
            this.Qty.TabIndex = 6;
            this.Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Product Quantity To Add To Cart";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(268, 659);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(182, 54);
            this.button6.TabIndex = 0;
            this.button6.Text = "Next Page";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Add_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(8, 201);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(439, 29);
            this.button7.TabIndex = 0;
            this.button7.Text = "Delete Product";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ProDel);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(8, 659);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 54);
            this.button5.TabIndex = 0;
            this.button5.Text = "Previous Page";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Add_Click);
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(11, 258);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(120, 27);
            this.Filter.TabIndex = 1;
            // 
            // Fina
            // 
            this.Fina.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Fina.Location = new System.Drawing.Point(137, 258);
            this.Fina.Name = "Fina";
            this.Fina.Size = new System.Drawing.Size(121, 29);
            this.Fina.TabIndex = 0;
            this.Fina.Text = "Filter by Name";
            this.Fina.UseVisualStyleBackColor = false;
            this.Fina.Click += new System.EventHandler(this.FiNa_Click);
            // 
            // Fipa
            // 
            this.Fipa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Fipa.Location = new System.Drawing.Point(264, 258);
            this.Fipa.Name = "Fipa";
            this.Fipa.Size = new System.Drawing.Size(106, 29);
            this.Fipa.TabIndex = 0;
            this.Fipa.Text = "Filter by Price";
            this.Fipa.UseVisualStyleBackColor = false;
            this.Fipa.Click += new System.EventHandler(this.Fip);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Location = new System.Drawing.Point(376, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 29);
            this.button8.TabIndex = 0;
            this.button8.Text = "Refresh";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.FormLoad);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Location = new System.Drawing.Point(457, 545);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(278, 54);
            this.button9.TabIndex = 0;
            this.button9.Text = "Remove From Cart";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.DelClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1271, 734);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.Fipa);
            this.Controls.Add(this.Fina);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.EPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.ProCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProNa);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shopping Cart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClearCart);
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ProNa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProCost;
        private System.Windows.Forms.DataGridView Products;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EPrice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView Cart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Qty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Filter;
        private System.Windows.Forms.Button Fina;
        private System.Windows.Forms.Button Fipa;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

