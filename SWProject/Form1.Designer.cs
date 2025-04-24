
namespace SWProject
{
    partial class Admin
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
            this.cmbCourierID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addCourierBtn = new System.Windows.Forms.Button();
            this.deleteCourierBtn = new System.Windows.Forms.Button();
            this.courierName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courierPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.assignedOrders = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.assignOrderBtn = new System.Windows.Forms.Button();
            this.emptyOrders = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCourierID
            // 
            this.cmbCourierID.FormattingEnabled = true;
            this.cmbCourierID.Location = new System.Drawing.Point(316, 66);
            this.cmbCourierID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCourierID.Name = "cmbCourierID";
            this.cmbCourierID.Size = new System.Drawing.Size(264, 24);
            this.cmbCourierID.TabIndex = 0;
            this.cmbCourierID.SelectedIndexChanged += new System.EventHandler(this.cmbCourierID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Courier ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addCourierBtn
            // 
            this.addCourierBtn.Location = new System.Drawing.Point(721, 153);
            this.addCourierBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCourierBtn.Name = "addCourierBtn";
            this.addCourierBtn.Size = new System.Drawing.Size(136, 52);
            this.addCourierBtn.TabIndex = 2;
            this.addCourierBtn.Text = "Add New Courier";
            this.addCourierBtn.UseVisualStyleBackColor = true;
            this.addCourierBtn.Click += new System.EventHandler(this.addCourierBtn_Click);
            // 
            // deleteCourierBtn
            // 
            this.deleteCourierBtn.Location = new System.Drawing.Point(721, 241);
            this.deleteCourierBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteCourierBtn.Name = "deleteCourierBtn";
            this.deleteCourierBtn.Size = new System.Drawing.Size(136, 53);
            this.deleteCourierBtn.TabIndex = 3;
            this.deleteCourierBtn.Text = "Delete Courier";
            this.deleteCourierBtn.UseVisualStyleBackColor = true;
            this.deleteCourierBtn.Click += new System.EventHandler(this.deleteCourierBtn_Click);
            // 
            // courierName
            // 
            this.courierName.Location = new System.Drawing.Point(316, 116);
            this.courierName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courierName.Name = "courierName";
            this.courierName.Size = new System.Drawing.Size(263, 22);
            this.courierName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Courier Name";
            // 
            // courierPhone
            // 
            this.courierPhone.Location = new System.Drawing.Point(317, 166);
            this.courierPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courierPhone.Name = "courierPhone";
            this.courierPhone.Size = new System.Drawing.Size(262, 22);
            this.courierPhone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Courier Phone Number";
            // 
            // assignedOrders
            // 
            this.assignedOrders.FormattingEnabled = true;
            this.assignedOrders.Location = new System.Drawing.Point(316, 217);
            this.assignedOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assignedOrders.Name = "assignedOrders";
            this.assignedOrders.Size = new System.Drawing.Size(263, 24);
            this.assignedOrders.TabIndex = 8;
            this.assignedOrders.SelectedIndexChanged += new System.EventHandler(this.assignedOrders_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Assigned Orders";
            // 
            // assignOrderBtn
            // 
            this.assignOrderBtn.Location = new System.Drawing.Point(721, 66);
            this.assignOrderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.assignOrderBtn.Name = "assignOrderBtn";
            this.assignOrderBtn.Size = new System.Drawing.Size(136, 52);
            this.assignOrderBtn.TabIndex = 10;
            this.assignOrderBtn.Text = "Assign Order";
            this.assignOrderBtn.UseVisualStyleBackColor = true;
            this.assignOrderBtn.Click += new System.EventHandler(this.assignOrderBtn_Click);
            // 
            // emptyOrders
            // 
            this.emptyOrders.FormattingEnabled = true;
            this.emptyOrders.Location = new System.Drawing.Point(317, 270);
            this.emptyOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emptyOrders.Name = "emptyOrders";
            this.emptyOrders.Size = new System.Drawing.Size(262, 24);
            this.emptyOrders.TabIndex = 11;
            this.emptyOrders.SelectedIndexChanged += new System.EventHandler(this.emptyOrders_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Non Assigned Orders";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emptyOrders);
            this.Controls.Add(this.assignOrderBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.assignedOrders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.courierPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.courierName);
            this.Controls.Add(this.deleteCourierBtn);
            this.Controls.Add(this.addCourierBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCourierID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCourierID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCourierBtn;
        private System.Windows.Forms.Button deleteCourierBtn;
        private System.Windows.Forms.TextBox courierName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox courierPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox assignedOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button assignOrderBtn;
        private System.Windows.Forms.ComboBox emptyOrders;
        private System.Windows.Forms.Label label5;
    }
}

