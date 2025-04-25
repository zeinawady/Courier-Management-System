
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Courier Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(321, 159);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(151, 49);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // courierBtn
            // 
            this.courierBtn.Location = new System.Drawing.Point(321, 249);
            this.courierBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courierBtn.Name = "courierBtn";
            this.courierBtn.Size = new System.Drawing.Size(151, 49);
            this.courierBtn.TabIndex = 2;
            this.courierBtn.Text = "Courier";
            this.courierBtn.UseVisualStyleBackColor = true;
            this.courierBtn.Click += new System.EventHandler(this.courierBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.Location = new System.Drawing.Point(321, 332);
            this.customerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(151, 49);
            this.customerBtn.TabIndex = 3;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate Report 1\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 492);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Generate Report 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 602);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.courierBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button courierBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}