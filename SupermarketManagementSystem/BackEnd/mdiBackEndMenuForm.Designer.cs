namespace BackEnd
{
    partial class mdiBackEndMenuForm
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
            this.btnInventoryManagement = new System.Windows.Forms.Button();
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnPaymentManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventoryManagement
            // 
            this.btnInventoryManagement.Location = new System.Drawing.Point(174, 205);
            this.btnInventoryManagement.Name = "btnInventoryManagement";
            this.btnInventoryManagement.Size = new System.Drawing.Size(104, 59);
            this.btnInventoryManagement.TabIndex = 0;
            this.btnInventoryManagement.Text = "Inventory Management";
            this.btnInventoryManagement.UseVisualStyleBackColor = true;
            this.btnInventoryManagement.Click += new System.EventHandler(this.btnInventoryManagement_Click);
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.Location = new System.Drawing.Point(284, 205);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Size = new System.Drawing.Size(104, 59);
            this.btnStaffManagement.TabIndex = 1;
            this.btnStaffManagement.Text = "Staff Management";
            this.btnStaffManagement.UseVisualStyleBackColor = true;
            this.btnStaffManagement.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // btnPaymentManagement
            // 
            this.btnPaymentManagement.Location = new System.Drawing.Point(394, 205);
            this.btnPaymentManagement.Name = "btnPaymentManagement";
            this.btnPaymentManagement.Size = new System.Drawing.Size(104, 59);
            this.btnPaymentManagement.TabIndex = 2;
            this.btnPaymentManagement.Text = "Payment Management";
            this.btnPaymentManagement.UseVisualStyleBackColor = true;
            this.btnPaymentManagement.Click += new System.EventHandler(this.btnPaymentManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Location = new System.Drawing.Point(504, 205);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(104, 59);
            this.btnOrderManagement.TabIndex = 3;
            this.btnOrderManagement.Text = "Order Management";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            // 
            // mdiBackEndMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrderManagement);
            this.Controls.Add(this.btnPaymentManagement);
            this.Controls.Add(this.btnStaffManagement);
            this.Controls.Add(this.btnInventoryManagement);
            this.Name = "mdiBackEndMenuForm";
            this.Text = "mdiBackEndMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventoryManagement;
        private System.Windows.Forms.Button btnStaffManagement;
        private System.Windows.Forms.Button btnPaymentManagement;
        private System.Windows.Forms.Button btnOrderManagement;
    }
}