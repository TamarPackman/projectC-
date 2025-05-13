namespace UI
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
            products = new Button();
            costomers = new Button();
            sales = new Button();
            newOrder = new Button();
            SuspendLayout();
            // 
            // products
            // 
            products.Location = new Point(490, 98);
            products.Margin = new Padding(3, 2, 3, 2);
            products.Name = "products";
            products.Size = new Size(113, 57);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // costomers
            // 
            costomers.Location = new Point(339, 98);
            costomers.Margin = new Padding(3, 2, 3, 2);
            costomers.Name = "costomers";
            costomers.Size = new Size(113, 57);
            costomers.TabIndex = 1;
            costomers.Text = "לקוחות";
            costomers.UseVisualStyleBackColor = true;
            costomers.Click += costomers_Click;
            // 
            // sales
            // 
            sales.Location = new Point(178, 98);
            sales.Margin = new Padding(3, 2, 3, 2);
            sales.Name = "sales";
            sales.Size = new Size(124, 57);
            sales.TabIndex = 2;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            sales.Click += sales_Click;
            // 
            // newOrder
            // 
            newOrder.Location = new Point(25, 258);
            newOrder.Margin = new Padding(3, 2, 3, 2);
            newOrder.Name = "newOrder";
            newOrder.Size = new Size(126, 54);
            newOrder.TabIndex = 3;
            newOrder.Text = "הזמנה חדשה";
            newOrder.UseMnemonic = false;
            newOrder.UseVisualStyleBackColor = true;
            newOrder.Click += newOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(newOrder);
            Controls.Add(sales);
            Controls.Add(costomers);
            Controls.Add(products);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button products;
        private Button costomers;
        private Button sales;
        private Button newOrder;
    }
}