namespace Coaching_Management
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_email = new System.Windows.Forms.Button();
            this.button_teac_admin = new System.Windows.Forms.Button();
            this.button_logout_admin = new System.Windows.Forms.Button();
            this.button_fee_admin = new System.Windows.Forms.Button();
            this.button_stu_admin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.button_email);
            this.panel3.Controls.Add(this.button_teac_admin);
            this.panel3.Controls.Add(this.button_logout_admin);
            this.panel3.Controls.Add(this.button_fee_admin);
            this.panel3.Controls.Add(this.button_stu_admin);
            this.panel3.Location = new System.Drawing.Point(155, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 445);
            this.panel3.TabIndex = 3;
            // 
            // button_email
            // 
            this.button_email.BackColor = System.Drawing.Color.LightSlateGray;
            this.button_email.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_email.Image = ((System.Drawing.Image)(resources.GetObject("button_email.Image")));
            this.button_email.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_email.Location = new System.Drawing.Point(257, 194);
            this.button_email.Name = "button_email";
            this.button_email.Size = new System.Drawing.Size(118, 89);
            this.button_email.TabIndex = 1;
            this.button_email.Text = "Email";
            this.button_email.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_email.UseVisualStyleBackColor = false;
            this.button_email.Click += new System.EventHandler(this.Button_email_Click);
            // 
            // button_teac_admin
            // 
            this.button_teac_admin.BackColor = System.Drawing.Color.Orange;
            this.button_teac_admin.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_teac_admin.ForeColor = System.Drawing.Color.Crimson;
            this.button_teac_admin.Image = ((System.Drawing.Image)(resources.GetObject("button_teac_admin.Image")));
            this.button_teac_admin.Location = new System.Drawing.Point(257, 83);
            this.button_teac_admin.Name = "button_teac_admin";
            this.button_teac_admin.Size = new System.Drawing.Size(118, 85);
            this.button_teac_admin.TabIndex = 0;
            this.button_teac_admin.Text = "Teachers";
            this.button_teac_admin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_teac_admin.UseVisualStyleBackColor = false;
            this.button_teac_admin.Click += new System.EventHandler(this.Button_teac_admin_Click);
            // 
            // button_logout_admin
            // 
            this.button_logout_admin.BackColor = System.Drawing.Color.PaleGreen;
            this.button_logout_admin.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout_admin.Image = ((System.Drawing.Image)(resources.GetObject("button_logout_admin.Image")));
            this.button_logout_admin.Location = new System.Drawing.Point(62, 319);
            this.button_logout_admin.Name = "button_logout_admin";
            this.button_logout_admin.Size = new System.Drawing.Size(118, 85);
            this.button_logout_admin.TabIndex = 0;
            this.button_logout_admin.Text = "Logout";
            this.button_logout_admin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_logout_admin.UseVisualStyleBackColor = false;
            this.button_logout_admin.Click += new System.EventHandler(this.Button_logout_admin_Click);
            // 
            // button_fee_admin
            // 
            this.button_fee_admin.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_fee_admin.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fee_admin.ForeColor = System.Drawing.Color.Goldenrod;
            this.button_fee_admin.Image = ((System.Drawing.Image)(resources.GetObject("button_fee_admin.Image")));
            this.button_fee_admin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_fee_admin.Location = new System.Drawing.Point(62, 198);
            this.button_fee_admin.Name = "button_fee_admin";
            this.button_fee_admin.Size = new System.Drawing.Size(118, 85);
            this.button_fee_admin.TabIndex = 0;
            this.button_fee_admin.Text = "Fees";
            this.button_fee_admin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_fee_admin.UseVisualStyleBackColor = false;
            this.button_fee_admin.Click += new System.EventHandler(this.Button_fee_admin_Click);
            // 
            // button_stu_admin
            // 
            this.button_stu_admin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_stu_admin.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stu_admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_stu_admin.Image = ((System.Drawing.Image)(resources.GetObject("button_stu_admin.Image")));
            this.button_stu_admin.Location = new System.Drawing.Point(62, 83);
            this.button_stu_admin.Name = "button_stu_admin";
            this.button_stu_admin.Size = new System.Drawing.Size(118, 85);
            this.button_stu_admin.TabIndex = 0;
            this.button_stu_admin.Text = "Students";
            this.button_stu_admin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_stu_admin.UseVisualStyleBackColor = false;
            this.button_stu_admin.Click += new System.EventHandler(this.Button_stu_admin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(47, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 99);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(274, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Admin";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "admin";
            this.Text = "admin";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_email;
        private System.Windows.Forms.Button button_teac_admin;
        private System.Windows.Forms.Button button_logout_admin;
        private System.Windows.Forms.Button button_fee_admin;
        private System.Windows.Forms.Button button_stu_admin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}