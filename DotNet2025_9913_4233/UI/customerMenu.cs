using BlApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class customerMenu : Form
    {
        private static IBl bl = Factory.get();
        public customerMenu()
        {
            InitializeComponent();
        }
        private void fullList(List<BO.Customer> sales)
        {
            showCustomers.Items.Clear();
            sales.ForEach((BO.Customer customer) =>
            {
                showCustomers.Items.Add(" שם: " + customer._customerName);
                showCustomers.Items.Add("תעודת זהות: " + customer._idCard);
                showCustomers.Items.Add("כתובת: " + customer._address);
                showCustomers.Items.Add("טלפון: " + customer._phone);
                showCustomers.Items.Add("-------------");
            });
        }
        private void customerMenu_Load(object sender, EventArgs e)
        {
            saveCustomer.Visible = false;
            adressCustomerInput.Visible = false;
            customerAdress.Visible = false;
            inputPhoneNumber.Visible = false;
            phoneNumberOfCustomer.Visible = false;
            customerd.Visible = false;
            inputCustomerIdToChange.Visible = false;
            showCustomerBySearch.Visible = false;
            fullList(bl.Customer.ReadAll());
        }

        private void save_Click(object sender, EventArgs e)
        {
            BO.Customer c = new BO.Customer();
            if (!int.TryParse(inputIdCard.Text, out int idCard))
            {
                MessageBox.Show("אנא הכנס רק מספרים בלבד בתעודת זהות", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            c._idCard = idCard;
            c._address = inputAdress.Text;
            c._customerName = inputName.Text;
            c._phone = productPriceInput.Text;

            try
            {
                bl.Customer.Create(c);

            }
            catch (BlIdExist Ex)
            {
                MessageBox.Show("לקוח זה קיים במערכת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fullList(bl.Customer.ReadAll());
        }

        private void delete_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(inputCustomerId.Text, out int result);
            if (!isNumber)
            {
                MessageBox.Show("נא להזין מספר תקין בלבד.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                try
                {
                    bl.Customer.Delete(result);
                    fullList(bl.Customer.ReadAll());
                }
                catch (BO.BlNotFoundId Ex)
                {

                    MessageBox.Show("לקוח עם מספר תעודת זהות זה לא קיים במערכת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            fullList(bl.Customer.ReadAll());
        }

        private void search_Click(object sender, EventArgs e)
        {

            string customerName = inputNameCustomer.Text;
            BO.Customer? customer = bl.Customer.Read((c) => c._customerName == customerName);

            if (customer == null)
                MessageBox.Show("לקוח לא קיים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                showCustomerBySearch.Items.Clear();
                showCustomerBySearch.Items.Add(" שם: " + customer._customerName);
                showCustomerBySearch.Items.Add("תעודת זהות: " + customer._idCard);
                showCustomerBySearch.Items.Add("כתובת: " + customer._address);
                showCustomerBySearch.Items.Add("טלפון: " + customer._phone);
                showCustomerBySearch.Items.Add("-------------");
                showCustomerBySearch.Visible = true;


            }
        }
        private void inputFilter_KeyDown(object sender, KeyEventArgs e)
        {
            List<BO.Customer> tempCustomers = new List<BO.Customer>();

            if (e.KeyCode == Keys.Enter)
            {
                showCustomers.Items.Clear();
                bl.Customer.ReadAll((c) => c._address.Contains(inputFilter.Text)).ForEach((BO.Customer customer) =>
                {
                    tempCustomers.Add(customer);
                });

                fullList(tempCustomers);
            }

        }

        private void inputFilter_TextChanged(object sender, EventArgs e)
        {
            if (inputFilter.Text == "")
            {
                fullList(bl.Customer.ReadAll());

            }

        }

        private void showProduct_Click(object sender, EventArgs e)
        {

        }

        private void change_Click(object sender, EventArgs e)
        {
            BO.Customer? customer = bl.Customer.Read((c) => c._customerName == inputCustomerToChange.Text);
            if (customer == null)
            {
                MessageBox.Show("לקוח לא קיים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveCustomer.Visible = true;
            adressCustomerInput.Visible = true;
            customerAdress.Visible = true;
            inputPhoneNumber.Visible = true;
            phoneNumberOfCustomer.Visible = true;
            customerd.Visible = true;
            inputCustomerIdToChange.Visible = true;
            adressCustomerInput.Text = customer._address;
            inputPhoneNumber.Text = customer._phone;
            inputCustomerIdToChange.Text = customer._idCard.ToString();


        }

        private void inputCustomerIdToChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveCustomer_Click(object sender, EventArgs e)
        {
            bool isNumber = int.TryParse(inputCustomerIdToChange.Text, out int customerId);

            if (!isNumber)
            {
                MessageBox.Show("תעודת זהות לא תקינה אנא הכנס מספרים בלבד", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bl.Customer.Update(new BO.Customer(customerId, inputPhoneNumber.Text, adressCustomerInput.Text, inputCustomerToChange.Text));
                MessageBox.Show("הלקוח התעדכן בהצלחה");

                fullList(bl.Customer.ReadAll());
            }
            catch (BlNotFoundId bl)
            {
                MessageBox.Show("לקוח זה לא קיים", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void showCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




