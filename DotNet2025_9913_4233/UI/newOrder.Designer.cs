namespace UI
{
    partial class newOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productId = new Label();
            productIdInput = new TextBox();
            selectFromList = new Button();
            countForOrder = new NumericUpDown();
            label1 = new Label();
            addToOrder = new Button();
            cart = new ListBox();
            showProducts = new ListBox();
            finishOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)countForOrder).BeginInit();
            SuspendLayout();
            // 
            // productId
            // 
            productId.AutoSize = true;
            productId.Location = new Point(720, 32);
            productId.Name = "productId";
            productId.Size = new Size(52, 15);
            productId.TabIndex = 0;
            productId.Text = "קוד מוצר";
            // 
            // productIdInput
            // 
            productIdInput.Location = new Point(604, 32);
            productIdInput.Name = "productIdInput";
            productIdInput.Size = new Size(100, 23);
            productIdInput.TabIndex = 1;
            // 
            // selectFromList
            // 
            selectFromList.Location = new Point(616, 85);
            selectFromList.Name = "selectFromList";
            selectFromList.Size = new Size(153, 26);
            selectFromList.TabIndex = 2;
            selectFromList.Text = "בחירה מתוך רשימה";
            selectFromList.UseVisualStyleBackColor = true;
            selectFromList.Click += selectFromList_Click;
            // 
            // countForOrder
            // 
            countForOrder.Location = new Point(604, 130);
            countForOrder.Name = "countForOrder";
            countForOrder.Size = new Size(104, 23);
            countForOrder.TabIndex = 3;
            countForOrder.ValueChanged += countForOrder_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(718, 133);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 4;
            label1.Text = "כמות להזמנה";
            // 
            // addToOrder
            // 
            addToOrder.Location = new Point(616, 173);
            addToOrder.Name = "addToOrder";
            addToOrder.Size = new Size(153, 24);
            addToOrder.TabIndex = 5;
            addToOrder.Text = "הוסף להזמנה";
            addToOrder.UseVisualStyleBackColor = true;
            addToOrder.Click += addToOrder_Click;
            // 
            // cart
            // 
            cart.FormattingEnabled = true;
            cart.ItemHeight = 15;
            cart.Location = new Point(68, 32);
            cart.Name = "cart";
            cart.Size = new Size(236, 289);
            cart.TabIndex = 6;
            // 
            // showProducts
            // 
            showProducts.FormattingEnabled = true;
            showProducts.ItemHeight = 15;
            showProducts.Location = new Point(604, 225);
            showProducts.Name = "showProducts";
            showProducts.Size = new Size(165, 169);
            showProducts.TabIndex = 7;
            showProducts.SelectedIndexChanged += showProducts_SelectedIndexChanged;
            // 
            // finishOrder
            // 
            finishOrder.Location = new Point(151, 352);
            finishOrder.Name = "finishOrder";
            finishOrder.Size = new Size(75, 23);
            finishOrder.TabIndex = 8;
            finishOrder.Text = "סיום הזמנה";
            finishOrder.UseVisualStyleBackColor = true;
            finishOrder.Click += finishOrder_Click;
            // 
            // newOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(finishOrder);
            Controls.Add(showProducts);
            Controls.Add(cart);
            Controls.Add(addToOrder);
            Controls.Add(label1);
            Controls.Add(countForOrder);
            Controls.Add(selectFromList);
            Controls.Add(productIdInput);
            Controls.Add(productId);
            Name = "newOrder";
            Text = "newOrder";
            Load += newOrder_Load;
            ((System.ComponentModel.ISupportInitialize)countForOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productId;
        private TextBox productIdInput;
        private Button selectFromList;
        private NumericUpDown countForOrder;
        private Label label1;
        private Button addToOrder;
        private ListBox cart;
        private ListBox showProducts;
        private Button finishOrder;
    }
}