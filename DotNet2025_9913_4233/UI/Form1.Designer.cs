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
            products.Location = new Point(560, 131);
            products.Name = "products";
            products.Size = new Size(129, 76);
            products.TabIndex = 0;
            products.Text = "מוצרים";
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // costomers
            // 
            costomers.Location = new Point(387, 131);
            costomers.Name = "costomers";
            costomers.Size = new Size(129, 76);
            costomers.TabIndex = 1;
            costomers.Text = "לקוחות";
            costomers.UseVisualStyleBackColor = true;
            costomers.Click += costomers_Click;
            // 
            // sales
            // 
            sales.Location = new Point(203, 131);
            sales.Name = "sales";
            sales.Size = new Size(142, 76);
            sales.TabIndex = 2;
            sales.Text = "מבצעים";
            sales.UseVisualStyleBackColor = true;
            sales.Click += sales_Click;
            // 
            // newOrder
            // 
            newOrder.Location = new Point(29, 344);
            newOrder.Name = "newOrder";
            newOrder.Size = new Size(144, 72);
            newOrder.TabIndex = 3;
            newOrder.Text = "הזמנה חדשה";
            newOrder.UseMnemonic = false;
            newOrder.UseVisualStyleBackColor = true;
            newOrder.Click += newOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(newOrder);
            Controls.Add(sales);
            Controls.Add(costomers);
            Controls.Add(products);
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