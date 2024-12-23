namespace Hospital
{
    partial class Show_xReay_Patient
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
            this.search = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.patientID = new System.Windows.Forms.TextBox();
            this.x_RayPatient = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.x_RayPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(94, 131);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(169, 49);
            this.search.TabIndex = 0;
            this.search.Text = "serach";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // showAll
            // 
            this.showAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.showAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showAll.Location = new System.Drawing.Point(471, 131);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(156, 49);
            this.showAll.TabIndex = 1;
            this.showAll.Text = "Show All";
            this.showAll.UseVisualStyleBackColor = false;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Patient ID";
            // 
            // patientID
            // 
            this.patientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.patientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientID.ForeColor = System.Drawing.Color.White;
            this.patientID.Location = new System.Drawing.Point(319, 57);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(308, 41);
            this.patientID.TabIndex = 3;
            // 
            // x_RayPatient
            // 
            this.x_RayPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.x_RayPatient.Location = new System.Drawing.Point(3, 205);
            this.x_RayPatient.Name = "x_RayPatient";
            this.x_RayPatient.RowHeadersWidth = 51;
            this.x_RayPatient.RowTemplate.Height = 24;
            this.x_RayPatient.Size = new System.Drawing.Size(1112, 233);
            this.x_RayPatient.TabIndex = 4;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(940, 35);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(128, 48);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Show_xReay_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.x_RayPatient);
            this.Controls.Add(this.patientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.search);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Show_xReay_Patient";
            this.Text = "Show_xReay_Patient";
            ((System.ComponentModel.ISupportInitialize)(this.x_RayPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientID;
        private System.Windows.Forms.DataGridView x_RayPatient;
        private System.Windows.Forms.Button back;
    }
}