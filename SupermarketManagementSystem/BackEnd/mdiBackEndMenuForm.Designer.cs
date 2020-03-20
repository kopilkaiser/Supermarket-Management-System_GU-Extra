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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInventoryManagement
            // 
            this.btnInventoryManagement.BackColor = System.Drawing.Color.LightGray;
            this.btnInventoryManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryManagement.Location = new System.Drawing.Point(168, 160);
            this.btnInventoryManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventoryManagement.Name = "btnInventoryManagement";
            this.btnInventoryManagement.Size = new System.Drawing.Size(237, 119);
            this.btnInventoryManagement.TabIndex = 0;
            this.btnInventoryManagement.Text = "&Inventory Management";
            this.btnInventoryManagement.UseVisualStyleBackColor = false;
            this.btnInventoryManagement.Click += new System.EventHandler(this.btnInventoryManagement_Click);
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.BackColor = System.Drawing.Color.LightGray;
            this.btnStaffManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffManagement.Location = new System.Drawing.Point(168, 316);
            this.btnStaffManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Size = new System.Drawing.Size(237, 118);
            this.btnStaffManagement.TabIndex = 1;
            this.btnStaffManagement.Text = "&Staff Management";
            this.btnStaffManagement.UseVisualStyleBackColor = false;
            this.btnStaffManagement.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // btnPaymentManagement
            // 
            this.btnPaymentManagement.BackColor = System.Drawing.Color.LightGray;
            this.btnPaymentManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentManagement.Location = new System.Drawing.Point(439, 160);
            this.btnPaymentManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaymentManagement.Name = "btnPaymentManagement";
            this.btnPaymentManagement.Size = new System.Drawing.Size(237, 119);
            this.btnPaymentManagement.TabIndex = 2;
            this.btnPaymentManagement.Text = "&Payment Management";
            this.btnPaymentManagement.UseVisualStyleBackColor = false;
            this.btnPaymentManagement.Click += new System.EventHandler(this.btnPaymentManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.BackColor = System.Drawing.Color.LightGray;
            this.btnOrderManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderManagement.Location = new System.Drawing.Point(439, 316);
            this.btnOrderManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(237, 118);
            this.btnOrderManagement.TabIndex = 3;
            this.btnOrderManagement.Text = "&Order Management";
            this.btnOrderManagement.UseVisualStyleBackColor = false;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "GU-EXTRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "MANAGEMENT HUB";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 53);
            this.panel1.TabIndex = 6;
            // 
            // mdiBackEndMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(889, 475);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrderManagement);
            this.Controls.Add(this.btnPaymentManagement);
            this.Controls.Add(this.btnStaffManagement);
            this.Controls.Add(this.btnInventoryManagement);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mdiBackEndMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdiBackEndMenuForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInventoryManagement;
        private System.Windows.Forms.Button btnStaffManagement;
        private System.Windows.Forms.Button btnPaymentManagement;
        private System.Windows.Forms.Button btnOrderManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}