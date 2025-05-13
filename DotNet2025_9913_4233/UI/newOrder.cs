using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class newOrder : Form
    {
        private static IBl bl = Factory.get();
        private Customer customer;
        private Order order;


        public newOrder(Customer customer, Order order)
        {
            this.customer = customer;
            this.order = order;

            InitializeComponent();
        }
        private void fullCart(List<ProductInOrder> productInOrders)
        {
            cart.Items.Clear();
            productInOrders.ForEach((po) =>
            {
                cart.Items.Add("שם מוצר:" + po.productName);
                cart.Items.Add("מחיר ליחידה:" + po.basePrice);
                cart.Items.Add("כמות:" + po.quantity);
                cart.Items.Add("בסהכ למוצר:" + po.finalPrice);
                cart.Items.Add("-----------");


            });
            cart.Items.Add("סהכ להזמנה זו " + order.FinalPrice);
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void selectFromList_Click(object sender, EventArgs e)
        {
            showProducts.Visible = true;
            MessageBox.Show("לבחירת מוצר יש ללחוץ על מזהה מוצר");
            productsMenu m = new productsMenu();
            m.fullList(bl.Product.ReadAll(), showProducts);


        }



        private void newOrder_Load(object sender, EventArgs e)
        {
            showProducts.Visible = false;

        }

        private void showProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showProducts.SelectedItem != null)
            {
                string selectedLine = showProducts.SelectedItem.ToString();

                // לדוגמה: אם זו השורה עם מזהה המוצר
                if (selectedLine.StartsWith("מזהה מוצר:"))
                {
                    string productId = selectedLine.Replace("מזהה מוצר:", "").Trim();
                    productIdInput.Text = productId;
                }

            }
        }

        private void addToOrder_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(productIdInput.Text, out int productId);

            if (!isNumber)
            {
                MessageBox.Show("אנא הכנס ערך מספר", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Product product = bl.Product.Read(productId);
                bl.Order.AddProductToOrder(order, productId, (int)countForOrder.Value);
                fullCart(order.ProductList);
            }
            catch (BlNotFoundId Exception)
            {
                MessageBox.Show("לא קיים מוצר עם קוד זה אנא נסה שנית", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (BlInvalidQuantityException ex)
            {
                MessageBox.Show("הכמות שהתקבלה אינה חוקית", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (BlOutOfStockException ex)
            {
                MessageBox.Show("אין מספיק מוצרים במלאי😒", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void countForOrder_ValueChanged(object sender, EventArgs e)
        {

        }

        private void finishOrder_Click(object sender, EventArgs e)
        {
            bl.Order.DoOrder(order);
            MessageBox.Show("תודה על קניתך לשליחת חשבונית ירוקה נא הכנס כתובת מייל");
           


        }
    }
}
