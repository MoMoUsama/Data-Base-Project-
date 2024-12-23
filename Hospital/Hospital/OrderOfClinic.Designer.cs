namespace Hospital
{
    partial class OrderOfClinic
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
            this.clinicOrder = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clinicOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(66, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Clinic Name";
            // 
            // clinicName
            // 
            this.clinicName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.clinicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicName.ForeColor = System.Drawing.SystemColors.Window;
            this.clinicName.Location = new System.Drawing.Point(395, 106);
            this.clinicName.Name = "clinicName";
            this.clinicName.Size = new System.Drawing.Size(417, 41);
            this.clinicName.TabIndex = 1;
            // 
            // clinicOrder
            // 
            this.clinicOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clinicOrder.Location = new System.Drawing.Point(32, 203);
            this.clinicOrder.Name = "clinicOrder";
            this.clinicOrder.RowHeadersWidth = 51;
            this.clinicOrder.RowTemplate.Height = 24;
            this.clinicOrder.Size = new System.Drawing.Size(942, 286);
            this.clinicOrder.TabIndex = 2;
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(104)))), ((int)(((byte)(79)))));
            this.order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.order.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.order.Location = new System.Drawing.Point(362, 509);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(196, 62);
            this.order.TabIndex = 3;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = false;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(842, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderOfClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1007, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.order);
            this.Controls.Add(this.clinicOrder);
            this.Controls.Add(this.clinicName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "OrderOfClinic";
            this.Text = "OrderOfClinic";
            ((System.ComponentModel.ISupportInitialize)(this.clinicOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clinicName;
        private System.Windows.Forms.DataGridView clinicOrder;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button button1;
    }
}