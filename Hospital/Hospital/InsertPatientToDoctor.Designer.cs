namespace Hospital
{
    partial class InsertPatientToDoctor
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
            this.patientID = new System.Windows.Forms.TextBox();
            this.doctorID = new System.Windows.Forms.TextBox();
            this.addPatientToDoctor = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "patient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor ID";
            // 
            // patientID
            // 
            this.patientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.patientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientID.Location = new System.Drawing.Point(279, 100);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(367, 41);
            this.patientID.TabIndex = 2;
            // 
            // doctorID
            // 
            this.doctorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.doctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doctorID.Location = new System.Drawing.Point(279, 237);
            this.doctorID.Name = "doctorID";
            this.doctorID.Size = new System.Drawing.Size(367, 41);
            this.doctorID.TabIndex = 3;
            // 
            // addPatientToDoctor
            // 
            this.addPatientToDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.addPatientToDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPatientToDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientToDoctor.Location = new System.Drawing.Point(220, 355);
            this.addPatientToDoctor.Name = "addPatientToDoctor";
            this.addPatientToDoctor.Size = new System.Drawing.Size(269, 57);
            this.addPatientToDoctor.TabIndex = 4;
            this.addPatientToDoctor.Text = "Add To Doctor";
            this.addPatientToDoctor.UseVisualStyleBackColor = false;
            this.addPatientToDoctor.Click += new System.EventHandler(this.addPatientToDoctor_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(629, 21);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(136, 54);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // InsertPatientToDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.addPatientToDoctor);
            this.Controls.Add(this.doctorID);
            this.Controls.Add(this.patientID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "InsertPatientToDoctor";
            this.Text = "InsertPatientToDoctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patientID;
        private System.Windows.Forms.TextBox doctorID;
        private System.Windows.Forms.Button addPatientToDoctor;
        private System.Windows.Forms.Button back;
    }
}