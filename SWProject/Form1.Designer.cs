
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
            this.prevBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCourierID
            // 
            this.cmbCourierID.Font = new System.Drawing.Font("Tajawal ExtraBold", 9.900001F, System.Drawing.FontStyle.Bold);
            this.cmbCourierID.FormattingEnabled = true;
            this.cmbCourierID.Location = new System.Drawing.Point(512, 33);
            this.cmbCourierID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbCourierID.Name = "cmbCourierID";
            this.cmbCourierID.Size = new System.Drawing.Size(501, 57);
            this.cmbCourierID.TabIndex = 0;
            this.cmbCourierID.SelectedIndexChanged += new System.EventHandler(this.cmbCourierID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Courier ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addCourierBtn
            // 
            this.addCourierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(184)))), ((int)(((byte)(129)))));
            this.addCourierBtn.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.addCourierBtn.ForeColor = System.Drawing.Color.White;
            this.addCourierBtn.Location = new System.Drawing.Point(27, 56);
            this.addCourierBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addCourierBtn.Name = "addCourierBtn";
            this.addCourierBtn.Size = new System.Drawing.Size(348, 100);
            this.addCourierBtn.TabIndex = 2;
            this.addCourierBtn.Text = "Add New Courier";
            this.addCourierBtn.UseVisualStyleBackColor = false;
            this.addCourierBtn.Click += new System.EventHandler(this.addCourierBtn_Click);
            // 
            // deleteCourierBtn
            // 
            this.deleteCourierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.deleteCourierBtn.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.deleteCourierBtn.ForeColor = System.Drawing.Color.White;
            this.deleteCourierBtn.Location = new System.Drawing.Point(27, 199);
            this.deleteCourierBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.deleteCourierBtn.Name = "deleteCourierBtn";
            this.deleteCourierBtn.Size = new System.Drawing.Size(348, 103);
            this.deleteCourierBtn.TabIndex = 3;
            this.deleteCourierBtn.Text = "Delete Courier";
            this.deleteCourierBtn.UseVisualStyleBackColor = false;
            this.deleteCourierBtn.Click += new System.EventHandler(this.deleteCourierBtn_Click);
            // 
            // courierName
            // 
            this.courierName.Font = new System.Drawing.Font("Tajawal ExtraBold", 9.900001F, System.Drawing.FontStyle.Bold);
            this.courierName.Location = new System.Drawing.Point(511, 11);
            this.courierName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.courierName.Name = "courierName";
            this.courierName.Size = new System.Drawing.Size(498, 56);
            this.courierName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(63, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 59);
            this.label2.TabIndex = 5;
            this.label2.Text = "Courier Name";
            // 
            // courierPhone
            // 
            this.courierPhone.Font = new System.Drawing.Font("Tajawal ExtraBold", 9.900001F, System.Drawing.FontStyle.Bold);
            this.courierPhone.Location = new System.Drawing.Point(514, 10);
            this.courierPhone.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.courierPhone.Name = "courierPhone";
            this.courierPhone.Size = new System.Drawing.Size(498, 56);
            this.courierPhone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(63, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 59);
            this.label3.TabIndex = 7;
            this.label3.Text = "Courier Phone Number";
            // 
            // assignedOrders
            // 
            this.assignedOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assignedOrders.Font = new System.Drawing.Font("Tajawal ExtraBold", 9.900001F, System.Drawing.FontStyle.Bold);
            this.assignedOrders.FormattingEnabled = true;
            this.assignedOrders.Location = new System.Drawing.Point(513, 13);
            this.assignedOrders.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.assignedOrders.Name = "assignedOrders";
            this.assignedOrders.Size = new System.Drawing.Size(498, 57);
            this.assignedOrders.Sorted = true;
            this.assignedOrders.TabIndex = 8;
            this.assignedOrders.SelectedIndexChanged += new System.EventHandler(this.assignedOrders_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(65, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 59);
            this.label4.TabIndex = 9;
            this.label4.Text = "Assigned Orders";
            // 
            // assignOrderBtn
            // 
            this.assignOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(168)))), ((int)(((byte)(4)))));
            this.assignOrderBtn.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.assignOrderBtn.ForeColor = System.Drawing.Color.White;
            this.assignOrderBtn.Location = new System.Drawing.Point(27, 349);
            this.assignOrderBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.assignOrderBtn.Name = "assignOrderBtn";
            this.assignOrderBtn.Size = new System.Drawing.Size(348, 100);
            this.assignOrderBtn.TabIndex = 10;
            this.assignOrderBtn.Text = "Assign Order";
            this.assignOrderBtn.UseVisualStyleBackColor = false;
            this.assignOrderBtn.Click += new System.EventHandler(this.assignOrderBtn_Click);
            // 
            // emptyOrders
            // 
            this.emptyOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emptyOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emptyOrders.Font = new System.Drawing.Font("Tajawal ExtraBold", 9.900001F, System.Drawing.FontStyle.Bold);
            this.emptyOrders.FormattingEnabled = true;
            this.emptyOrders.Location = new System.Drawing.Point(513, 16);
            this.emptyOrders.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.emptyOrders.Name = "emptyOrders";
            this.emptyOrders.Size = new System.Drawing.Size(498, 57);
            this.emptyOrders.Sorted = true;
            this.emptyOrders.TabIndex = 11;
            this.emptyOrders.SelectedIndexChanged += new System.EventHandler(this.emptyOrders_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label5.Location = new System.Drawing.Point(62, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 59);
            this.label5.TabIndex = 12;
            this.label5.Text = "Non Assigned Orders";
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.prevBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevBtn.ForeColor = System.Drawing.Color.White;
            this.prevBtn.Location = new System.Drawing.Point(28, 16);
            this.prevBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(67, 57);
            this.prevBtn.TabIndex = 13;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.prevBtn);
            this.panel1.Location = new System.Drawing.Point(28, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1949, 1058);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.assignOrderBtn);
            this.panel2.Controls.Add(this.deleteCourierBtn);
            this.panel2.Controls.Add(this.addCourierBtn);
            this.panel2.Location = new System.Drawing.Point(1401, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 491);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbCourierID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(210, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 103);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.courierName);
            this.panel4.Location = new System.Drawing.Point(208, 472);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1038, 90);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.courierPhone);
            this.panel5.Location = new System.Drawing.Point(208, 562);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1038, 92);
            this.panel5.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.assignedOrders);
            this.panel6.Location = new System.Drawing.Point(206, 666);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1039, 87);
            this.panel6.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.emptyOrders);
            this.panel7.Location = new System.Drawing.Point(209, 765);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1036, 88);
            this.panel7.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tajawal Black", 22F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(600, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(714, 109);
            this.label6.TabIndex = 20;
            this.label6.Text = "Welcome our Admin";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1992, 1073);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Admin";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

