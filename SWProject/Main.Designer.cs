
namespace SWProject
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.adminBtn = new System.Windows.Forms.Button();
            this.courierBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal Black", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(64, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1442, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Courier Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.adminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminBtn.Font = new System.Drawing.Font("Tajawal ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.adminBtn.ForeColor = System.Drawing.Color.White;
            this.adminBtn.Location = new System.Drawing.Point(116, 65);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(370, 125);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // courierBtn
            // 
            this.courierBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.courierBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.courierBtn.Font = new System.Drawing.Font("Tajawal ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.courierBtn.ForeColor = System.Drawing.Color.White;
            this.courierBtn.Location = new System.Drawing.Point(564, 65);
            this.courierBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.courierBtn.Name = "courierBtn";
            this.courierBtn.Size = new System.Drawing.Size(370, 125);
            this.courierBtn.TabIndex = 2;
            this.courierBtn.Text = "Courier";
            this.courierBtn.UseVisualStyleBackColor = false;
            this.courierBtn.Click += new System.EventHandler(this.courierBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(89)))), ((int)(((byte)(5)))));
            this.customerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerBtn.Font = new System.Drawing.Font("Tajawal ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.customerBtn.ForeColor = System.Drawing.Color.White;
            this.customerBtn.Location = new System.Drawing.Point(1003, 65);
            this.customerBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(370, 125);
            this.customerBtn.TabIndex = 3;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(184)))), ((int)(((byte)(129)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(241, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(493, 94);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate Report 1\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(184)))), ((int)(((byte)(129)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Tajawal ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(787, 46);
            this.button2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(493, 96);
            this.button2.TabIndex = 5;
            this.button2.Text = "Generate Report 2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1649, 1144);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(45, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1574, 245);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customerBtn);
            this.panel3.Controls.Add(this.courierBtn);
            this.panel3.Controls.Add(this.adminBtn);
            this.panel3.Location = new System.Drawing.Point(58, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1544, 235);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(63, 677);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1538, 180);
            this.panel4.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1680, 1166);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button courierBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}