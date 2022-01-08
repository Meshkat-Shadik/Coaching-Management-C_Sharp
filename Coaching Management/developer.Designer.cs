namespace Coaching_Management
{
    partial class developer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Devoloper = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(68, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 98);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(254, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developer";
            // 
            // Devoloper
            // 
            this.Devoloper.AutoSize = true;
            this.Devoloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devoloper.Location = new System.Drawing.Point(169, 152);
            this.Devoloper.Name = "Devoloper";
            this.Devoloper.Size = new System.Drawing.Size(453, 25);
            this.Devoloper.TabIndex = 5;
            this.Devoloper.Text = "Mahmudul Hasan Sumon and Md.Forhad Hossain ";
            this.Devoloper.Click += new System.EventHandler(this.Devoloper_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id: 1502009 and 1602067";
            this.label2.Click += new System.EventHandler(this.Devoloper_Click);
            // 
            // developer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Devoloper);
            this.Controls.Add(this.panel1);
            this.Name = "developer";
            this.Text = "developer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Devoloper;
        private System.Windows.Forms.Label label2;
    }
}