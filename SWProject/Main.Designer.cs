
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Courier Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(241, 129);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(113, 40);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // courierBtn
            // 
            this.courierBtn.Location = new System.Drawing.Point(241, 202);
            this.courierBtn.Name = "courierBtn";
            this.courierBtn.Size = new System.Drawing.Size(113, 40);
            this.courierBtn.TabIndex = 2;
            this.courierBtn.Text = "Courier";
            this.courierBtn.UseVisualStyleBackColor = true;
            this.courierBtn.Click += new System.EventHandler(this.courierBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.Location = new System.Drawing.Point(241, 270);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(113, 40);
            this.customerBtn.TabIndex = 3;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.courierBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.label1);
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
    }
}