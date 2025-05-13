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
    public partial class club : Form
    {
        private static IBl bl = Factory.get();
        public club()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (fevoriteCustomer.Checked)
            {
                inputidCard.Visible = true;
                idCard.Visible = true;
                
            }
             }

        private void club_Load(object sender, EventArgs e)
        {
            inputidCard.Visible = false;
            idCard.Visible = false;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (!fevoriteCustomer.Checked)
            {
                this.Close();
                newOrder o = new newOrder(new BO.Customer(),new Order(false));
                o.Show();
            }
            else
            {
                bool isNum = int.TryParse(inputidCard.Text, out int num); try
                {
                    BO.Customer c = bl.Customer.Read(num);
                    MessageBox.Show(" שלום לקוח " + c._customerName);

                    this.Close();
                    newOrder o = new newOrder(c,new Order(true));
                    o.Show();

                }
                catch (BlNotFoundId ex)
                {
                    MessageBox.Show("מצטערים אבל מספר ת.ז. זה אינו מופיע במערכת אנא נסה שנית  או התחבר למועדון","שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.Close();
                    //newOrder o = new newOrder(new BO.Customer(), new Order(false));
                    //o.Show();
                }

            }
        }

         
              
            }
           
        }
    

