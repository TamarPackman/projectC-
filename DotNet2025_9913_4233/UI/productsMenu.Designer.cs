namespace UI
{
    partial class productsMenu
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
            tabControl1 = new TabControl();
            addProduct = new TabPage();
            productPriceInput = new TextBox();
            saveProduct = new Button();
            quantityInStockInput = new TextBox();
            quantityInStock = new Label();
            productCategory = new Label();
            category = new ComboBox();
            productPrice = new Label();
            nameProduct = new Label();
            ProductNameInput = new TextBox();
            deleteProduct = new TabPage();
            delete = new Button();
            inputProductId = new TextBox();
            productId = new Label();
            updateProduct = new TabPage();
            save = new Button();
            quantityInStockToChange = new NumericUpDown();
            priceToChange = new NumericUpDown();
            inputNameProductToChange = new TextBox();
            categoryToChange = new Label();
            comboBox1 = new ComboBox();
            quantityToChange = new Label();
            priceToChnage = new Label();
            productNameToChange = new Label();
            change = new Button();
            inputProductToChange = new TextBox();
            productToChange = new Label();
            showProduct = new TabPage();
            showProductBySearch = new ListBox();
            search = new Button();
            inputNameProduct = new TextBox();
            productName = new Label();
            showProducts = new ListBox();
            sortBy = new Label();
            priceFilter = new CheckBox();
            inputFilter = new TextBox();
            quantityCheckBox = new CheckBox();
            tabControl1.SuspendLayout();
            addProduct.SuspendLayout();
            deleteProduct.SuspendLayout();
            updateProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityInStockToChange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceToChange).BeginInit();
            showProduct.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tabControl1.Controls.Add(addProduct);
            tabControl1.Controls.Add(deleteProduct);
            tabControl1.Controls.Add(updateProduct);
            tabControl1.Controls.Add(showProduct);
            tabControl1.Location = new Point(11, 53);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(470, 457);
            tabControl1.TabIndex = 1;
            // 
            // addProduct
            // 
            addProduct.Controls.Add(productPriceInput);
            addProduct.Controls.Add(saveProduct);
            addProduct.Controls.Add(quantityInStockInput);
            addProduct.Controls.Add(quantityInStock);
            addProduct.Controls.Add(productCategory);
            addProduct.Controls.Add(category);
            addProduct.Controls.Add(productPrice);
            addProduct.Controls.Add(nameProduct);
            addProduct.Controls.Add(ProductNameInput);
            addProduct.Location = new Point(4, 29);
            addProduct.Name = "addProduct";
            addProduct.Padding = new Padding(3);
            addProduct.Size = new Size(462, 424);
            addProduct.TabIndex = 0;
            addProduct.Text = "הוספה";
            addProduct.UseVisualStyleBackColor = true;
            // 
            // productPriceInput
            // 
            productPriceInput.Location = new Point(32, 31);
            productPriceInput.Margin = new Padding(3, 4, 3, 4);
            productPriceInput.Name = "productPriceInput";
            productPriceInput.Size = new Size(114, 27);
            productPriceInput.TabIndex = 10;
            // 
            // saveProduct
            // 
            saveProduct.Location = new Point(177, 185);
            saveProduct.Name = "saveProduct";
            saveProduct.Size = new Size(94, 29);
            saveProduct.TabIndex = 9;
            saveProduct.Text = "שמור מוצר";
            saveProduct.UseVisualStyleBackColor = true;
            saveProduct.Click += saveProduct_Click;
            // 
            // quantityInStockInput
            // 
            quantityInStockInput.Location = new Point(32, 85);
            quantityInStockInput.Name = "quantityInStockInput";
            quantityInStockInput.Size = new Size(77, 27);
            quantityInStockInput.TabIndex = 7;
            // 
            // quantityInStock
            // 
            quantityInStock.AutoSize = true;
            quantityInStock.Location = new Point(123, 89);
            quantityInStock.Name = "quantityInStock";
            quantityInStock.Size = new Size(87, 20);
            quantityInStock.TabIndex = 6;
            quantityInStock.Text = "כמות במלאי";
            // 
            // productCategory
            // 
            productCategory.AutoSize = true;
            productCategory.Location = new Point(378, 89);
            productCategory.Name = "productCategory";
            productCategory.Size = new Size(62, 20);
            productCategory.TabIndex = 5;
            productCategory.Text = "קטגוריה";
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "פרות", "ירקות", "דגים", "בשרי", "חלבי" });
            category.Location = new Point(217, 85);
            category.Name = "category";
            category.Size = new Size(151, 28);
            category.TabIndex = 4;
            // 
            // productPrice
            // 
            productPrice.AutoSize = true;
            productPrice.Location = new Point(163, 31);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(41, 20);
            productPrice.TabIndex = 2;
            productPrice.Text = "מחיר";
            // 
            // nameProduct
            // 
            nameProduct.AutoSize = true;
            nameProduct.Location = new Point(374, 31);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(66, 20);
            nameProduct.TabIndex = 1;
            nameProduct.Text = "שם מוצר";
            // 
            // ProductNameInput
            // 
            ProductNameInput.Location = new Point(243, 28);
            ProductNameInput.Name = "ProductNameInput";
            ProductNameInput.Size = new Size(125, 27);
            ProductNameInput.TabIndex = 0;
            // 
            // deleteProduct
            // 
            deleteProduct.Controls.Add(delete);
            deleteProduct.Controls.Add(inputProductId);
            deleteProduct.Controls.Add(productId);
            deleteProduct.Location = new Point(4, 29);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Padding = new Padding(3);
            deleteProduct.Size = new Size(462, 424);
            deleteProduct.TabIndex = 1;
            deleteProduct.Text = "מחיקה";
            deleteProduct.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(163, 128);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 16;
            delete.Text = "מחק";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // inputProductId
            // 
            inputProductId.Location = new Point(131, 39);
            inputProductId.Name = "inputProductId";
            inputProductId.Size = new Size(125, 27);
            inputProductId.TabIndex = 12;
            // 
            // productId
            // 
            productId.AutoSize = true;
            productId.Location = new Point(263, 41);
            productId.Name = "productId";
            productId.Size = new Size(135, 20);
            productId.TabIndex = 11;
            productId.Text = "מזהה מוצר למחיקה";
            // 
            // updateProduct
            // 
            updateProduct.Controls.Add(save);
            updateProduct.Controls.Add(quantityInStockToChange);
            updateProduct.Controls.Add(priceToChange);
            updateProduct.Controls.Add(inputNameProductToChange);
            updateProduct.Controls.Add(categoryToChange);
            updateProduct.Controls.Add(comboBox1);
            updateProduct.Controls.Add(quantityToChange);
            updateProduct.Controls.Add(priceToChnage);
            updateProduct.Controls.Add(productNameToChange);
            updateProduct.Controls.Add(change);
            updateProduct.Controls.Add(inputProductToChange);
            updateProduct.Controls.Add(productToChange);
            updateProduct.Location = new Point(4, 29);
            updateProduct.Name = "updateProduct";
            updateProduct.Padding = new Padding(3);
            updateProduct.Size = new Size(462, 424);
            updateProduct.TabIndex = 2;
            updateProduct.Text = "עדכון";
            updateProduct.UseVisualStyleBackColor = true;
            updateProduct.Click += updateProduct_Click;
            // 
            // save
            // 
            save.Location = new Point(193, 303);
            save.Margin = new Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new Size(86, 31);
            save.TabIndex = 13;
            save.Text = "שמור";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // quantityInStockToChange
            // 
            quantityInStockToChange.Location = new Point(17, 223);
            quantityInStockToChange.Margin = new Padding(3, 4, 3, 4);
            quantityInStockToChange.Name = "quantityInStockToChange";
            quantityInStockToChange.Size = new Size(123, 27);
            quantityInStockToChange.TabIndex = 12;
            // 
            // priceToChange
            // 
            priceToChange.Location = new Point(17, 159);
            priceToChange.Margin = new Padding(3, 4, 3, 4);
            priceToChange.Name = "priceToChange";
            priceToChange.Size = new Size(127, 27);
            priceToChange.TabIndex = 11;
            // 
            // inputNameProductToChange
            // 
            inputNameProductToChange.Location = new Point(225, 157);
            inputNameProductToChange.Margin = new Padding(3, 4, 3, 4);
            inputNameProductToChange.Name = "inputNameProductToChange";
            inputNameProductToChange.Size = new Size(114, 27);
            inputNameProductToChange.TabIndex = 9;
            // 
            // categoryToChange
            // 
            categoryToChange.AutoSize = true;
            categoryToChange.Location = new Point(347, 216);
            categoryToChange.Name = "categoryToChange";
            categoryToChange.Size = new Size(62, 20);
            categoryToChange.TabIndex = 8;
            categoryToChange.Text = "קטגוריה";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "פרות", "ירקות", "דגים", "בשרי", "חלבי", " " });
            comboBox1.Location = new Point(241, 212);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(97, 28);
            comboBox1.TabIndex = 7;
            // 
            // quantityToChange
            // 
            quantityToChange.AutoSize = true;
            quantityToChange.Location = new Point(147, 225);
            quantityToChange.Name = "quantityToChange";
            quantityToChange.Size = new Size(87, 20);
            quantityToChange.TabIndex = 5;
            quantityToChange.Text = "כמות במלאי";
            // 
            // priceToChnage
            // 
            priceToChnage.AutoSize = true;
            priceToChnage.Location = new Point(154, 164);
            priceToChnage.Name = "priceToChnage";
            priceToChnage.Size = new Size(41, 20);
            priceToChnage.TabIndex = 4;
            priceToChnage.Text = "מחיר";
            // 
            // productNameToChange
            // 
            productNameToChange.AutoSize = true;
            productNameToChange.Location = new Point(346, 160);
            productNameToChange.Name = "productNameToChange";
            productNameToChange.Size = new Size(66, 20);
            productNameToChange.TabIndex = 3;
            productNameToChange.Text = "שם מוצר";
            // 
            // change
            // 
            change.Location = new Point(193, 100);
            change.Margin = new Padding(3, 4, 3, 4);
            change.Name = "change";
            change.Size = new Size(86, 31);
            change.TabIndex = 2;
            change.Text = "שינוי";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
            // 
            // inputProductToChange
            // 
            inputProductToChange.Location = new Point(136, 40);
            inputProductToChange.Margin = new Padding(3, 4, 3, 4);
            inputProductToChange.Name = "inputProductToChange";
            inputProductToChange.Size = new Size(114, 27);
            inputProductToChange.TabIndex = 1;
            // 
            // productToChange
            // 
            productToChange.AutoSize = true;
            productToChange.Location = new Point(269, 44);
            productToChange.Name = "productToChange";
            productToChange.Size = new Size(120, 20);
            productToChange.TabIndex = 0;
            productToChange.Text = "הכנס מוצר לשינוי";
            productToChange.Click += label1_Click;
            // 
            // showProduct
            // 
            showProduct.Controls.Add(showProductBySearch);
            showProduct.Controls.Add(search);
            showProduct.Controls.Add(inputNameProduct);
            showProduct.Controls.Add(productName);
            showProduct.Location = new Point(4, 29);
            showProduct.Name = "showProduct";
            showProduct.Padding = new Padding(3);
            showProduct.Size = new Size(462, 424);
            showProduct.TabIndex = 3;
            showProduct.Text = "חיפוש";
            showProduct.UseVisualStyleBackColor = true;
            // 
            // showProductBySearch
            // 
            showProductBySearch.FormattingEnabled = true;
            showProductBySearch.ItemHeight = 20;
            showProductBySearch.Location = new Point(88, 148);
            showProductBySearch.Margin = new Padding(3, 4, 3, 4);
            showProductBySearch.Name = "showProductBySearch";
            showProductBySearch.Size = new Size(239, 124);
            showProductBySearch.TabIndex = 3;
            // 
            // search
            // 
            search.Location = new Point(7, 88);
            search.Margin = new Padding(3, 4, 3, 4);
            search.Name = "search";
            search.Size = new Size(86, 31);
            search.TabIndex = 2;
            search.Text = "חפש";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // inputNameProduct
            // 
            inputNameProduct.Location = new Point(122, 85);
            inputNameProduct.Margin = new Padding(3, 4, 3, 4);
            inputNameProduct.Name = "inputNameProduct";
            inputNameProduct.Size = new Size(114, 27);
            inputNameProduct.TabIndex = 1;
            inputNameProduct.TextChanged += inputNameProduct_TextChanged;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Location = new Point(254, 88);
            productName.Name = "productName";
            productName.Size = new Size(104, 20);
            productName.TabIndex = 0;
            productName.Text = "הכנס שם מוצר";
            // 
            // showProducts
            // 
            showProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showProducts.FormattingEnabled = true;
            showProducts.ItemHeight = 20;
            showProducts.Location = new Point(504, 145);
            showProducts.Name = "showProducts";
            showProducts.Size = new Size(501, 364);
            showProducts.TabIndex = 2;
            showProducts.SelectedIndexChanged += showProducts_SelectedIndexChanged;
            // 
            // sortBy
            // 
            sortBy.AutoSize = true;
            sortBy.Location = new Point(963, 33);
            sortBy.Name = "sortBy";
            sortBy.Size = new Size(57, 20);
            sortBy.TabIndex = 3;
            sortBy.Text = ":סנן לפי";
            // 
            // priceFilter
            // 
            priceFilter.AutoSize = true;
            priceFilter.Location = new Point(743, 33);
            priceFilter.Margin = new Padding(3, 4, 3, 4);
            priceFilter.Name = "priceFilter";
            priceFilter.Size = new Size(63, 24);
            priceFilter.TabIndex = 6;
            priceFilter.Text = "מחיר";
            priceFilter.UseVisualStyleBackColor = true;
            // 
            // inputFilter
            // 
            inputFilter.Location = new Point(895, 85);
            inputFilter.Margin = new Padding(3, 4, 3, 4);
            inputFilter.Name = "inputFilter";
            inputFilter.Size = new Size(114, 27);
            inputFilter.TabIndex = 7;
            inputFilter.TextChanged += inputFilter_TextChanged;
            inputFilter.KeyDown += inputFilter_KeyDown;
            // 
            // quantityCheckBox
            // 
            quantityCheckBox.AutoSize = true;
            quantityCheckBox.Location = new Point(855, 33);
            quantityCheckBox.Margin = new Padding(3, 4, 3, 4);
            quantityCheckBox.Name = "quantityCheckBox";
            quantityCheckBox.Size = new Size(109, 24);
            quantityCheckBox.TabIndex = 8;
            quantityCheckBox.Text = "כמות במלאי";
            quantityCheckBox.UseVisualStyleBackColor = true;
            // 
            // productsMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 585);
            Controls.Add(quantityCheckBox);
            Controls.Add(inputFilter);
            Controls.Add(priceFilter);
            Controls.Add(sortBy);
            Controls.Add(showProducts);
            Controls.Add(tabControl1);
            Name = "productsMenu";
            Text = "productsMenu";
            Load += productsMenu_Load;
            tabControl1.ResumeLayout(false);
            addProduct.ResumeLayout(false);
            addProduct.PerformLayout();
            deleteProduct.ResumeLayout(false);
            deleteProduct.PerformLayout();
            updateProduct.ResumeLayout(false);
            updateProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityInStockToChange).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceToChange).EndInit();
            showProduct.ResumeLayout(false);
            showProduct.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage addProduct;
        private TabPage deleteProduct;
        private TabPage showProduct;
        private Label nameProduct;
        private TextBox ProductNameInput;
        private Label productPrice;
        private Label productCategory;
        private ComboBox category;
        private Label quantityInStock;
        private TextBox quantityInStockInput;
        private Button saveProduct;
        private ListBox showProducts;
        private TabPage updateProduct;
        private Button delete;
        private TextBox inputProductId;
        private Label productId;
        private Label productName;
        private Button search;
        private TextBox inputNameProduct;
        private ListBox showProductBySearch;
        private TextBox productPriceInput;
        private Label sortBy;
        private CheckBox name;
        private CheckBox checkBox2;
        private CheckBox priceFilter;
        private TextBox inputFilter;
        private CheckBox quantityCheckBox;
        private Label productToChange;
        private TextBox inputProductToChange;
        private Button change;
        private Label quantityToChange;
        private Label priceToChnage;
        private Label productNameToChange;
        private TextBox inputNameProductToChange;
        private Label categoryToChange;
        private ComboBox comboBox1;
        private NumericUpDown priceToChange;
        private NumericUpDown quantityInStockToChange;
        private Button save;
    }
}
