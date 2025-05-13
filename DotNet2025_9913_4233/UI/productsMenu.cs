
using BlApi;
using BO;
using Dal;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class productsMenu : Form
    {
        private static IBl bl = Factory.get();
        private List<SaleInProduct> tempListOfSaleInProducts = new List<SaleInProduct>();
        public productsMenu()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Product> products = bl.Product.ReadAll();
            showProducts.DataSource = products;
        }
        public void fullList(List<Product> products, ListBox lb = null)
        {
            if (lb == null)
                lb = showProducts;
            lb.Items.Clear();
            products.ForEach((Product product) =>
            {
                lb.Items.Add("מזהה מוצר: " + product._id);
                lb.Items.Add("שם מוצר: " + product._nameProduct);
                lb.Items.Add("מחיר: " + product._price);
                lb.Items.Add("כמות במלאי: " + product._quantityInStock);
                lb.Items.Add("קטגוריה: " + product._category);
                lb.Items.Add("-------------");
            });
        }
        private void productsMenu_Load(object sender, EventArgs e)
        {
            fullList(bl.Product.ReadAll());
            showProductBySearch.Visible = false;
            inputNameProductToChange.Visible = false;
            productNameToChange.Visible = false;
            quantityInStockToChange.Visible = false;
            quantityToChange.Visible = false;
            comboBox1.Visible = false;
            categoryToChange.Visible = false;

            priceToChnage.Visible = false;
            save.Visible = false;
            priceToChange.Visible = false;

        }

        private void showProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void saveProduct_Click(object sender, EventArgs e)
        {
            BO.Product p = new BO.Product();

            bool isDoublePrice = double.TryParse(productPriceInput.Text, out double price);
            bool isNumberQuantity = int.TryParse(quantityInStockInput.Text, out int quantityInStock);

            if (!isDoublePrice || !isNumberQuantity)
            {
                MessageBox.Show("נא להזין מספר בלבד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            p._price = price;
            p._nameProduct = ProductNameInput.Text;
            p._quantityInStock = quantityInStock;
            p._category = (BO.CategoryName)category.SelectedIndex;
            bl.Product.Create(p);
            fullList(bl.Product.ReadAll());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void addSale_Click(object sender, EventArgs e)
        {
        }

        private void updateProduct_Click(object sender, EventArgs e)
        {
        }

        private void delete_Click(object sender, EventArgs e)
        {

            bool isNumber = int.TryParse(inputProductId.Text, out int result);
            if (!isNumber)
            {
                MessageBox.Show("נא להזין מספר תקין בלבד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                try
                {
                    bl.Product.Delete(result);
                    fullList(bl.Product.ReadAll());
                }
                catch (BO.BlNotFoundId Ex)
                {

                    MessageBox.Show("מוצר לא קיים , אנא הכנס מזהה מוצר תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


        }

        private void search_Click(object sender, EventArgs e)
        {

            string productName = inputNameProduct.Text;
            try
            {
                BO.Product? product = bl.Product.Read((p) => p._nameProduct == productName);
                showProductBySearch.Items.Clear();
                showProductBySearch.Items.Add("מזהה מוצר: " + product._id);
                showProductBySearch.Items.Add("שם מוצר: " + product._nameProduct);
                showProductBySearch.Items.Add("מחיר: " + product._price);
                showProductBySearch.Items.Add("כמות במלאי: " + product._quantityInStock);
                showProductBySearch.Items.Add("קטגוריה: " + product._category);
                //foreach (var sale in product._saleList)
                //{
                //    showProductBySearch.Items.Add("מזהה מבצע: " + sale.saleId);
                //    showProductBySearch.Items.Add("כמות במלאי: " + sale.quantityForSale);
                //    showProductBySearch.Items.Add("מחיר: " + sale.Price);
                //    showProductBySearch.Items.Add("המבצע לחברי מועדון: " + sale.isSaleForAllCustomers);
                //    showProductBySearch.Items.Add("  ---");
                //}
                showProductBySearch.Items.Add("-------------");

                showProductBySearch.Visible = true;
            }
            catch (BO.BlNotFoundId Ex)
            {
                MessageBox.Show("מוצר לא קיים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void inputNameProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputFilter_TextChanged(object sender, EventArgs e)
        {
            if (inputFilter.Text == "")
            {
                fullList(bl.Product.ReadAll());

            }

        }
        private void inputFilter_KeyDown(object sender, KeyEventArgs e)
        {
            List<Product> tempProducts = new List<Product>();

            if (e.KeyCode == Keys.Enter)
            {


                bool isNumber = int.TryParse(inputFilter.Text, out int priceOrQuantity);
                if (!isNumber)
                {
                    MessageBox.Show("יש להזין מספר בלבד", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (quantityCheckBox.Checked == false && priceFilter.Checked == false)
                {
                    MessageBox.Show("יש לבחור אופציה לסינון", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (quantityCheckBox.Checked == true && priceFilter.Checked == true)
                {
                    MessageBox.Show("יש לבחור אופציה אחת בלבד לסינון", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (quantityCheckBox.Checked == true)
                {
                    showProducts.Items.Clear();
                    bl.Product.ReadAll((p) => p._quantityInStock == priceOrQuantity).ForEach((Product product) =>
                    {
                        tempProducts.Add(product);
                    });

                }
                else
                {
                    showProducts.Items.Clear();
                    bl.Product.ReadAll((p) => p._price == priceOrQuantity).ForEach((Product product) =>
                    {
                        tempProducts.Add(product);
                    });

                }

                fullList(tempProducts);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void change_Click(object sender, EventArgs e)
        {
            try
            {
                Product? product = bl.Product.Read((p) => p._nameProduct == inputProductToChange.Text);
                showProductBySearch.Visible = true;
                inputNameProductToChange.Visible = true;
                productNameToChange.Visible = true;
                quantityInStockToChange.Visible = true;
                quantityToChange.Visible = true;
                comboBox1.Visible = true;
                categoryToChange.Visible = true;
                priceToChnage.Visible = true;
                save.Visible = true;
                priceToChange.Visible = true;
                quantityInStockToChange.Value = product._quantityInStock;
                comboBox1.SelectedIndex = (int)product._category;
                priceToChange.Value = (decimal)product._price;
                inputNameProductToChange.Text = product._nameProduct;


            }
            catch (BlNotFoundId ex)
            {
                MessageBox.Show("מוצר זה לא קיים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void save_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p._price = (Double)priceToChange.Value;
            p._nameProduct = inputNameProductToChange.Text;
            p._quantityInStock = (int)quantityInStockToChange.Value;
            p._category = (CategoryName)comboBox1.SelectedIndex;
            try
            {
                bl.Product.Update(p);
                fullList(bl.Product.ReadAll());

                showProductBySearch.Visible = false;
                inputNameProductToChange.Visible = false;
                productNameToChange.Visible = false;
                quantityInStockToChange.Visible = false;
                quantityToChange.Visible = false;
                comboBox1.Visible = false;
                categoryToChange.Visible = false;

                priceToChnage.Visible = false;
                save.Visible = false;
                priceToChange.Visible = false;


            }
            catch (BlNotFoundId ex)
            {
                MessageBox.Show("אין אפשרות לעדכן מוצר לא קיים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showSales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
