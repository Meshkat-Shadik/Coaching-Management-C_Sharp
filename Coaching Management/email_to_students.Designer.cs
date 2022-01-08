namespace Coaching_Management
{
    partial class email_to_students
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_subject = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_body = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.button_back);
            this.groupBox1.Controls.Add(this.textBox_subject);
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.textBox_body);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(153, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 446);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email";
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_back.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(353, 329);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(66, 36);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = false;
            // 
            // textBox_subject
            // 
            this.textBox_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_subject.Location = new System.Drawing.Point(83, 88);
            this.textBox_subject.Name = "textBox_subject";
            this.textBox_subject.Size = new System.Drawing.Size(343, 26);
            this.textBox_subject.TabIndex = 2;
            // 
            // button_send
            // 
            this.button_send.BackColor = System.Drawing.Color.Tomato;
            this.button_send.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.Location = new System.Drawing.Point(83, 329);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(82, 36);
            this.button_send.TabIndex = 3;
            this.button_send.Text = "send";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // textBox_body
            // 
            this.textBox_body.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_body.Location = new System.Drawing.Point(83, 168);
            this.textBox_body.Multiline = true;
            this.textBox_body.Name = "textBox_body";
            this.textBox_body.Size = new System.Drawing.Size(343, 135);
            this.textBox_body.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "subject :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Body :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(49, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 76);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(206, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email to Students";
            // 
            // email_to_students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "email_to_students";
            this.Text = "email_to_students";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_subject;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_body;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}