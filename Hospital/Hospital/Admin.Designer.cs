namespace Hospital
{
    partial class Admin
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
            this.addEmployee = new System.Windows.Forms.Button();
            this.addDoctor = new System.Windows.Forms.Button();
            this.patientXRay = new System.Windows.Forms.Button();
            this.showPatient = new System.Windows.Forms.Button();
            this.removeEmployee = new System.Windows.Forms.Button();
            this.removeDoctor = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "What you want";
            // 
            // addEmployee
            // 
            this.addEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee.Location = new System.Drawing.Point(74, 131);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(268, 66);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.UseVisualStyleBackColor = false;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // addDoctor
            // 
            this.addDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.addDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDoctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addDoctor.Location = new System.Drawing.Point(74, 271);
            this.addDoctor.Name = "addDoctor";
            this.addDoctor.Size = new System.Drawing.Size(268, 70);
            this.addDoctor.TabIndex = 2;
            this.addDoctor.Text = "Add Doctor";
            this.addDoctor.UseVisualStyleBackColor = false;
            this.addDoctor.Click += new System.EventHandler(this.addDoctor_Click);
            // 
            // patientXRay
            // 
            this.patientXRay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.patientXRay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.patientXRay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientXRay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientXRay.Location = new System.Drawing.Point(190, 486);
            this.patientXRay.Name = "patientXRay";
            this.patientXRay.Size = new System.Drawing.Size(369, 86);
            this.patientXRay.TabIndex = 3;
            this.patientXRay.Text = "show all patient in x_Ray";
            this.patientXRay.UseVisualStyleBackColor = false;
            this.patientXRay.Click += new System.EventHandler(this.patientXRay_Click);
            // 
            // showPatient
            // 
            this.showPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.showPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showPatient.Location = new System.Drawing.Point(262, 393);
            this.showPatient.Name = "showPatient";
            this.showPatient.Size = new System.Drawing.Size(217, 64);
            this.showPatient.TabIndex = 4;
            this.showPatient.Text = "Show Patient";
            this.showPatient.UseVisualStyleBackColor = false;
            this.showPatient.Click += new System.EventHandler(this.showPatient_Click);
            // 
            // removeEmployee
            // 
            this.removeEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.removeEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeEmployee.Location = new System.Drawing.Point(420, 275);
            this.removeEmployee.Name = "removeEmployee";
            this.removeEmployee.Size = new System.Drawing.Size(317, 66);
            this.removeEmployee.TabIndex = 5;
            this.removeEmployee.Text = "Remove Employee";
            this.removeEmployee.UseVisualStyleBackColor = false;
            this.removeEmployee.Click += new System.EventHandler(this.removeEmployee_Click);
            // 
            // removeDoctor
            // 
            this.removeDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.removeDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDoctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeDoctor.Location = new System.Drawing.Point(430, 133);
            this.removeDoctor.Name = "removeDoctor";
            this.removeDoctor.Size = new System.Drawing.Size(307, 64);
            this.removeDoctor.TabIndex = 6;
            this.removeDoctor.Text = "Remove Doctor";
            this.removeDoctor.UseVisualStyleBackColor = false;
            this.removeDoctor.Click += new System.EventHandler(this.removeDoctor_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(656, 29);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(117, 43);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.removeDoctor);
            this.Controls.Add(this.removeEmployee);
            this.Controls.Add(this.showPatient);
            this.Controls.Add(this.patientXRay);
            this.Controls.Add(this.addDoctor);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Button addDoctor;
        private System.Windows.Forms.Button patientXRay;
        private System.Windows.Forms.Button showPatient;
        private System.Windows.Forms.Button removeEmployee;
        private System.Windows.Forms.Button removeDoctor;
        private System.Windows.Forms.Button Back;
    }
}