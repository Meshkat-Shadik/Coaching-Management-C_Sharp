namespace Coaching_Management
{
    partial class Mail
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_email_teacher = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(771, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Email to students";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.CadetBlue;
            this.button_back.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(362, 480);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(101, 31);
            this.button_back.TabIndex = 7;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // button_email_teacher
            // 
            this.button_email_teacher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_email_teacher.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_email_teacher.Location = new System.Drawing.Point(11, 197);
            this.button_email_teacher.Name = "button_email_teacher";
            this.button_email_teacher.Size = new System.Drawing.Size(779, 48);
            this.button_email_teacher.TabIndex = 6;
            this.button_email_teacher.Text = "Email to Teachers";
            this.button_email_teacher.UseVisualStyleBackColor = false;
            this.button_email_teacher.Click += new System.EventHandler(this.Button_email_teacher_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 103);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_email_teacher);
            this.Controls.Add(this.panel1);
            this.Name = "Mail";
            this.Text = "Mail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_email_teacher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}