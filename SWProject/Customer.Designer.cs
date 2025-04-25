
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderWeight
            // 
            this.orderWeight.Location = new System.Drawing.Point(268, 124);
            this.orderWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderWeight.Name = "orderWeight";
            this.orderWeight.Size = new System.Drawing.Size(192, 22);
            this.orderWeight.TabIndex = 0;
            // 
            // deliveryAddress
            // 
            this.deliveryAddress.Location = new System.Drawing.Point(268, 182);
            this.deliveryAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deliveryAddress.Name = "deliveryAddress";
            this.deliveryAddress.Size = new System.Drawing.Size(192, 22);
            this.deliveryAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delivery Address";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(79, 400);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 28);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(363, 400);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(136, 28);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(629, 400);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(136, 28);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // orders
            // 
            this.orders.FormattingEnabled = true;
            this.orders.Location = new System.Drawing.Point(268, 78);
            this.orders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(192, 24);
            this.orders.TabIndex = 8;
            this.orders.SelectedIndexChanged += new System.EventHandler(this.orders_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Order ID";
            // 
            // orderDate
            // 
            this.orderDate.Location = new System.Drawing.Point(268, 228);
            this.orderDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            this.orderDate.Size = new System.Drawing.Size(192, 22);
            this.orderDate.TabIndex = 10;
            // 
            // deliveredDate
            // 
            this.deliveredDate.Location = new System.Drawing.Point(268, 276);
            this.deliveredDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deliveredDate.Name = "deliveredDate";
            this.deliveredDate.ReadOnly = true;
            this.deliveredDate.Size = new System.Drawing.Size(192, 22);
            this.deliveredDate.TabIndex = 11;
            // 
            // orderStatus
            // 
            this.orderStatus.Location = new System.Drawing.Point(268, 321);
            this.orderStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.ReadOnly = true;
            this.orderStatus.Size = new System.Drawing.Size(192, 22);
            this.orderStatus.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Order Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Delivered Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 321);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Order Status";
            // 
            // customerID
            // 
            this.customerID.Location = new System.Drawing.Point(268, 26);
            this.customerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(192, 22);
            this.customerID.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Customer ID";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(624, 30);
            this.showBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(141, 38);
            this.showBtn.TabIndex = 18;
            this.showBtn.Text = "Show Orders";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(12, 12);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(33, 30);
            this.prevBtn.TabIndex = 19;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 554);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderStatus);
            this.Controls.Add(this.deliveredDate);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deliveryAddress);
            this.Controls.Add(this.orderWeight);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Customer";
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_FormClosing);
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button prevBtn;
    }
}