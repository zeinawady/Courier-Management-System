
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
            this.orderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.courierID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
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
            this.ordersTable.Location = new System.Drawing.Point(56, 155);
            this.ordersTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.RowHeadersWidth = 51;
            this.ordersTable.Size = new System.Drawing.Size(863, 249);
            this.ordersTable.TabIndex = 0;
            // 
            // orderID
            // 
            this.orderID.HeaderText = "Order ID";
            this.orderID.MinimumWidth = 6;
            this.orderID.Name = "orderID";
            this.orderID.Width = 125;
            // 
            // deliveryAddress
            // 
            this.deliveryAddress.HeaderText = "Delivery Address";
            this.deliveryAddress.MinimumWidth = 6;
            this.deliveryAddress.Name = "deliveryAddress";
            this.deliveryAddress.Width = 125;
            // 
            // orderWeight
            // 
            this.orderWeight.HeaderText = "Order Weight";
            this.orderWeight.MinimumWidth = 6;
            this.orderWeight.Name = "orderWeight";
            this.orderWeight.ReadOnly = true;
            this.orderWeight.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Order Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.status.Width = 125;
            // 
            // courierID
            // 
            this.courierID.Location = new System.Drawing.Point(227, 37);
            this.courierID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courierID.Name = "courierID";
            this.courierID.Size = new System.Drawing.Size(208, 22);
            this.courierID.TabIndex = 1;
            this.courierID.TextChanged += new System.EventHandler(this.courierID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your ID";
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(692, 37);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(175, 37);
            this.viewBtn.TabIndex = 3;
            this.viewBtn.Text = "View Orders";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(696, 458);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(171, 52);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Save Changes";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(12, 12);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(33, 30);
            this.prevBtn.TabIndex = 14;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // Courier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 554);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courierID);
            this.Controls.Add(this.ordersTable);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button prevBtn;
    }
}