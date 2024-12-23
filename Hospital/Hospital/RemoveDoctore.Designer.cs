namespace Hospital
{
    partial class RemoveDoctore
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
            this.doc_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeDoc = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doc_ID
            // 
            this.doc_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.doc_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_ID.ForeColor = System.Drawing.SystemColors.Window;
            this.doc_ID.Location = new System.Drawing.Point(289, 103);
            this.doc_ID.Name = "doc_ID";
            this.doc_ID.Size = new System.Drawing.Size(368, 41);
            this.doc_ID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Doctor ID";
            // 
            // removeDoc
            // 
            this.removeDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.removeDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeDoc.Location = new System.Drawing.Point(221, 255);
            this.removeDoc.Name = "removeDoc";
            this.removeDoc.Size = new System.Drawing.Size(292, 64);
            this.removeDoc.TabIndex = 4;
            this.removeDoc.Text = "Remove";
            this.removeDoc.UseVisualStyleBackColor = false;
            this.removeDoc.Click += new System.EventHandler(this.removeDoc_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(631, 26);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(124, 44);
            this.back.TabIndex = 5;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // RemoveDoctore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.removeDoc);
            this.Controls.Add(this.doc_ID);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "RemoveDoctore";
            this.Text = "RemoveDoctore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox doc_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeDoc;
        private System.Windows.Forms.Button back;
    }
}