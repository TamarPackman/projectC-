namespace UI
{
    partial class saleMenu
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
            menu = new TabControl();
            addSale = new TabPage();
            dateEndSale = new DateTimePicker();
            dateTimeEnd = new Label();
            dateBeginSale = new Label();
            dateTimeBegin = new DateTimePicker();
            fevoriteCustomer = new CheckBox();
            saveSale = new Button();
            saleDiscount = new TextBox();
            quantityInStock = new Label();
            quantityInSaleInput = new TextBox();
            productPrice = new Label();
            nameProduct = new Label();
            ProductIdInput = new TextBox();
            deleteSale = new TabPage();
            delete = new Button();
            inputSaleId = new TextBox();
            productId = new Label();
            searchSale = new TabPage();
            showSaleBySearch = new ListBox();
            search = new Button();
            inputIdSale = new TextBox();
            productName = new Label();
            updateSale = new TabPage();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            save = new Button();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            saleForClubMembers = new CheckBox();
            discountPriceInput = new NumericUpDown();
            quantityToSaleInput = new NumericUpDown();
            inputNameProductToChange = new TextBox();
            discountPrice = new Label();
            quantityToSale = new Label();
            productIdToChange = new Label();
            change = new Button();
            inputSaleIdToChange = new TextBox();
            saleIdChange = new Label();
            showSales = new ListBox();
            menu.SuspendLayout();
            addSale.SuspendLayout();
            deleteSale.SuspendLayout();
            searchSale.SuspendLayout();
            updateSale.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)discountPriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quantityToSaleInput).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Controls.Add(addSale);
            menu.Controls.Add(deleteSale);
            menu.Controls.Add(searchSale);
            menu.Controls.Add(updateSale);
            menu.Location = new Point(10, 51);
            menu.Margin = new Padding(3, 2, 3, 2);
            menu.Name = "menu";
            menu.SelectedIndex = 0;
            menu.Size = new Size(404, 323);
            menu.TabIndex = 0;
            // 
            // addSale
            // 
            addSale.Controls.Add(dateEndSale);
            addSale.Controls.Add(dateTimeEnd);
            addSale.Controls.Add(dateBeginSale);
            addSale.Controls.Add(dateTimeBegin);
            addSale.Controls.Add(fevoriteCustomer);
            addSale.Controls.Add(saveSale);
            addSale.Controls.Add(saleDiscount);
            addSale.Controls.Add(quantityInStock);
            addSale.Controls.Add(quantityInSaleInput);
            addSale.Controls.Add(productPrice);
            addSale.Controls.Add(nameProduct);
            addSale.Controls.Add(ProductIdInput);
            addSale.Location = new Point(4, 24);
            addSale.Margin = new Padding(3, 2, 3, 2);
            addSale.Name = "addSale";
            addSale.Padding = new Padding(3, 2, 3, 2);
            addSale.Size = new Size(396, 295);
            addSale.TabIndex = 0;
            addSale.Text = "הוספה";
            addSale.UseVisualStyleBackColor = true;
            // 
            // dateEndSale
            // 
            dateEndSale.Location = new Point(20, 134);
            dateEndSale.Margin = new Padding(3, 2, 3, 2);
            dateEndSale.Name = "dateEndSale";
            dateEndSale.Size = new Size(190, 23);
            dateEndSale.TabIndex = 24;
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.AutoSize = true;
            dateTimeEnd.Location = new Point(248, 137);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(106, 15);
            dateTimeEnd.TabIndex = 23;
            dateTimeEnd.Text = "תאריך סיום המבצע";
            dateTimeEnd.Click += dateTimeEnd_Click;
            // 
            // dateBeginSale
            // 
            dateBeginSale.AutoSize = true;
            dateBeginSale.Location = new Point(228, 109);
            dateBeginSale.Name = "dateBeginSale";
            dateBeginSale.Size = new Size(125, 15);
            dateBeginSale.TabIndex = 23;
            dateBeginSale.Text = "תאריך התחלת המבצע";
            // 
            // dateTimeBegin
            // 
            dateTimeBegin.Location = new Point(20, 109);
            dateTimeBegin.Margin = new Padding(3, 2, 3, 2);
            dateTimeBegin.Name = "dateTimeBegin";
            dateTimeBegin.Size = new Size(190, 23);
            dateTimeBegin.TabIndex = 22;
            // 
            // fevoriteCustomer
            // 
            fevoriteCustomer.AutoSize = true;
            fevoriteCustomer.Location = new Point(76, 61);
            fevoriteCustomer.Margin = new Padding(3, 2, 3, 2);
            fevoriteCustomer.Name = "fevoriteCustomer";
            fevoriteCustomer.Size = new Size(131, 19);
            fevoriteCustomer.TabIndex = 21;
            fevoriteCustomer.Text = "המבצע לחברי מועדון";
            fevoriteCustomer.UseVisualStyleBackColor = true;
            // 
            // saveSale
            // 
            saveSale.Location = new Point(163, 173);
            saveSale.Margin = new Padding(3, 2, 3, 2);
            saveSale.Name = "saveSale";
            saveSale.Size = new Size(82, 22);
            saveSale.TabIndex = 20;
            saveSale.Text = "שמור מבצע";
            saveSale.UseVisualStyleBackColor = true;
            saveSale.Click += saveSale_Click;
            // 
            // saleDiscount
            // 
            saleDiscount.Location = new Point(228, 58);
            saleDiscount.Margin = new Padding(3, 2, 3, 2);
            saleDiscount.Name = "saleDiscount";
            saleDiscount.Size = new Size(68, 23);
            saleDiscount.TabIndex = 18;
            // 
            // quantityInStock
            // 
            quantityInStock.AutoSize = true;
            quantityInStock.Location = new Point(303, 61);
            quantityInStock.Name = "quantityInStock";
            quantityInStock.Size = new Size(36, 15);
            quantityInStock.TabIndex = 17;
            quantityInStock.Text = "הנחה";
            // 
            // quantityInSaleInput
            // 
            quantityInSaleInput.Location = new Point(10, 19);
            quantityInSaleInput.Margin = new Padding(3, 2, 3, 2);
            quantityInSaleInput.Name = "quantityInSaleInput";
            quantityInSaleInput.Size = new Size(110, 23);
            quantityInSaleInput.TabIndex = 14;
            // 
            // productPrice
            // 
            productPrice.AutoSize = true;
            productPrice.Location = new Point(122, 21);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(73, 15);
            productPrice.TabIndex = 13;
            productPrice.Text = "כמות במבצע";
            // 
            // nameProduct
            // 
            nameProduct.AutoSize = true;
            nameProduct.Location = new Point(319, 21);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(63, 15);
            nameProduct.TabIndex = 12;
            nameProduct.Text = "מזהה מוצר";
            // 
            // ProductIdInput
            // 
            ProductIdInput.Location = new Point(206, 19);
            ProductIdInput.Margin = new Padding(3, 2, 3, 2);
            ProductIdInput.Name = "ProductIdInput";
            ProductIdInput.Size = new Size(110, 23);
            ProductIdInput.TabIndex = 11;
            // 
            // deleteSale
            // 
            deleteSale.Controls.Add(delete);
            deleteSale.Controls.Add(inputSaleId);
            deleteSale.Controls.Add(productId);
            deleteSale.Location = new Point(4, 24);
            deleteSale.Margin = new Padding(3, 2, 3, 2);
            deleteSale.Name = "deleteSale";
            deleteSale.Padding = new Padding(3, 2, 3, 2);
            deleteSale.Size = new Size(396, 295);
            deleteSale.TabIndex = 1;
            deleteSale.Text = "מחיקה";
            deleteSale.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(115, 129);
            delete.Margin = new Padding(3, 2, 3, 2);
            delete.Name = "delete";
            delete.Size = new Size(82, 22);
            delete.TabIndex = 19;
            delete.Text = "מחק";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // inputSaleId
            // 
            inputSaleId.Location = new Point(87, 62);
            inputSaleId.Margin = new Padding(3, 2, 3, 2);
            inputSaleId.Name = "inputSaleId";
            inputSaleId.Size = new Size(110, 23);
            inputSaleId.TabIndex = 18;
            // 
            // productId
            // 
            productId.AutoSize = true;
            productId.Location = new Point(202, 64);
            productId.Name = "productId";
            productId.Size = new Size(112, 15);
            productId.TabIndex = 17;
            productId.Text = "מזהה מבצע למחיקה";
            // 
            // searchSale
            // 
            searchSale.Controls.Add(showSaleBySearch);
            searchSale.Controls.Add(search);
            searchSale.Controls.Add(inputIdSale);
            searchSale.Controls.Add(productName);
            searchSale.Location = new Point(4, 24);
            searchSale.Margin = new Padding(3, 2, 3, 2);
            searchSale.Name = "searchSale";
            searchSale.Padding = new Padding(3, 2, 3, 2);
            searchSale.Size = new Size(396, 295);
            searchSale.TabIndex = 2;
            searchSale.Text = "חיפוש";
            searchSale.UseVisualStyleBackColor = true;
            // 
            // showSaleBySearch
            // 
            showSaleBySearch.FormattingEnabled = true;
            showSaleBySearch.ItemHeight = 15;
            showSaleBySearch.Location = new Point(120, 83);
            showSaleBySearch.Name = "showSaleBySearch";
            showSaleBySearch.Size = new Size(210, 94);
            showSaleBySearch.TabIndex = 7;
            // 
            // search
            // 
            search.Location = new Point(49, 38);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 6;
            search.Text = "חפש";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // inputIdSale
            // 
            inputIdSale.Location = new Point(150, 36);
            inputIdSale.Name = "inputIdSale";
            inputIdSale.Size = new Size(100, 23);
            inputIdSale.TabIndex = 5;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Location = new Point(265, 38);
            productName.Name = "productName";
            productName.Size = new Size(98, 15);
            productName.TabIndex = 4;
            productName.Text = "הכנס מזהה מבצע";
            // 
            // updateSale
            // 
            updateSale.Controls.Add(panel1);
            updateSale.Controls.Add(change);
            updateSale.Controls.Add(inputSaleIdToChange);
            updateSale.Controls.Add(saleIdChange);
            updateSale.Location = new Point(4, 24);
            updateSale.Margin = new Padding(3, 2, 3, 2);
            updateSale.Name = "updateSale";
            updateSale.Padding = new Padding(3, 2, 3, 2);
            updateSale.Size = new Size(396, 295);
            updateSale.TabIndex = 3;
            updateSale.Text = "עדכון";
            updateSale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(save);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(saleForClubMembers);
            panel1.Controls.Add(discountPriceInput);
            panel1.Controls.Add(quantityToSaleInput);
            panel1.Controls.Add(inputNameProductToChange);
            panel1.Controls.Add(discountPrice);
            panel1.Controls.Add(quantityToSale);
            panel1.Controls.Add(productIdToChange);
            panel1.Location = new Point(0, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 220);
            panel1.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(14, 113);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(190, 23);
            dateTimePicker1.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 116);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 40;
            label1.Text = "תאריך סיום המבצע";
            // 
            // save
            // 
            save.Location = new Point(156, 174);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 37;
            save.Text = "שמור";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 88);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 41;
            label2.Text = "תאריך התחלת המבצע";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(14, 88);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(190, 23);
            dateTimePicker2.TabIndex = 39;
            // 
            // saleForClubMembers
            // 
            saleForClubMembers.AutoSize = true;
            saleForClubMembers.Location = new Point(207, 47);
            saleForClubMembers.Name = "saleForClubMembers";
            saleForClubMembers.Size = new Size(123, 19);
            saleForClubMembers.TabIndex = 38;
            saleForClubMembers.Text = "מבצע לחברי מועדון";
            saleForClubMembers.UseVisualStyleBackColor = true;
            // 
            // discountPriceInput
            // 
            discountPriceInput.Location = new Point(14, 49);
            discountPriceInput.Name = "discountPriceInput";
            discountPriceInput.Size = new Size(108, 23);
            discountPriceInput.TabIndex = 36;
            // 
            // quantityToSaleInput
            // 
            quantityToSaleInput.Location = new Point(9, 12);
            quantityToSaleInput.Name = "quantityToSaleInput";
            quantityToSaleInput.Size = new Size(111, 23);
            quantityToSaleInput.TabIndex = 35;
            // 
            // inputNameProductToChange
            // 
            inputNameProductToChange.Location = new Point(200, 11);
            inputNameProductToChange.Name = "inputNameProductToChange";
            inputNameProductToChange.Size = new Size(100, 23);
            inputNameProductToChange.TabIndex = 34;
            // 
            // discountPrice
            // 
            discountPrice.AutoSize = true;
            discountPrice.Location = new Point(132, 51);
            discountPrice.Name = "discountPrice";
            discountPrice.Size = new Size(65, 15);
            discountPrice.TabIndex = 33;
            discountPrice.Text = "מחיר הנחה";
            // 
            // quantityToSale
            // 
            quantityToSale.AutoSize = true;
            quantityToSale.Location = new Point(124, 16);
            quantityToSale.Name = "quantityToSale";
            quantityToSale.Size = new Size(73, 15);
            quantityToSale.TabIndex = 32;
            quantityToSale.Text = "כמות למבצע";
            // 
            // productIdToChange
            // 
            productIdToChange.AutoSize = true;
            productIdToChange.Location = new Point(306, 13);
            productIdToChange.Name = "productIdToChange";
            productIdToChange.Size = new Size(52, 15);
            productIdToChange.TabIndex = 31;
            productIdToChange.Text = "קוד מוצר";
            // 
            // change
            // 
            change.Location = new Point(170, 46);
            change.Name = "change";
            change.Size = new Size(75, 23);
            change.TabIndex = 16;
            change.Text = "שינוי";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
            // 
            // inputSaleIdToChange
            // 
            inputSaleIdToChange.Location = new Point(132, 8);
            inputSaleIdToChange.Name = "inputSaleIdToChange";
            inputSaleIdToChange.Size = new Size(100, 23);
            inputSaleIdToChange.TabIndex = 15;
            // 
            // saleIdChange
            // 
            saleIdChange.AutoSize = true;
            saleIdChange.Location = new Point(248, 11);
            saleIdChange.Name = "saleIdChange";
            saleIdChange.Size = new Size(120, 15);
            saleIdChange.TabIndex = 14;
            saleIdChange.Text = "הכנס קוד מבצע לשינוי";
            // 
            // showSales
            // 
            showSales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showSales.Cursor = Cursors.SizeNESW;
            showSales.FormattingEnabled = true;
            showSales.HorizontalScrollbar = true;
            showSales.IntegralHeight = false;
            showSales.ItemHeight = 15;
            showSales.Location = new Point(454, 77);
            showSales.Margin = new Padding(3, 2, 3, 2);
            showSales.Name = "showSales";
            showSales.ScrollAlwaysVisible = true;
            showSales.Size = new Size(365, 297);
            showSales.TabIndex = 1;
            showSales.SelectedIndexChanged += showSales_SelectedIndexChanged;
            // 
            // saleMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 422);
            Controls.Add(showSales);
            Controls.Add(menu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "saleMenu";
            Text = "saleMenu";
            Load += saleMenu_Load;
            menu.ResumeLayout(false);
            addSale.ResumeLayout(false);
            addSale.PerformLayout();
            deleteSale.ResumeLayout(false);
            deleteSale.PerformLayout();
            searchSale.ResumeLayout(false);
            searchSale.PerformLayout();
            updateSale.ResumeLayout(false);
            updateSale.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)discountPriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)quantityToSaleInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl menu;
        private TabPage addSale;
        private TabPage deleteSale;
        private TabPage searchSale;
        private TabPage updateSale;
        private Button saveSale;
        private TextBox saleDiscount;
        private Label quantityInStock;
        private TextBox quantityInSaleInput;
        private Label productPrice;
        private Label nameProduct;
        private TextBox ProductIdInput;
        private CheckBox fevoriteCustomer;
        private DateTimePicker dateTimeBegin;
        private Label dateTimeEnd;
        private Label dateBeginSale;
        private DateTimePicker dateEndSale;
        private ListBox showSales;
        private Button delete;
        private TextBox inputSaleId;
        private Label productId;
        private ListBox showSaleBySearch;
        private Button search;
        private TextBox inputIdSale;
        private Label productName;
        private Button change;
        private TextBox inputSaleIdToChange;
        private Label saleIdChange;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button save;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private CheckBox saleForClubMembers;
        private NumericUpDown discountPriceInput;
        private NumericUpDown quantityToSaleInput;
        private TextBox inputNameProductToChange;
        private Label discountPrice;
        private Label quantityToSale;
        private Label productIdToChange;
    }
}