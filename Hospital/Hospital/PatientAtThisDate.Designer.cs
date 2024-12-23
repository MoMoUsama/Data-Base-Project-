namespace Hospital
{
    partial class PatientAtThisDate
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
            this.clinicName = new System.Windows.Forms.TextBox();
            this.patientInThisDate = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.orderpatient = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientInThisDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Clinic Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clinicName
            // 
            this.clinicName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.clinicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicName.Location = new System.Drawing.Point(310, 69);
            this.clinicName.Name = "clinicName";
            this.clinicName.Size = new System.Drawing.Size(457, 41);
            this.clinicName.TabIndex = 1;
            this.clinicName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // patientInThisDate
            // 
            this.patientInThisDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientInThisDate.Location = new System.Drawing.Point(36, 211);
            this.patientInThisDate.Name = "patientInThisDate";
            this.patientInThisDate.RowHeadersWidth = 51;
            this.patientInThisDate.RowTemplate.Height = 24;
            this.patientInThisDate.Size = new System.Drawing.Size(1057, 250);
            this.patientInThisDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(310, 145);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(457, 38);
            this.date.TabIndex = 4;
            // 
            // orderpatient
            // 
            this.orderpatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.orderpatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderpatient.Location = new System.Drawing.Point(458, 491);
            this.orderpatient.Name = "orderpatient";
            this.orderpatient.Size = new System.Drawing.Size(190, 62);
            this.orderpatient.TabIndex = 5;
            this.orderpatient.Text = "GO";
            this.orderpatient.UseVisualStyleBackColor = false;
            this.orderpatient.Click += new System.EventHandler(this.orderpatient_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(927, 30);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(152, 46);
            this.back.TabIndex = 6;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // PatientAtThisDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1129, 582);
            this.Controls.Add(this.back);
            this.Controls.Add(this.orderpatient);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientInThisDate);
            this.Controls.Add(this.clinicName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "PatientAtThisDate";
            this.Text = "PatientAtThisDate";
            ((System.ComponentModel.ISupportInitialize)(this.patientInThisDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clinicName;
        private System.Windows.Forms.DataGridView patientInThisDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button orderpatient;
        private System.Windows.Forms.Button back;
    }
}