namespace Hospital
{
    partial class AddEmployee
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.jop = new System.Windows.Forms.TextBox();
            this.clinicName = new System.Windows.Forms.TextBox();
            this.addEmp = new System.Windows.Forms.Button();
            this.sa = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.salary = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(55, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(55, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "jop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(55, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(55, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clinic Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.SystemColors.Window;
            this.name.Location = new System.Drawing.Point(326, 113);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(296, 41);
            this.name.TabIndex = 4;
            // 
            // jop
            // 
            this.jop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.jop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jop.ForeColor = System.Drawing.SystemColors.Window;
            this.jop.Location = new System.Drawing.Point(326, 192);
            this.jop.Name = "jop";
            this.jop.Size = new System.Drawing.Size(296, 41);
            this.jop.TabIndex = 5;
            // 
            // clinicName
            // 
            this.clinicName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.clinicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicName.ForeColor = System.Drawing.Color.White;
            this.clinicName.Location = new System.Drawing.Point(326, 414);
            this.clinicName.Name = "clinicName";
            this.clinicName.Size = new System.Drawing.Size(296, 41);
            this.clinicName.TabIndex = 7;
            this.clinicName.TextChanged += new System.EventHandler(this.clinicName_TextChanged);
            // 
            // addEmp
            // 
            this.addEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.addEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmp.Location = new System.Drawing.Point(252, 505);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(174, 51);
            this.addEmp.TabIndex = 8;
            this.addEmp.Text = "Add";
            this.addEmp.UseVisualStyleBackColor = false;
            this.addEmp.Click += new System.EventHandler(this.addEmp_Click);
            // 
            // sa
            // 
            this.sa.AutoSize = true;
            this.sa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sa.Location = new System.Drawing.Point(55, 338);
            this.sa.Name = "sa";
            this.sa.Size = new System.Drawing.Size(94, 36);
            this.sa.TabIndex = 9;
            this.sa.Text = "salary";
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(326, 279);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(296, 22);
            this.birthday.TabIndex = 10;
            // 
            // salary
            // 
            this.salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.ForeColor = System.Drawing.SystemColors.Window;
            this.salary.Location = new System.Drawing.Point(326, 333);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(296, 41);
            this.salary.TabIndex = 11;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(637, 24);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(126, 54);
            this.back.TabIndex = 12;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.back);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.sa);
            this.Controls.Add(this.addEmp);
            this.Controls.Add(this.clinicName);
            this.Controls.Add(this.jop);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox jop;
        private System.Windows.Forms.TextBox clinicName;
        private System.Windows.Forms.Button addEmp;
        private System.Windows.Forms.Label sa;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Button back;
    }
}