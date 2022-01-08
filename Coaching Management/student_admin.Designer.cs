namespace Coaching_Management
{
    partial class student_admin
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
            this.button_back = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_del_admin = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(117, 525);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(76, 32);
            this.button_back.TabIndex = 7;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.Button_back_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_update.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.Black;
            this.button_update.Location = new System.Drawing.Point(217, 525);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(89, 32);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // button_del_admin
            // 
            this.button_del_admin.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_del_admin.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_del_admin.ForeColor = System.Drawing.Color.Black;
            this.button_del_admin.Location = new System.Drawing.Point(344, 525);
            this.button_del_admin.Name = "button_del_admin";
            this.button_del_admin.Size = new System.Drawing.Size(89, 32);
            this.button_del_admin.TabIndex = 6;
            this.button_del_admin.Text = "Delete";
            this.button_del_admin.UseVisualStyleBackColor = false;
            this.button_del_admin.Click += new System.EventHandler(this.Button_del_admin_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(117, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(538, 326);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(47, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 85);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(223, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students Details";
            // 
            // student_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 587);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_del_admin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "student_admin";
            this.Text = "student_admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_del_admin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}