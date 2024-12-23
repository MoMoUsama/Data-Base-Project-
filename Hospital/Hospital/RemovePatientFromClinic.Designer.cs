namespace Hospital
{
    partial class RemovePatientFromClinic
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
            this.patientId = new System.Windows.Forms.TextBox();
            this.addToXRay = new System.Windows.Forms.Button();
            this.Parmacy = new System.Windows.Forms.CheckBox();
            this.xray = new System.Windows.Forms.CheckBox();
            this.test = new System.Windows.Forms.CheckBox();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Patient ID";
            // 
            // patientId
            // 
            this.patientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientId.Location = new System.Drawing.Point(278, 107);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(382, 41);
            this.patientId.TabIndex = 1;
            this.patientId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addToXRay
            // 
            this.addToXRay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.addToXRay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addToXRay.ForeColor = System.Drawing.Color.Transparent;
            this.addToXRay.Location = new System.Drawing.Point(243, 322);
            this.addToXRay.Name = "addToXRay";
            this.addToXRay.Size = new System.Drawing.Size(344, 87);
            this.addToXRay.TabIndex = 2;
            this.addToXRay.Text = "Add to x_Ray";
            this.addToXRay.UseVisualStyleBackColor = false;
            this.addToXRay.Click += new System.EventHandler(this.removepatient_Click);
            // 
            // Parmacy
            // 
            this.Parmacy.AutoSize = true;
            this.Parmacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parmacy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Parmacy.Location = new System.Drawing.Point(106, 239);
            this.Parmacy.Name = "Parmacy";
            this.Parmacy.Size = new System.Drawing.Size(166, 40);
            this.Parmacy.TabIndex = 3;
            this.Parmacy.Text = "pharmacy";
            this.Parmacy.UseVisualStyleBackColor = true;
            // 
            // xray
            // 
            this.xray.AutoSize = true;
            this.xray.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xray.Location = new System.Drawing.Point(346, 239);
            this.xray.Name = "xray";
            this.xray.Size = new System.Drawing.Size(122, 40);
            this.xray.TabIndex = 4;
            this.xray.Text = "x_Ray";
            this.xray.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test.Location = new System.Drawing.Point(610, 239);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(84, 40);
            this.test.TabIndex = 5;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(636, 34);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(135, 47);
            this.back.TabIndex = 6;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // RemovePatientFromClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.test);
            this.Controls.Add(this.xray);
            this.Controls.Add(this.Parmacy);
            this.Controls.Add(this.addToXRay);
            this.Controls.Add(this.patientId);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "RemovePatientFromClinic";
            this.Text = "RemovePatientFromClinic";
            this.Load += new System.EventHandler(this.RemovePatientFromClinic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientId;
        private System.Windows.Forms.Button addToXRay;
        private System.Windows.Forms.CheckBox Parmacy;
        private System.Windows.Forms.CheckBox xray;
        private System.Windows.Forms.CheckBox test;
        private System.Windows.Forms.Button back;
    }
}