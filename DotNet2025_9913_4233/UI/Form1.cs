namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void products_Click(object sender, EventArgs e)
        {
            productsMenu p = new productsMenu();
            p.Show();

        }
        private void sales_Click(object sender, EventArgs e)
        {
            saleMenu sm = new saleMenu();
            sm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void costomers_Click(object sender, EventArgs e)
        {
            customerMenu cm = new customerMenu();
            cm.Show();

        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            club cb = new club();
            cb.Show();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}