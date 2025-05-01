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
    public partial class Customer : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Customer()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand checkCmd = new OracleCommand();
            checkCmd.Connection = conn;
            checkCmd.CommandText = "select count(*) from Customers where userID = :id";
            checkCmd.CommandType = CommandType.Text;
            checkCmd.Parameters.Add("id", customerID.Text);

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count == 0)
            {
                customerID.Text = "";
                customerID.Focus();
                MessageBox.Show("INVALID ID!!\nPlease Enter a Valid ID.");
                return;
            }
            if (orders.SelectedItem == null)
            {
                MessageBox.Show("Please Select an Order from Your Orders List.");
                return;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from orders where orderID = :ordID";
            cmd.Parameters.Add("ordID", orders.SelectedItem);

            if (orderStatus.Text == "placed")
            {
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    orders.Items.RemoveAt(orders.SelectedIndex);
                    clearData();
                    MessageBox.Show("Your Order is Deleted Successfully!!");
                }
            }
            else
            {
                string statusVal = orderStatus.Text;
                orders_SelectedIndexChanged(sender, e);
                MessageBox.Show($"Failed to Delete!!\nYour order is already {statusVal}!!");
            }

        }

        private void clearData()
        {
            orderWeight.Text = "";
            deliveryAddress.Text = "";
            orderDate.Text = "";
            deliveredDate.Text = "";
            orderStatus.Text = "";
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            OracleCommand checkCmd = new OracleCommand();
            checkCmd.Connection = conn;
            checkCmd.CommandText = "select count(*) from Customers where userID = :id";
            checkCmd.CommandType = CommandType.Text;
            checkCmd.Parameters.Add("id", customerID.Text);

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count == 0)
            {
                clearData();
                orders.Items.Clear();
                orders.Text = "";
                customerID.Text = "";
                MessageBox.Show("INVALID ID!!\nPlease Enter a Valid ID.");
                return;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetOrders"; 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("customerID", customerID.Text);
            cmd.Parameters.Add("orders", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();

            clearData();
            orders.Items.Clear();
            //orders.Text = "";

            while (dr.Read())
            {
                orders.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from orders where orderID = :ordID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("ordID", orders.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                orderWeight.Text = dr["orderWeight"].ToString();
                deliveryAddress.Text = dr["deliveryAddress"].ToString();
                orderDate.Text = dr["orderDate"].ToString();
                string delDate = dr["deliveredDate"].ToString();
                if (delDate == "" || delDate == null)
                {
                   // MessageBox.Show("date = " + delDate);
                    //deliveredDate.Text = "Not Delivered";
                }
                else
                {
                    deliveredDate.Text = delDate;
                }
                orderStatus.Text = dr["status"].ToString();
            }
            else
            {
                MessageBox.Show("No orders found for you!!");
            }
            dr.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            OracleCommand checkCmd = new OracleCommand();
            checkCmd.Connection = conn;
            checkCmd.CommandText = "select count(*) from Customers where userID = :id";
            checkCmd.CommandType = CommandType.Text;
            checkCmd.Parameters.Add("id", customerID.Text);

            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count == 0)
            {
                customerID.Text = "";
                customerID.Focus();
                MessageBox.Show("INVALID ID!!\nPlease Enter a Valid ID.");
                return;
            }
            if (orders.SelectedItem == null)
            {
                MessageBox.Show("Please Select an Order from Your Orders List.");
                return;
            }

            OracleCommand cmd = new OracleCommand();
            int nextID;
            cmd.Connection = conn;
            cmd.CommandText = "GetMaxID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            try
            {
                nextID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString()) + 1;
            }
            catch
            {
                nextID = 1001;
            }

            //inserting the data
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = @"insert into orders 
                             values (:ordID, :custID, NULL, :weight, :address, 'placed', SYSDATE, Null
                              )";
            if (string.IsNullOrWhiteSpace(customerID.Text) ||
                string.IsNullOrWhiteSpace(orderWeight.Text) ||
                string.IsNullOrWhiteSpace(deliveryAddress.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            cmd2.Parameters.Add("ordID", nextID.ToString());
            cmd2.Parameters.Add("custID", customerID.Text);
            cmd2.Parameters.Add("weight", orderWeight.Text);
            cmd2.Parameters.Add("address", deliveryAddress.Text);
            //cmd2.Parameters.Add("date", DateTime.Now);

            int r = cmd2.ExecuteNonQuery();
            if(r != -1)
            {
                orders.Items.Add(nextID.ToString());
                orders.Text = nextID.ToString();
                orderDate.Text = DateTime.Now.ToString();
                deliveredDate.Text = "";
                orderStatus.Text = "placed";

                MessageBox.Show("Your Order is Placed Successfully!!");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            OracleCommand checkID = new OracleCommand();
            checkID.Connection = conn;
            checkID.CommandText = "select count(*) from Customers where userID = :id";
            checkID.CommandType = CommandType.Text;
            checkID.Parameters.Add("id", customerID.Text);

            int count = Convert.ToInt32(checkID.ExecuteScalar());

            if (count == 0)
            {
                customerID.Text = "";
                MessageBox.Show("INVALID ID!!\nPlease Enter a Valid ID.");
                customerID.Focus();
                return;
            }
            if (orders.SelectedItem == null)
            {
                MessageBox.Show("Please Select an Order from Your Orders List.");
                return;
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"update orders
                    set orderWeight = :weight, deliveryAddress = :address
                    where orderID= :ordID";
            cmd.Parameters.Add("weight", orderWeight.Text);
            cmd.Parameters.Add("address", deliveryAddress.Text);
            cmd.Parameters.Add("ordID", orders.SelectedItem.ToString());
            if(orderStatus.Text == "placed")
            {
                int r = cmd.ExecuteNonQuery();
                if(r != -1 )
                {
                    MessageBox.Show("Your Order is Edited Successfully!!");
                }
            }
            else
            {
                string statusVal = orderStatus.Text;
                orders_SelectedIndexChanged(sender, e);
                MessageBox.Show($"Failed to Edit!!\nYour order is already {statusVal}!!");
            }

        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void Customer_Shown(object sender, EventArgs e)
        {
            customerID.Focus();
        }

        private void customerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
