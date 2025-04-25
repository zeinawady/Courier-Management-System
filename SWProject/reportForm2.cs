using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace SWProject
{
    public partial class reportForm2 : Form
    {
        CrystalReport2 cr;
        public reportForm2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportForm2_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cr.SetParameterValue("startDate",Convert.ToDateTime(textBox1.Text));
            cr.SetParameterValue("endDate", Convert.ToDateTime(textBox2.Text));

            crystalReportViewer1.ReportSource = cr;
          


        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
