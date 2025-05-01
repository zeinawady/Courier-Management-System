
namespace SWProject
{
    partial class Customer
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
            this.orderWeight = new System.Windows.Forms.TextBox();
            this.deliveryAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.TextBox();
            this.deliveredDate = new System.Windows.Forms.TextBox();
            this.orderStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderWeight
            // 
            this.orderWeight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.orderWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderWeight.Location = new System.Drawing.Point(199, 12);
            this.orderWeight.Name = "orderWeight";
            this.orderWeight.Size = new System.Drawing.Size(142, 15);
            this.orderWeight.TabIndex = 0;
            this.orderWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderWeight.WordWrap = false;
            // 
            // deliveryAddress
            // 
            this.deliveryAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deliveryAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deliveryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryAddress.Location = new System.Drawing.Point(198, 14);
            this.deliveryAddress.Name = "deliveryAddress";
            this.deliveryAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deliveryAddress.Size = new System.Drawing.Size(142, 15);
            this.deliveryAddress.TabIndex = 1;
            this.deliveryAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deliveryAddress.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Weight";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delivery Address";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(184)))), ((int)(((byte)(129)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.MintCream;
            this.addBtn.Location = new System.Drawing.Point(46, 13);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(99, 32);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(4)))));
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.MintCream;
            this.editBtn.Location = new System.Drawing.Point(182, 13);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(87, 32);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(303, 13);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(87, 32);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // orders
            // 
            this.orders.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.orders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders.FormattingEnabled = true;
            this.orders.Location = new System.Drawing.Point(198, 13);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(146, 24);
            this.orders.Sorted = true;
            this.orders.TabIndex = 8;
            this.orders.SelectedIndexChanged += new System.EventHandler(this.orders_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Order ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderDate
            // 
            this.orderDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.orderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.orderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDate.Location = new System.Drawing.Point(179, 13);
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            this.orderDate.Size = new System.Drawing.Size(145, 22);
            this.orderDate.TabIndex = 10;
            // 
            // deliveredDate
            // 
            this.deliveredDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deliveredDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.deliveredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveredDate.Location = new System.Drawing.Point(177, 8);
            this.deliveredDate.Name = "deliveredDate";
            this.deliveredDate.ReadOnly = true;
            this.deliveredDate.Size = new System.Drawing.Size(145, 22);
            this.deliveredDate.TabIndex = 11;
            // 
            // orderStatus
            // 
            this.orderStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.orderStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.orderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatus.Location = new System.Drawing.Point(179, 11);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.ReadOnly = true;
            this.orderStatus.Size = new System.Drawing.Size(145, 22);
            this.orderStatus.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(9, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Order Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(9, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Order Status";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customerID
            // 
            this.customerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.Location = new System.Drawing.Point(230, 38);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(145, 22);
            this.customerID.TabIndex = 16;
            this.customerID.TextChanged += new System.EventHandler(this.customerID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label7.Location = new System.Drawing.Point(52, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Customer ID:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.showBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.ForeColor = System.Drawing.Color.White;
            this.showBtn.Location = new System.Drawing.Point(441, 34);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(106, 31);
            this.showBtn.TabIndex = 18;
            this.showBtn.Text = "Show Orders";
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.prevBtn.ForeColor = System.Drawing.Color.MintCream;
            this.prevBtn.Location = new System.Drawing.Point(10, 12);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(26, 24);
            this.prevBtn.TabIndex = 19;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label8.Location = new System.Drawing.Point(174, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(434, 38);
            this.label8.TabIndex = 20;
            this.label8.Text = "Welome our valued Customer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.prevBtn);
            this.panel1.Location = new System.Drawing.Point(10, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 77);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.customerID);
            this.panel2.Controls.Add(this.showBtn);
            this.panel2.Location = new System.Drawing.Point(62, 103);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 98);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.orders);
            this.panel3.Location = new System.Drawing.Point(30, 211);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 51);
            this.panel3.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.orderWeight);
            this.panel4.Location = new System.Drawing.Point(30, 266);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 44);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.deliveryAddress);
            this.panel5.Location = new System.Drawing.Point(30, 313);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 47);
            this.panel5.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.addBtn);
            this.panel6.Controls.Add(this.editBtn);
            this.panel6.Controls.Add(this.deleteBtn);
            this.panel6.Location = new System.Drawing.Point(184, 379);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(425, 54);
            this.panel6.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Location = new System.Drawing.Point(12, 12);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(768, 520);
            this.panel7.TabIndex = 26;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.orderStatus);
            this.panel10.Location = new System.Drawing.Point(395, 313);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(327, 47);
            this.panel10.TabIndex = 29;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.deliveredDate);
            this.panel9.Location = new System.Drawing.Point(395, 264);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(327, 37);
            this.panel9.TabIndex = 28;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.orderDate);
            this.panel8.Location = new System.Drawing.Point(395, 211);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(327, 42);
            this.panel8.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Delivered Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(782, 483);
            this.Controls.Add(this.panel7);
            this.Name = "Customer";
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_FormClosing);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.Shown += new System.EventHandler(this.Customer_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox orderWeight;
        private System.Windows.Forms.TextBox deliveryAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox orders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orderDate;
        private System.Windows.Forms.TextBox deliveredDate;
        private System.Windows.Forms.TextBox orderStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
    }
}