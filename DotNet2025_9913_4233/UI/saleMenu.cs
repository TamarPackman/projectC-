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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class saleMenu : Form
    {
        private static IBl bl = Factory.get();
        public saleMenu()
        {
            InitializeComponent();
        }
        public void fullList(List<BO.Sale> sales, ListBox lb = null)
        {
            if (lb == null)
            {
                lb = showSales;
            }
            lb.Items.Clear();
            sales.ForEach((BO.Sale sale) =>
            {
                lb.Items.Add("מזהה מבצע: " + sale.id);
                lb.Items.Add("מזהה מוצר: " + sale._productId);
                lb.Items.Add("כמות במבצע: " + sale._quantityForSale);
                lb.Items.Add("מחיר הנחה: " + sale._salePrice);
                lb.Items.Add("המבצע לחברי מועדון: " + sale._isForClubMembersOnly);
                lb.Items.Add("תאריך תחילת המבצע: " + sale._dateStartSale);
                lb.Items.Add("תאריך סיום המבצע: " + sale._dateEndSale);
                lb.Items.Add("-------------");
            });
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimeEnd_Click(object sender, EventArgs e)
        {

        }

        private void saveSale_Click(object sender, EventArgs e)
        {
            BO.Sale s = new BO.Sale();
            if (!int.TryParse(ProductIdInput.Text, out int productId) ||
    !int.TryParse(quantityInSaleInput.Text, out int quantity) ||
    !int.TryParse(saleDiscount.Text, out int salePrice))
            {
                MessageBox.Show("מזהה מוצר, כמות ומחיר חייבים להיות מספרים חוקיים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            s._productId = productId;
            s._quantityForSale = quantity;
            s._salePrice = salePrice;
            s._isForClubMembersOnly = fevoriteCustomer.Checked;
            if (!DateTime.TryParse(dateTimeBegin.Text, out DateTime startDate))
            {
                MessageBox.Show("תאריך התחלה אינו תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(dateEndSale.Text, out DateTime endDate))
            {
                MessageBox.Show("תאריך סיום אינו תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (startDate < DateTime.Today)
            {
                MessageBox.Show("תאריך התחלה לא יכול להיות בעבר", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (endDate < startDate)
            {
                MessageBox.Show("תאריך סיום לא יכול להיות לפני תאריך התחלה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            s._dateStartSale = startDate;
            s._dateEndSale = endDate;
            try
            {
                bl.Sale.Create(s);
                fullList(bl.Sale.ReadAll());

            }
            catch (BlProductIdDeasntExist Exception)
            {
                MessageBox.Show("אנא הכנס מזהה מוצר קיים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void saleMenu_Load(object sender, EventArgs e)
        {
            showSaleBySearch.Visible = false;
            panel1.Visible = false;
           fullList(bl.Sale.ReadAll());
        }

        private void delete_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(inputSaleId.Text, out int result);
            if (!isNumber)
            {
                MessageBox.Show("נא להזין מספר תקין בלבד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                try
                {
                    bl.Sale.Delete(result);
                    fullList(bl.Sale.ReadAll());
                }
                catch (BO.BlNotFoundId Ex)
                {

                    MessageBox.Show("מבצע  לא קיים , אנא הכנס מזהה מבצע תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        private void search_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(inputIdSale.Text, out int idSale);
            if (!isNumber)
            {
                MessageBox.Show("אנא הכנס מספר", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BO.Sale? sale = bl.Sale.Read((s) => s.id == idSale);

            if (sale == null)
                MessageBox.Show("מבצע לא קיים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                showSaleBySearch.Items.Add("מזהה מבצע: " + sale.id);
                showSaleBySearch.Items.Add("מזהה מוצר: " + sale._productId);
                showSaleBySearch.Items.Add("כמות במבצע: " + sale._quantityForSale);
                showSaleBySearch.Items.Add("המבצע לחברי מועדון: " + sale._isForClubMembersOnly);
                showSaleBySearch.Items.Add("תאריך תחילת המבצע: " + sale._dateStartSale);
                showSaleBySearch.Items.Add("תאריך סיום המבצע: " + sale._dateEndSale);
                showSaleBySearch.Items.Add("-------------");

                showSaleBySearch.Visible = true;

            }
        }

        private void showSales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void change_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(inputSaleIdToChange.Text, out int saleId);
            if (!isNumber)
            {
                MessageBox.Show("אנא הכנס מספר", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Sale? sale = bl.Sale.Read(saleId);
                panel1.Visible = true;
                inputNameProductToChange.Text = sale.id.ToString();
                quantityToSaleInput.Value = sale._quantityForSale;
                saleForClubMembers.Text = sale._isForClubMembersOnly.ToString();
                discountPriceInput.Value = (int)sale._salePrice;
                dateTimePicker2.Value = sale._dateStartSale;
                dateTimePicker1.Value = sale._dateEndSale;

            }
            catch (BlNotFoundId ex)
            {
                MessageBox.Show("מבצע  לא קיים , אנא הכנס מזהה מבצע תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            
            BO.Sale s = new BO.Sale();
            if (int.TryParse(inputNameProductToChange.Text, out int productId)==false||
                int.TryParse(inputSaleIdToChange.Text,out int id)==false)
            {
                MessageBox.Show("מזהה מבצע ומזהה מוצר חיבים להיות מספרים חוקיים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            s.id = id;
            s._productId = productId;
            s._quantityForSale = (int)quantityToSaleInput.Value;
            s._salePrice = (int)discountPriceInput.Value;
            s._isForClubMembersOnly = fevoriteCustomer.Checked;
            if (!DateTime.TryParse(dateTimeBegin.Text, out DateTime startDate))
            {
                MessageBox.Show("תאריך התחלה אינו תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(dateEndSale.Text, out DateTime endDate))
            {
                MessageBox.Show("תאריך סיום אינו תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (startDate < DateTime.Today)
            {
                MessageBox.Show("תאריך התחלה לא יכול להיות בעבר", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (endDate < startDate)
            {
                MessageBox.Show("תאריך סיום לא יכול להיות לפני תאריך התחלה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            s._dateStartSale = startDate;
            s._dateEndSale = endDate;
            try
            {
                bl.Sale.Update(s);
                fullList(bl.Sale.ReadAll());

            }
            catch (BlProductIdDeasntExist Exception)
            {
                MessageBox.Show("אנא הכנס מזהה מוצר קיים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (BlNotFoundId Exception)
            {
                MessageBox.Show("אנא הכנס מזהה מבצע קיים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
