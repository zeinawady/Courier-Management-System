
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.TextBox();
            this.deliveredDate = new System.Windows.Forms.TextBox();
            this.orderStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderWeight
            // 
            this.orderWeight.Location = new System.Drawing.Point(201, 50);
            this.orderWeight.Name = "orderWeight";
            this.orderWeight.Size = new System.Drawing.Size(145, 20);
            this.orderWeight.TabIndex = 0;
            // 
            // deliveryAddress
            // 
            this.deliveryAddress.Location = new System.Drawing.Point(201, 97);
            this.deliveryAddress.Name = "deliveryAddress";
            this.deliveryAddress.Size = new System.Drawing.Size(145, 20);
            this.deliveryAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Order Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Delivery Address";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(59, 294);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(102, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(272, 294);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(102, 23);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(472, 294);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(102, 23);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Order ID";
            // 
            // orderDate
            // 
            this.orderDate.Location = new System.Drawing.Point(201, 134);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(145, 20);
            this.orderDate.TabIndex = 10;
            // 
            // deliveredDate
            // 
            this.deliveredDate.Location = new System.Drawing.Point(201, 173);
            this.deliveredDate.Name = "deliveredDate";
            this.deliveredDate.Size = new System.Drawing.Size(145, 20);
            this.deliveredDate.TabIndex = 11;
            // 
            // orderStatus
            // 
            this.orderStatus.Location = new System.Drawing.Point(201, 210);
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Size = new System.Drawing.Size(145, 20);
            this.orderStatus.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Order Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Delivered Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Order Status";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderStatus);
            this.Controls.Add(this.deliveredDate);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deliveryAddress);
            this.Controls.Add(this.orderWeight);
            this.Name = "Customer";
            this.Text = "Customer";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox orderDate;
        private System.Windows.Forms.TextBox deliveredDate;
        private System.Windows.Forms.TextBox orderStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}