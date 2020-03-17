namespace BackEnd
{
    partial class ConfirmDeleteStaffForm
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
            this.btnYES = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYES
            // 
            this.btnYES.Location = new System.Drawing.Point(52, 57);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(75, 47);
            this.btnYES.TabIndex = 0;
            this.btnYES.Text = "&YES";
            this.btnYES.UseVisualStyleBackColor = true;
            this.btnYES.Click += new System.EventHandler(this.btnYES_Click);
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(177, 57);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(75, 47);
            this.btnNO.TabIndex = 1;
            this.btnNO.Text = "&NO";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // ConfirmDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 175);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnYES);
            this.Name = "ConfirmDeleteForm";
            this.Text = "ConfirmDeleteForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYES;
        private System.Windows.Forms.Button btnNO;
    }
}