using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace SWProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show();
            this.Hide();
        }

        private void courierBtn_Click(object sender, EventArgs e)
        {
            Courier courierForm = new Courier();
            courierForm.Show();
            this.Hide();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            Customer customerForm = new Customer();
            customerForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportForm1 from1 = new reportForm1();
            from1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportForm2 from2 = new reportForm2();
            from2.Show();
            this.Hide();
        }
    }
}
