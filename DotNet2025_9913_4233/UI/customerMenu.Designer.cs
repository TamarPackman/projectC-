namespace UI
{
    partial class customerMenu
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
            inputFilter = new TextBox();
            sortBy = new Label();
            showCustomers = new ListBox();
            tabControl1 = new TabControl();
            addProduct = new TabPage();
            adress = new Label();
            inputAdress = new TextBox();
            name = new Label();
            inputName = new TextBox();
            productPriceInput = new TextBox();
            save = new Button();
            phoneNumber = new Label();
            idCard = new Label();
            inputIdCard = new TextBox();
            deleteProduct = new TabPage();
            delete = new Button();
            inputCustomerId = new TextBox();
            customerId = new Label();
            updateProduct = new TabPage();
            adressCustomerInput = new TextBox();
            customerAdress = new Label();
            phoneNumberOfCustomer = new Label();
            label2 = new Label();
            label1 = new Label();
            inputPhoneNumber = new TextBox();
            customerd = new Label();
            saveCustomer = new Button();
            inputCustomerIdToChange = new TextBox();
            change = new Button();
            inputCustomerToChange = new TextBox();
            productToChange = new Label();
            showProduct = new TabPage();
            showCustomerBySearch = new ListBox();
            search = new Button();
            inputNameCustomer = new TextBox();
            productName = new Label();
            tabControl1.SuspendLayout();
            addProduct.SuspendLayout();
            deleteProduct.SuspendLayout();
            updateProduct.SuspendLayout();
            showProduct.SuspendLayout();
            SuspendLayout();
            // 
            // inputFilter
            // 
            inputFilter.Location = new Point(762, 37);
            inputFilter.Margin = new Padding(3, 4, 3, 4);
            inputFilter.Name = "inputFilter";
            inputFilter.Size = new Size(114, 27);
            inputFilter.TabIndex = 13;
            inputFilter.TextChanged += inputFilter_TextChanged;
            inputFilter.KeyDown += inputFilter_KeyDown;
            // 
            // sortBy
            // 
            sortBy.AutoSize = true;
            sortBy.Location = new Point(895, 41);
            sortBy.Name = "sortBy";
            sortBy.Size = new Size(93, 20);
            sortBy.TabIndex = 11;
            sortBy.Text = ":הכנס כתובת";
            // 
            // showCustomers
            // 
            showCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showCustomers.FormattingEnabled = true;
            showCustomers.ItemHeight = 20;
            showCustomers.Location = new Point(584, 131);
            showCustomers.Name = "showCustomers";
            showCustomers.Size = new Size(364, 364);
            showCustomers.TabIndex = 10;
            showCustomers.SelectedIndexChanged += showCustomers_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tabControl1.Controls.Add(addProduct);
            tabControl1.Controls.Add(deleteProduct);
            tabControl1.Controls.Add(updateProduct);
            tabControl1.Controls.Add(showProduct);
            tabControl1.Location = new Point(35, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(470, 457);
            tabControl1.TabIndex = 9;
            // 
            // addProduct
            // 
            addProduct.Controls.Add(adress);
            addProduct.Controls.Add(inputAdress);
            addProduct.Controls.Add(name);
            addProduct.Controls.Add(inputName);
            addProduct.Controls.Add(productPriceInput);
            addProduct.Controls.Add(save);
            addProduct.Controls.Add(phoneNumber);
            addProduct.Controls.Add(idCard);
            addProduct.Controls.Add(inputIdCard);
            addProduct.Location = new Point(4, 29);
            addProduct.Name = "addProduct";
            addProduct.Padding = new Padding(3, 3, 3, 3);
            addProduct.Size = new Size(462, 424);
            addProduct.TabIndex = 0;
            addProduct.Text = "הוספה";
            addProduct.UseVisualStyleBackColor = true;
            // 
            // adress
            // 
            adress.AutoSize = true;
            adress.Location = new Point(161, 43);
            adress.Name = "adress";
            adress.Size = new Size(52, 20);
            adress.TabIndex = 14;
            adress.Text = "כתובת";
            // 
            // inputAdress
            // 
            inputAdress.Location = new Point(27, 37);
            inputAdress.Name = "inputAdress";
            inputAdress.Size = new Size(125, 27);
            inputAdress.TabIndex = 13;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(373, 43);
            name.Name = "name";
            name.Size = new Size(31, 20);
            name.TabIndex = 12;
            name.Text = "שם";
            // 
            // inputName
            // 
            inputName.Location = new Point(239, 37);
            inputName.Name = "inputName";
            inputName.Size = new Size(125, 27);
            inputName.TabIndex = 11;
            // 
            // productPriceInput
            // 
            productPriceInput.Location = new Point(27, 115);
            productPriceInput.Margin = new Padding(3, 4, 3, 4);
            productPriceInput.Name = "productPriceInput";
            productPriceInput.Size = new Size(114, 27);
            productPriceInput.TabIndex = 10;
            // 
            // save
            // 
            save.Location = new Point(177, 185);
            save.Name = "save";
            save.Size = new Size(94, 29);
            save.TabIndex = 9;
            save.Text = "שמור ";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSize = true;
            phoneNumber.Location = new Point(162, 117);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(44, 20);
            phoneNumber.TabIndex = 2;
            phoneNumber.Text = "טלפון";
            // 
            // idCard
            // 
            idCard.AutoSize = true;
            idCard.Location = new Point(373, 117);
            idCard.Name = "idCard";
            idCard.Size = new Size(85, 20);
            idCard.TabIndex = 1;
            idCard.Text = "תעודת זהות";
            // 
            // inputIdCard
            // 
            inputIdCard.Location = new Point(239, 112);
            inputIdCard.Name = "inputIdCard";
            inputIdCard.Size = new Size(125, 27);
            inputIdCard.TabIndex = 0;
            // 
            // deleteProduct
            // 
            deleteProduct.Controls.Add(delete);
            deleteProduct.Controls.Add(inputCustomerId);
            deleteProduct.Controls.Add(customerId);
            deleteProduct.Location = new Point(4, 29);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Padding = new Padding(3, 3, 3, 3);
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
            // inputCustomerId
            // 
            inputCustomerId.Location = new Point(131, 39);
            inputCustomerId.Name = "inputCustomerId";
            inputCustomerId.Size = new Size(125, 27);
            inputCustomerId.TabIndex = 12;
            // 
            // customerId
            // 
            customerId.AutoSize = true;
            customerId.Location = new Point(266, 44);
            customerId.Name = "customerId";
            customerId.Size = new Size(123, 20);
            customerId.TabIndex = 11;
            customerId.Text = "הכנס תעודת זהות";
            // 
            // updateProduct
            // 
            updateProduct.Controls.Add(adressCustomerInput);
            updateProduct.Controls.Add(customerAdress);
            updateProduct.Controls.Add(phoneNumberOfCustomer);
            updateProduct.Controls.Add(label2);
            updateProduct.Controls.Add(label1);
            updateProduct.Controls.Add(inputPhoneNumber);
            updateProduct.Controls.Add(customerd);
            updateProduct.Controls.Add(saveCustomer);
            updateProduct.Controls.Add(inputCustomerIdToChange);
            updateProduct.Controls.Add(change);
            updateProduct.Controls.Add(inputCustomerToChange);
            updateProduct.Controls.Add(productToChange);
            updateProduct.Location = new Point(4, 29);
            updateProduct.Name = "updateProduct";
            updateProduct.Padding = new Padding(3, 3, 3, 3);
            updateProduct.Size = new Size(462, 424);
            updateProduct.TabIndex = 2;
            updateProduct.Text = "עדכון";
            updateProduct.UseVisualStyleBackColor = true;
            // 
            // adressCustomerInput
            // 
            adressCustomerInput.Location = new Point(152, 264);
            adressCustomerInput.Margin = new Padding(3, 4, 3, 4);
            adressCustomerInput.Name = "adressCustomerInput";
            adressCustomerInput.Size = new Size(114, 27);
            adressCustomerInput.TabIndex = 30;
            // 
            // customerAdress
            // 
            customerAdress.AutoSize = true;
            customerAdress.Location = new Point(275, 272);
            customerAdress.Name = "customerAdress";
            customerAdress.Size = new Size(52, 20);
            customerAdress.TabIndex = 29;
            customerAdress.Text = "כתובת";
            // 
            // phoneNumberOfCustomer
            // 
            phoneNumberOfCustomer.AutoSize = true;
            phoneNumberOfCustomer.Location = new Point(273, 229);
            phoneNumberOfCustomer.Name = "phoneNumberOfCustomer";
            phoneNumberOfCustomer.Size = new Size(85, 20);
            phoneNumberOfCustomer.TabIndex = 28;
            phoneNumberOfCustomer.Text = "מספר טלפון";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 227);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 229);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 26;
            // 
            // inputPhoneNumber
            // 
            inputPhoneNumber.Location = new Point(152, 223);
            inputPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            inputPhoneNumber.Name = "inputPhoneNumber";
            inputPhoneNumber.Size = new Size(114, 27);
            inputPhoneNumber.TabIndex = 25;
            // 
            // customerd
            // 
            customerd.AutoSize = true;
            customerd.Location = new Point(270, 188);
            customerd.Name = "customerd";
            customerd.Size = new Size(85, 20);
            customerd.TabIndex = 24;
            customerd.Text = "תעודת זהות";
            // 
            // saveCustomer
            // 
            saveCustomer.Location = new Point(170, 340);
            saveCustomer.Margin = new Padding(3, 4, 3, 4);
            saveCustomer.Name = "saveCustomer";
            saveCustomer.Size = new Size(86, 31);
            saveCustomer.TabIndex = 23;
            saveCustomer.Text = "שמור";
            saveCustomer.UseVisualStyleBackColor = true;
            saveCustomer.Click += saveCustomer_Click;
            // 
            // inputCustomerIdToChange
            // 
            inputCustomerIdToChange.Location = new Point(152, 184);
            inputCustomerIdToChange.Margin = new Padding(3, 4, 3, 4);
            inputCustomerIdToChange.Name = "inputCustomerIdToChange";
            inputCustomerIdToChange.Size = new Size(114, 27);
            inputCustomerIdToChange.TabIndex = 20;
            inputCustomerIdToChange.TextChanged += inputCustomerIdToChange_TextChanged;
            // 
            // change
            // 
            change.Location = new Point(181, 123);
            change.Margin = new Padding(3, 4, 3, 4);
            change.Name = "change";
            change.Size = new Size(86, 31);
            change.TabIndex = 16;
            change.Text = "שינוי";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
            // 
            // inputCustomerToChange
            // 
            inputCustomerToChange.Location = new Point(152, 63);
            inputCustomerToChange.Margin = new Padding(3, 4, 3, 4);
            inputCustomerToChange.Name = "inputCustomerToChange";
            inputCustomerToChange.Size = new Size(114, 27);
            inputCustomerToChange.TabIndex = 15;
            // 
            // productToChange
            // 
            productToChange.AutoSize = true;
            productToChange.Location = new Point(275, 67);
            productToChange.Name = "productToChange";
            productToChange.Size = new Size(147, 20);
            productToChange.TabIndex = 14;
            productToChange.Text = "הכנס שם לקוח לשינוי";
            // 
            // showProduct
            // 
            showProduct.Controls.Add(showCustomerBySearch);
            showProduct.Controls.Add(search);
            showProduct.Controls.Add(inputNameCustomer);
            showProduct.Controls.Add(productName);
            showProduct.Location = new Point(4, 29);
            showProduct.Name = "showProduct";
            showProduct.Padding = new Padding(3, 3, 3, 3);
            showProduct.Size = new Size(462, 424);
            showProduct.TabIndex = 3;
            showProduct.Text = "חיפוש";
            showProduct.UseVisualStyleBackColor = true;
            showProduct.Click += showProduct_Click;
            // 
            // showCustomerBySearch
            // 
            showCustomerBySearch.FormattingEnabled = true;
            showCustomerBySearch.ItemHeight = 20;
            showCustomerBySearch.Location = new Point(88, 148);
            showCustomerBySearch.Margin = new Padding(3, 4, 3, 4);
            showCustomerBySearch.Name = "showCustomerBySearch";
            showCustomerBySearch.Size = new Size(239, 124);
            showCustomerBySearch.TabIndex = 3;
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
            // inputNameCustomer
            // 
            inputNameCustomer.Location = new Point(122, 85);
            inputNameCustomer.Margin = new Padding(3, 4, 3, 4);
            inputNameCustomer.Name = "inputNameCustomer";
            inputNameCustomer.Size = new Size(114, 27);
            inputNameCustomer.TabIndex = 1;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Location = new Point(257, 91);
            productName.Name = "productName";
            productName.Size = new Size(105, 20);
            productName.TabIndex = 0;
            productName.Text = "הכנס שם לקוח";
            // 
            // customerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 600);
            Controls.Add(inputFilter);
            Controls.Add(sortBy);
            Controls.Add(showCustomers);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "customerMenu";
            Text = "customerMenucs";
            Load += customerMenu_Load;
            tabControl1.ResumeLayout(false);
            addProduct.ResumeLayout(false);
            addProduct.PerformLayout();
            deleteProduct.ResumeLayout(false);
            deleteProduct.PerformLayout();
            updateProduct.ResumeLayout(false);
            updateProduct.PerformLayout();
            showProduct.ResumeLayout(false);
            showProduct.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputFilter;
        private Label sortBy;
        private ListBox showCustomers;
        private TabControl tabControl1;
        private TabPage addProduct;
        private TextBox productPriceInput;
        private Button save;
        private Label phoneNumber;
        private Label idCard;
        private TextBox inputIdCard;
        private TabPage deleteProduct;
        private Button delete;
        private TextBox inputCustomerId;
        private Label customerId;
        private TabPage updateProduct;
        private TabPage showProduct;
        private ListBox showCustomerBySearch;
        private Button search;
        private TextBox inputNameCustomer;
        private Label productName;
        private Label name;
        private TextBox inputName;
        private Label adress;
        private TextBox inputAdress;
        private Button saveCustomer;
        private TextBox inputCustomerIdToChange;
        private Button change;
        private TextBox inputCustomerToChange;
        private Label productToChange;
        private Label customerd;
        private TextBox inputPhoneNumber;
        private Label label1;
        private Label label2;
        private Label phoneNumberOfCustomer;
        private Label customerAdress;
        private TextBox adressCustomerInput;
    }
}