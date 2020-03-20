namespace BackEnd
{
    partial class OrderSubform
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
            this.btnOrdermanagement = new System.Windows.Forms.Button();
            this.btnOrderlinemanagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrdermanagement
            // 
            this.btnOrdermanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdermanagement.Location = new System.Drawing.Point(173, 174);
            this.btnOrdermanagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrdermanagement.Name = "btnOrdermanagement";
            this.btnOrdermanagement.Size = new System.Drawing.Size(147, 78);
            this.btnOrdermanagement.TabIndex = 0;
            this.btnOrdermanagement.Text = "&Order Management";
            this.btnOrdermanagement.UseVisualStyleBackColor = true;
            // 
            // btnOrderlinemanagement
            // 
            this.btnOrderlinemanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderlinemanagement.Location = new System.Drawing.Point(385, 174);
            this.btnOrderlinemanagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderlinemanagement.Name = "btnOrderlinemanagement";
            this.btnOrderlinemanagement.Size = new System.Drawing.Size(155, 78);
            this.btnOrderlinemanagement.TabIndex = 1;
            this.btnOrderlinemanagement.Text = "&Orderline Management";
            this.btnOrderlinemanagement.UseVisualStyleBackColor = true;
            // 
            // OrderSubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnOrderlinemanagement);
            this.Controls.Add(this.btnOrdermanagement);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderSubform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderSubform";
            this.Load += new System.EventHandler(this.OrderSubform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdermanagement;
        private System.Windows.Forms.Button btnOrderlinemanagement;
    }
}