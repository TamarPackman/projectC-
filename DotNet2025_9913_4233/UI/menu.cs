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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void cashier_Click(object sender, EventArgs e)
        {
            club cb = new club();
            cb.Show();
        }

        private void manager_Click(object sender, EventArgs e)
        {
            Form1 form= new Form1();
            form.Show();
        }
    }
}
