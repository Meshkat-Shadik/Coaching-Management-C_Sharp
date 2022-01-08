namespace Coaching_Management
{
    partial class student_registration
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
            this.button1_back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_session = new System.Windows.Forms.ComboBox();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_gurdian_contact_no = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.textBox_contact_no = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_name_of_institution = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_back
            // 
            this.button1_back.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_back.Location = new System.Drawing.Point(343, 616);
            this.button1_back.Name = "button1_back";
            this.button1_back.Size = new System.Drawing.Size(62, 28);
            this.button1_back.TabIndex = 7;
            this.button1_back.Text = "Back";
            this.button1_back.UseVisualStyleBackColor = false;
            this.button1_back.Click += new System.EventHandler(this.Button1_back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSalmon;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(80, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 71);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Registration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(125, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 532);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox_session);
            this.groupBox1.Controls.Add(this.comboBox_class);
            this.groupBox1.Controls.Add(this.submit);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_adress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Controls.Add(this.textBox_gurdian_contact_no);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.textBox_contact_no);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_name_of_institution);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(27, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 501);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // comboBox_session
            // 
            this.comboBox_session.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_session.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_session.FormattingEnabled = true;
            this.comboBox_session.Items.AddRange(new object[] {
            "January-june",
            "july-December"});
            this.comboBox_session.Location = new System.Drawing.Point(209, 119);
            this.comboBox_session.Name = "comboBox_session";
            this.comboBox_session.Size = new System.Drawing.Size(222, 28);
            this.comboBox_session.TabIndex = 36;
            // 
            // comboBox_class
            // 
            this.comboBox_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            "Class6",
            "Class7",
            "Class8",
            "Class9",
            "Class10",
            "Class11",
            "Class12"});
            this.comboBox_class.Location = new System.Drawing.Point(209, 79);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(223, 28);
            this.comboBox_class.TabIndex = 35;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.submit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(209, 463);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(80, 32);
            this.submit.TabIndex = 34;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(209, 36);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(224, 26);
            this.textBox_name.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Contact  No:";
            // 
            // textBox_adress
            // 
            this.textBox_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_adress.Location = new System.Drawing.Point(209, 255);
            this.textBox_adress.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_adress.Multiline = true;
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(224, 47);
            this.textBox_adress.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name of Institution:";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(209, 405);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(224, 26);
            this.textBox_password.TabIndex = 29;
            // 
            // textBox_gurdian_contact_no
            // 
            this.textBox_gurdian_contact_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_gurdian_contact_no.Location = new System.Drawing.Point(209, 365);
            this.textBox_gurdian_contact_no.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_gurdian_contact_no.Name = "textBox_gurdian_contact_no";
            this.textBox_gurdian_contact_no.Size = new System.Drawing.Size(224, 26);
            this.textBox_gurdian_contact_no.TabIndex = 29;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(128, 164);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(63, 21);
            this.email.TabIndex = 17;
            this.email.Text = "E-mail:";
            // 
            // textBox_contact_no
            // 
            this.textBox_contact_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contact_no.Location = new System.Drawing.Point(209, 322);
            this.textBox_contact_no.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_contact_no.Name = "textBox_contact_no";
            this.textBox_contact_no.Size = new System.Drawing.Size(224, 26);
            this.textBox_contact_no.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Address:";
            // 
            // textBox_name_of_institution
            // 
            this.textBox_name_of_institution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name_of_institution.Location = new System.Drawing.Point(209, 214);
            this.textBox_name_of_institution.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name_of_institution.Name = "textBox_name_of_institution";
            this.textBox_name_of_institution.Size = new System.Drawing.Size(224, 26);
            this.textBox_name_of_institution.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 366);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Guardian Contact No.";
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(209, 166);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(224, 26);
            this.textBox_email.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 409);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Course Session :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 20;
            this.label5.Text = "Class:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(130, 37);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 21);
            this.name.TabIndex = 20;
            this.name.Text = "Name:";
            // 
            // student_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 649);
            this.Controls.Add(this.button1_back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "student_registration";
            this.Text = "student_registration";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_session;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_gurdian_contact_no;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox textBox_contact_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_name_of_institution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label name;
    }
}