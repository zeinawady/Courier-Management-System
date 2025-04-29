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
    public partial class Courier : Form
    {
        OracleDataAdapter adapter;
        DataSet ds;
        public Courier()
        {
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            string ordb = "User Id=scott;Password=tiger;Data Source=orcl";
            string cmd = @"select orderID, deliveryAddress, orderWeight, status
                           from orders
                           where courierID =:courierID and status != 'placed'";
            adapter = new OracleDataAdapter(cmd, ordb);
            string id = courierID.Text;
            if (!int.TryParse(id, out int courierId))
            {
                MessageBox.Show("Please enter a valid numeric Courier ID.");
                return;
            }

            adapter.SelectCommand.Parameters.Add("courierID", id);
            ds = new DataSet();

            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No orders found for you!!");
                ordersTable.DataSource = null;
                return;
            }

            ordersTable.AutoGenerateColumns = false;
            ordersTable.DataSource = ds.Tables[0];
            ordersTable.Columns["orderID"].DataPropertyName = "orderID";
            ordersTable.Columns["deliveryAddress"].DataPropertyName = "deliveryAddress";
            ordersTable.Columns["orderWeight"].DataPropertyName = "orderWeight";
            ordersTable.Columns["status"].DataPropertyName = "status";
        }

        private void courierID_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Status is Updated Successfully!!");
        }

        private void Courier_Load(object sender, EventArgs e)
        {
            status.Items.AddRange("ongoing", "shipped", "delivered", "cancelled");
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}