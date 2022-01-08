namespace Coaching_Management
{
    partial class home_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_page));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 73);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(766, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(234, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coaching Management System";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentRegistrationToolStripMenuItem,
            this.teacherRegistrationToolStripMenuItem,
            this.studentLoginToolStripMenuItem,
            this.teacherLoginToolStripMenuItem,
            this.feesToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 72);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(194, 510);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentRegistrationToolStripMenuItem
            // 
            this.studentRegistrationToolStripMenuItem.BackColor = System.Drawing.Color.Crimson;
            this.studentRegistrationToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRegistrationToolStripMenuItem.ForeColor = System.Drawing.Color.Cornsilk;
            this.studentRegistrationToolStripMenuItem.Name = "studentRegistrationToolStripMenuItem";
            this.studentRegistrationToolStripMenuItem.Size = new System.Drawing.Size(191, 32);
            this.studentRegistrationToolStripMenuItem.Text = "Student Registration";
            this.studentRegistrationToolStripMenuItem.Click += new System.EventHandler(this.StudentRegistrationToolStripMenuItem_Click);
            // 
            // teacherRegistrationToolStripMenuItem
            // 
            this.teacherRegistrationToolStripMenuItem.BackColor = System.Drawing.Color.Violet;
            this.teacherRegistrationToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherRegistrationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.teacherRegistrationToolStripMenuItem.Name = "teacherRegistrationToolStripMenuItem";
            this.teacherRegistrationToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.teacherRegistrationToolStripMenuItem.Text = "Teacher registration";
            this.teacherRegistrationToolStripMenuItem.Click += new System.EventHandler(this.TeacherRegistrationToolStripMenuItem_Click);
            // 
            // studentLoginToolStripMenuItem
            // 
            this.studentLoginToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.studentLoginToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLoginToolStripMenuItem.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.studentLoginToolStripMenuItem.Name = "studentLoginToolStripMenuItem";
            this.studentLoginToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.studentLoginToolStripMenuItem.Size = new System.Drawing.Size(138, 32);
            this.studentLoginToolStripMenuItem.Text = "Student Login";
            this.studentLoginToolStripMenuItem.Click += new System.EventHandler(this.StudentLoginToolStripMenuItem_Click);
            // 
            // teacherLoginToolStripMenuItem
            // 
            this.teacherLoginToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.teacherLoginToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLoginToolStripMenuItem.Name = "teacherLoginToolStripMenuItem";
            this.teacherLoginToolStripMenuItem.Size = new System.Drawing.Size(136, 32);
            this.teacherLoginToolStripMenuItem.Text = "Teacher Login";
            this.teacherLoginToolStripMenuItem.Click += new System.EventHandler(this.TeacherLoginToolStripMenuItem_Click);
            // 
            // feesToolStripMenuItem
            // 
            this.feesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.feesToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesToolStripMenuItem.Name = "feesToolStripMenuItem";
            this.feesToolStripMenuItem.Size = new System.Drawing.Size(95, 32);
            this.feesToolStripMenuItem.Text = "Payment";
            this.feesToolStripMenuItem.Click += new System.EventHandler(this.FeesToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(79, 32);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.AdminToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 32);
            this.toolStripMenuItem1.Text = "Link";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.BurlyWood;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(94, 32);
            this.toolStripMenuItem2.Text = "Dveloper";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 48);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(765, 24);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Location = new System.Drawing.Point(0, 24);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(765, 24);
            this.menuStrip3.TabIndex = 9;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // menuStrip4
            // 
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(765, 24);
            this.menuStrip4.TabIndex = 10;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 582);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.menuStrip4);
            this.Name = "home_page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.MenuStrip menuStrip4;
    }
}

