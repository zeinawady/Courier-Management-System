
namespace SWProject
{
    partial class Courier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.courierID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersTable
            // 
            this.ordersTable.AllowUserToAddRows = false;
            this.ordersTable.AllowUserToDeleteRows = false;
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.deliveryAddress,
            this.orderWeight,
            this.status});
            this.ordersTable.Location = new System.Drawing.Point(42, 126);
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.Size = new System.Drawing.Size(647, 202);
            this.ordersTable.TabIndex = 0;
            // 
            // courierID
            // 
            this.courierID.Location = new System.Drawing.Point(170, 30);
            this.courierID.Name = "courierID";
            this.courierID.Size = new System.Drawing.Size(157, 20);
            this.courierID.TabIndex = 1;
            this.courierID.TextChanged += new System.EventHandler(this.courierID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your ID";
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(519, 30);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(131, 30);
            this.viewBtn.TabIndex = 3;
            this.viewBtn.Text = "View Orders";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(522, 372);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(128, 42);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Save Changes";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // orderID
            // 
            this.orderID.HeaderText = "Order ID";
            this.orderID.Name = "orderID";
            // 
            // deliveryAddress
            // 
            this.deliveryAddress.HeaderText = "Delivery Address";
            this.deliveryAddress.Name = "deliveryAddress";
            // 
            // orderWeight
            // 
            this.orderWeight.HeaderText = "Order Weight";
            this.orderWeight.Name = "orderWeight";
            this.orderWeight.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Order Status";
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Courier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courierID);
            this.Controls.Add(this.ordersTable);
            this.Name = "Courier";
            this.Text = "Courier";
            this.Load += new System.EventHandler(this.Courier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersTable;
        private System.Windows.Forms.TextBox courierID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderWeight;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
    }
}