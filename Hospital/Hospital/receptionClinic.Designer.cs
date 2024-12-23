namespace Hospital
{
    partial class receptionClinic
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
            this.showClinicPatient = new System.Windows.Forms.Button();
            this.orderPatients = new System.Windows.Forms.Button();
            this.clinicRoom = new System.Windows.Forms.Button();
            this.hospitalRoom = new System.Windows.Forms.Button();
            this.showResult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clinicName = new System.Windows.Forms.TextBox();
            this.removeFromClinic = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showResult)).BeginInit();
            this.SuspendLayout();
            // 
            // showClinicPatient
            // 
            this.showClinicPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.showClinicPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showClinicPatient.Location = new System.Drawing.Point(12, 198);
            this.showClinicPatient.Name = "showClinicPatient";
            this.showClinicPatient.Size = new System.Drawing.Size(151, 86);
            this.showClinicPatient.TabIndex = 0;
            this.showClinicPatient.Text = "show clinin patient";
            this.showClinicPatient.UseVisualStyleBackColor = false;
            this.showClinicPatient.Click += new System.EventHandler(this.showClinicPatient_Click);
            // 
            // orderPatients
            // 
            this.orderPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.orderPatients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderPatients.Location = new System.Drawing.Point(182, 198);
            this.orderPatients.Name = "orderPatients";
            this.orderPatients.Size = new System.Drawing.Size(172, 86);
            this.orderPatients.TabIndex = 1;
            this.orderPatients.Text = "Order Patients";
            this.orderPatients.UseVisualStyleBackColor = false;
            this.orderPatients.Click += new System.EventHandler(this.orderPatients_Click);
            // 
            // clinicRoom
            // 
            this.clinicRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.clinicRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clinicRoom.Location = new System.Drawing.Point(370, 190);
            this.clinicRoom.Name = "clinicRoom";
            this.clinicRoom.Size = new System.Drawing.Size(181, 102);
            this.clinicRoom.TabIndex = 2;
            this.clinicRoom.Text = "Patient Without Doctor";
            this.clinicRoom.UseVisualStyleBackColor = false;
            this.clinicRoom.Click += new System.EventHandler(this.clinicRoom_Click);
            // 
            // hospitalRoom
            // 
            this.hospitalRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.hospitalRoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hospitalRoom.Location = new System.Drawing.Point(580, 192);
            this.hospitalRoom.Name = "hospitalRoom";
            this.hospitalRoom.Size = new System.Drawing.Size(198, 102);
            this.hospitalRoom.TabIndex = 3;
            this.hospitalRoom.Text = "Add Patient to room";
            this.hospitalRoom.UseVisualStyleBackColor = false;
            this.hospitalRoom.Click += new System.EventHandler(this.hospitalRoom_Click);
            // 
            // showResult
            // 
            this.showResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showResult.GridColor = System.Drawing.SystemColors.Desktop;
            this.showResult.Location = new System.Drawing.Point(12, 388);
            this.showResult.Name = "showResult";
            this.showResult.RowHeadersWidth = 51;
            this.showResult.RowTemplate.Height = 24;
            this.showResult.Size = new System.Drawing.Size(1080, 150);
            this.showResult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "clinic name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clinic Order is";
            // 
            // clinicName
            // 
            this.clinicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicName.Location = new System.Drawing.Point(326, 112);
            this.clinicName.Name = "clinicName";
            this.clinicName.Size = new System.Drawing.Size(390, 41);
            this.clinicName.TabIndex = 7;
            // 
            // removeFromClinic
            // 
            this.removeFromClinic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.removeFromClinic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeFromClinic.Location = new System.Drawing.Point(818, 198);
            this.removeFromClinic.Name = "removeFromClinic";
            this.removeFromClinic.Size = new System.Drawing.Size(208, 96);
            this.removeFromClinic.TabIndex = 12;
            this.removeFromClinic.Text = "remove patient from clinic";
            this.removeFromClinic.UseVisualStyleBackColor = false;
            this.removeFromClinic.Click += new System.EventHandler(this.removeFromClinic_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(900, 51);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(147, 48);
            this.back.TabIndex = 13;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // receptionClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1104, 550);
            this.Controls.Add(this.back);
            this.Controls.Add(this.removeFromClinic);
            this.Controls.Add(this.clinicName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showResult);
            this.Controls.Add(this.hospitalRoom);
            this.Controls.Add(this.clinicRoom);
            this.Controls.Add(this.orderPatients);
            this.Controls.Add(this.showClinicPatient);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "receptionClinic";
            this.Text = "receptionClinic";
            ((System.ComponentModel.ISupportInitialize)(this.showResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showClinicPatient;
        private System.Windows.Forms.Button orderPatients;
        private System.Windows.Forms.Button clinicRoom;
        private System.Windows.Forms.Button hospitalRoom;
        private System.Windows.Forms.DataGridView showResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeFromClinic;
        private System.Windows.Forms.TextBox clinicName;
        private System.Windows.Forms.Button back;
    }
}