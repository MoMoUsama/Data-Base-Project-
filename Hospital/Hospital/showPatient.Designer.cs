namespace Hospital
{
    partial class showPatient
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
            this.x_RayPatient = new System.Windows.Forms.DataGridView();
            this.patientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showAll = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.x_RayPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // x_RayPatient
            // 
            this.x_RayPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.x_RayPatient.Location = new System.Drawing.Point(18, 229);
            this.x_RayPatient.Name = "x_RayPatient";
            this.x_RayPatient.RowHeadersWidth = 51;
            this.x_RayPatient.RowTemplate.Height = 24;
            this.x_RayPatient.Size = new System.Drawing.Size(1078, 233);
            this.x_RayPatient.TabIndex = 9;
            this.x_RayPatient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.x_RayPatient_CellContentClick);
            // 
            // patientID
            // 
            this.patientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.patientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.patientID.Location = new System.Drawing.Point(330, 53);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(301, 41);
            this.patientID.TabIndex = 8;
            this.patientID.TextChanged += new System.EventHandler(this.patientID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Patient ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // showAll
            // 
            this.showAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.showAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showAll.Location = new System.Drawing.Point(574, 138);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(219, 55);
            this.showAll.TabIndex = 6;
            this.showAll.Text = "Show All";
            this.showAll.UseVisualStyleBackColor = false;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Location = new System.Drawing.Point(89, 138);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(195, 55);
            this.search.TabIndex = 5;
            this.search.Text = "serach";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(896, 26);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(136, 54);
            this.back.TabIndex = 10;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // showPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1126, 538);
            this.Controls.Add(this.back);
            this.Controls.Add(this.x_RayPatient);
            this.Controls.Add(this.patientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAll);
            this.Controls.Add(this.search);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "showPatient";
            this.Text = "showPatient";
            this.Load += new System.EventHandler(this.showPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.x_RayPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView x_RayPatient;
        private System.Windows.Forms.TextBox patientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button back;
    }
}