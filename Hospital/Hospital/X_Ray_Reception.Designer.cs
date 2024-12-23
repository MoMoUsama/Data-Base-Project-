namespace Hospital
{
    partial class X_Ray_Reception
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
            this.timeOfInsertion = new System.Windows.Forms.TextBox();
            this.patientINXray = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.patientID = new System.Windows.Forms.TextBox();
            this.showPatientInXRay = new System.Windows.Forms.Button();
            this.addToXRay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientINXray)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "time";
            // 
            // timeOfInsertion
            // 
            this.timeOfInsertion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.timeOfInsertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOfInsertion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.timeOfInsertion.Location = new System.Drawing.Point(303, 59);
            this.timeOfInsertion.Name = "timeOfInsertion";
            this.timeOfInsertion.Size = new System.Drawing.Size(204, 41);
            this.timeOfInsertion.TabIndex = 1;
            // 
            // patientINXray
            // 
            this.patientINXray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientINXray.Location = new System.Drawing.Point(12, 320);
            this.patientINXray.Name = "patientINXray";
            this.patientINXray.RowHeadersWidth = 51;
            this.patientINXray.RowTemplate.Height = 24;
            this.patientINXray.Size = new System.Drawing.Size(776, 189);
            this.patientINXray.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(57, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient ID";
            // 
            // patientID
            // 
            this.patientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.patientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientID.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.patientID.Location = new System.Drawing.Point(303, 136);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(204, 41);
            this.patientID.TabIndex = 4;
            // 
            // showPatientInXRay
            // 
            this.showPatientInXRay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.showPatientInXRay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showPatientInXRay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showPatientInXRay.Location = new System.Drawing.Point(60, 241);
            this.showPatientInXRay.Name = "showPatientInXRay";
            this.showPatientInXRay.Size = new System.Drawing.Size(200, 51);
            this.showPatientInXRay.TabIndex = 5;
            this.showPatientInXRay.Text = "Show Patient In x_ray";
            this.showPatientInXRay.UseVisualStyleBackColor = false;
            this.showPatientInXRay.Click += new System.EventHandler(this.showPatientInXRay_Click);
            // 
            // addToXRay
            // 
            this.addToXRay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.addToXRay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addToXRay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToXRay.Location = new System.Drawing.Point(303, 240);
            this.addToXRay.Name = "addToXRay";
            this.addToXRay.Size = new System.Drawing.Size(219, 52);
            this.addToXRay.TabIndex = 6;
            this.addToXRay.Text = "Add Patient To X_ray";
            this.addToXRay.UseVisualStyleBackColor = false;
            this.addToXRay.Click += new System.EventHandler(this.addToXRay_Click);
            // 
            // X_Ray_Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.addToXRay);
            this.Controls.Add(this.showPatientInXRay);
            this.Controls.Add(this.patientID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientINXray);
            this.Controls.Add(this.timeOfInsertion);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "X_Ray_Reception";
            this.Text = "X_Ray_Reception";
            this.Load += new System.EventHandler(this.X_Ray_Reception_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientINXray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeOfInsertion;
        private System.Windows.Forms.DataGridView patientINXray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patientID;
        private System.Windows.Forms.Button showPatientInXRay;
        private System.Windows.Forms.Button addToXRay;
    }
}