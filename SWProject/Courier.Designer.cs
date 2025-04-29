
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersTable
            // 
            this.ordersTable.AllowUserToAddRows = false;
            this.ordersTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.ordersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ordersTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderID,
            this.deliveryAddress,
            this.orderWeight,
            this.status});
            this.ordersTable.Location = new System.Drawing.Point(53, 9);
            this.ordersTable.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.ordersTable.Name = "ordersTable";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tajawal", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ordersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ordersTable.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tajawal", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.ordersTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ordersTable.Size = new System.Drawing.Size(1726, 482);
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
            this.courierID.Font = new System.Drawing.Font("Tajawal ExtraBold", 9.900001F, System.Drawing.FontStyle.Bold);
            this.courierID.Location = new System.Drawing.Point(449, 19);
            this.courierID.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.courierID.Name = "courierID";
            this.courierID.Size = new System.Drawing.Size(357, 56);
            this.courierID.TabIndex = 1;
            this.courierID.TextChanged += new System.EventHandler(this.courierID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.viewBtn.Font = new System.Drawing.Font("Tajawal ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.Location = new System.Drawing.Point(935, 10);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(350, 72);
            this.viewBtn.TabIndex = 3;
            this.viewBtn.Text = "View Orders";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.updateBtn.Font = new System.Drawing.Font("Tajawal ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(1437, 506);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(342, 101);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Save Changes";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.prevBtn.ForeColor = System.Drawing.Color.White;
            this.prevBtn.Location = new System.Drawing.Point(3, 12);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(66, 58);
            this.prevBtn.TabIndex = 14;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.courierID);
            this.panel1.Controls.Add(this.viewBtn);
            this.panel1.Location = new System.Drawing.Point(105, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 100);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.prevBtn);
            this.panel2.Location = new System.Drawing.Point(47, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1816, 269);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ordersTable);
            this.panel3.Controls.Add(this.updateBtn);
            this.panel3.Location = new System.Drawing.Point(34, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1797, 615);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1863, 1056);
            this.panel4.TabIndex = 18;
            // 
            // Courier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1946, 1073);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Courier";
            this.Text = "Courier";
            this.Load += new System.EventHandler(this.Courier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}