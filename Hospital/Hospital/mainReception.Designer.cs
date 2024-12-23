namespace Hospital
{
    partial class mainReception
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
            this.insertPatient = new System.Windows.Forms.Button();
            this.ssearchPatient = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "what you want";
            // 
            // insertPatient
            // 
            this.insertPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.insertPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insertPatient.Location = new System.Drawing.Point(141, 169);
            this.insertPatient.Name = "insertPatient";
            this.insertPatient.Size = new System.Drawing.Size(502, 72);
            this.insertPatient.TabIndex = 1;
            this.insertPatient.Text = "insert new patient";
            this.insertPatient.UseVisualStyleBackColor = false;
            this.insertPatient.Click += new System.EventHandler(this.insertPatient_Click);
            // 
            // ssearchPatient
            // 
            this.ssearchPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.ssearchPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ssearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssearchPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ssearchPatient.Location = new System.Drawing.Point(141, 305);
            this.ssearchPatient.Name = "ssearchPatient";
            this.ssearchPatient.Size = new System.Drawing.Size(502, 70);
            this.ssearchPatient.TabIndex = 2;
            this.ssearchPatient.Text = "search patient";
            this.ssearchPatient.UseVisualStyleBackColor = false;
            this.ssearchPatient.Click += new System.EventHandler(this.ssearchPatient_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(645, 30);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(139, 43);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // mainReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.ssearchPatient);
            this.Controls.Add(this.insertPatient);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "mainReception";
            this.Text = "mainReception";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertPatient;
        private System.Windows.Forms.Button ssearchPatient;
        private System.Windows.Forms.Button back;
    }
}