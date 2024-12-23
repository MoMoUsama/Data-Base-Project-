namespace Hospital
{
    partial class Doctor
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
            this.description = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pharmace = new System.Windows.Forms.CheckBox();
            this.xRay = new System.Windows.Forms.CheckBox();
            this.analysis = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "patient id";
            // 
            // patientId
            // 
            this.patientId.Location = new System.Drawing.Point(229, 50);
            this.patientId.Name = "patientId";
            this.patientId.Size = new System.Drawing.Size(100, 22);
            this.patientId.TabIndex = 1;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(27, 111);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(747, 140);
            this.description.TabIndex = 2;
            this.description.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Assign this patient to X_Ray ?";
            // 
            // pharmace
            // 
            this.pharmace.AutoSize = true;
            this.pharmace.Location = new System.Drawing.Point(49, 483);
            this.pharmace.Name = "pharmace";
            this.pharmace.Size = new System.Drawing.Size(91, 20);
            this.pharmace.TabIndex = 4;
            this.pharmace.Text = "Pharmace";
            this.pharmace.UseVisualStyleBackColor = true;
            // 
            // xRay
            // 
            this.xRay.AutoSize = true;
            this.xRay.Location = new System.Drawing.Point(234, 483);
            this.xRay.Name = "xRay";
            this.xRay.Size = new System.Drawing.Size(69, 20);
            this.xRay.TabIndex = 5;
            this.xRay.Text = "X_Ray";
            this.xRay.UseVisualStyleBackColor = true;
            // 
            // analysis
            // 
            this.analysis.AutoSize = true;
            this.analysis.Location = new System.Drawing.Point(427, 483);
            this.analysis.Name = "analysis";
            this.analysis.Size = new System.Drawing.Size(80, 20);
            this.analysis.TabIndex = 6;
            this.analysis.Text = "Analysis";
            this.analysis.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(62, 386);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Tag = "";
            this.comboBox2.Text = "Day";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(334, 386);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.Text = "Month";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(627, 386);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.Text = "Year";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.analysis);
            this.Controls.Add(this.xRay);
            this.Controls.Add(this.pharmace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.description);
            this.Controls.Add(this.patientId);
            this.Controls.Add(this.label1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientId;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox pharmace;
        private System.Windows.Forms.CheckBox xRay;
        private System.Windows.Forms.CheckBox analysis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}