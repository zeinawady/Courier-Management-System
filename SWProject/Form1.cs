using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace SWProject
{
    public partial class Admin : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Admin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT userID FROM Couriers";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
          
                while (dr.Read())
                {
                     cmbCourierID.Items.Add(dr[0].ToString());
                }
                dr.Close();
      
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "SELECT orderID FROM Orders WHERE courierID IS NULL";
            cmd2.CommandType = CommandType.Text;

            OracleDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                emptyOrders.Items.Add(dr2[0].ToString());
            }
            dr2.Close();

        }

        private void cmbCourierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select fullname , phoneNumber from couriers where userID =:ID";
            cmd.Parameters.Add("id", cmbCourierID.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                courierName.Text = dr[0].ToString();
                courierPhone.Text = dr[1].ToString();
            }
            dr.Close();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select orderID from orders where courierID=:ID";
            cmd2.Parameters.Add("id", cmbCourierID.SelectedItem.ToString());
            OracleDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                assignedOrders.Items.Add(dr2[0]);
            }
            dr2.Close();



        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void addCourierBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmbCourierID.Text) || string.IsNullOrEmpty(courierName.Text) || string.IsNullOrEmpty(courierPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into couriers values(:courierId , :fullName , :phoneNumber)";

            cmd.Parameters.Add("courierId", cmbCourierID.Text);
            cmd.Parameters.Add("fullName", courierName.Text);
            cmd.Parameters.Add("phoneNumber", courierPhone.Text);

            string newId = cmbCourierID.Text;
            
            if (cmbCourierID.Items.Contains(newId))
            {
                MessageBox.Show("Enter Unique Id");
                cmbCourierID.Text = string.Empty;
                return;
            }
            try
            {
                int r = cmd.ExecuteNonQuery();

                if (r > 0)
                {
                    cmbCourierID.Items.Add(newId);
                    assignedOrders.Items.Clear();
                    MessageBox.Show("Courier is Added Successfully!!");
                }
                else
                {
                    MessageBox.Show("Failed to add courier.");
                }
            }
            catch
            {
                MessageBox.Show("Failed to add courier.");
            }

        }

        private void assignOrderBtn_Click(object sender, EventArgs e)
        {
            OracleCommand checkCmd = new OracleCommand();
            checkCmd.Connection = conn;
            checkCmd.CommandText = "select count(*) from Couriers where userID = :id";
            checkCmd.CommandType = CommandType.Text;
            checkCmd.Parameters.Add("id", cmbCourierID.SelectedItem.ToString());

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count == 0)
            {
                cmbCourierID.SelectedItem = -1;
                MessageBox.Show("INVALID ID!!\nPlease Enter a Valid ID.");
                return;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Orders set status='ongoing' ,courierID=:courierId where orderID=:orderId";
            cmd.Parameters.Add("courierId", cmbCourierID.SelectedItem.ToString());
            cmd.Parameters.Add("orderId", emptyOrders.SelectedItem.ToString());

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                assignedOrders.Items.Add(emptyOrders.SelectedItem.ToString());
                emptyOrders.Items.RemoveAt(emptyOrders.SelectedIndex);
                emptyOrders.Text = "";
                MessageBox.Show("Order is Assigned Successfully!!");
            }

        }

        private void assignedOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emptyOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteCourierBtn_Click(object sender, EventArgs e)
        {
            OracleCommand checkCmd = new OracleCommand();
            checkCmd.Connection = conn;
            checkCmd.CommandText = "select count(*) from Couriers where userID = :id";
            checkCmd.CommandType = CommandType.Text;
            try
            {
                checkCmd.Parameters.Add("id", cmbCourierID.Text);
            }
            catch
            {
                checkCmd.Parameters.Add("id", cmbCourierID.SelectedItem.ToString());
            }

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count == 0)
            {
                cmbCourierID.Text = "";

                MessageBox.Show("INVALID ID!!\nPlease Enter a Valid ID.");
                return;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from couriers where userID=:id";
            cmd.Parameters.Add("id", cmbCourierID.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                try
                {
                    cmbCourierID.Items.RemoveAt(cmbCourierID.SelectedIndex);
                    cmbCourierID.SelectedItem = -1;
                }
                catch
                {
                    int index = cmbCourierID.FindStringExact(cmbCourierID.Text);
                    cmbCourierID.Items.RemoveAt(cmbCourierID.SelectedIndex = index);
                }
                courierName.Text = "";
                courierPhone.Text = "";
                assignedOrders.Items.Clear();
                MessageBox.Show("Courier is Deleted Successfully!!");
            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void courierName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
