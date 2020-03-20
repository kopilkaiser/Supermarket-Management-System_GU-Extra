namespace BackEnd
{
    partial class AddPaymentForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtPayeeName = new System.Windows.Forms.TextBox();
            this.lblPayeeName = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.txtPaymentDate = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddPaymentTitle = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(535, 541);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 37);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtPayeeName
            // 
            this.txtPayeeName.Location = new System.Drawing.Point(634, 141);
            this.txtPayeeName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtPayeeName.Name = "txtPayeeName";
            this.txtPayeeName.Size = new System.Drawing.Size(294, 26);
            this.txtPayeeName.TabIndex = 1;
            // 
            // lblPayeeName
            // 
            this.lblPayeeName.AutoSize = true;
            this.lblPayeeName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPayeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayeeName.Location = new System.Drawing.Point(464, 141);
            this.lblPayeeName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblPayeeName.Name = "lblPayeeName";
            this.lblPayeeName.Size = new System.Drawing.Size(94, 17);
            this.lblPayeeName.TabIndex = 2;
            this.lblPayeeName.Text = "PayeeName";
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "Visa Debit",
            "Credit Card",
            "MasterCard"});
            this.cmbMethod.Location = new System.Drawing.Point(634, 271);
            this.cmbMethod.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(294, 28);
            this.cmbMethod.TabIndex = 3;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(464, 211);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(98, 17);
            this.lblCardNumber.TabIndex = 5;
            this.lblCardNumber.Text = "CardNumber";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(634, 211);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(294, 26);
            this.txtCardNumber.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(464, 331);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(62, 17);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(634, 331);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(294, 26);
            this.txtAmount.TabIndex = 4;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.Location = new System.Drawing.Point(464, 401);
            this.lblPaymentDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(104, 17);
            this.lblPaymentDate.TabIndex = 9;
            this.lblPaymentDate.Text = "PaymentDate";
            // 
            // txtPaymentDate
            // 
            this.txtPaymentDate.Location = new System.Drawing.Point(634, 401);
            this.txtPaymentDate.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtPaymentDate.Name = "txtPaymentDate";
            this.txtPaymentDate.Size = new System.Drawing.Size(294, 26);
            this.txtPaymentDate.TabIndex = 5;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(464, 271);
            this.lblMethod.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(61, 17);
            this.lblMethod.TabIndex = 11;
            this.lblMethod.Text = "Method";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(775, 541);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddPaymentTitle
            // 
            this.lblAddPaymentTitle.AutoSize = true;
            this.lblAddPaymentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAddPaymentTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddPaymentTitle.Location = new System.Drawing.Point(554, 61);
            this.lblAddPaymentTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblAddPaymentTitle.Name = "lblAddPaymentTitle";
            this.lblAddPaymentTitle.Size = new System.Drawing.Size(234, 29);
            this.lblAddPaymentTitle.TabIndex = 13;
            this.lblAddPaymentTitle.Text = "Add Payment Form";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(31, 498);
            this.lblError.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(454, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 330);
            this.panel1.TabIndex = 15;
            // 
            // AddPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1494, 618);
            this.ControlBox = false;
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblAddPaymentTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.txtPaymentDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.lblPayeeName);
            this.Controls.Add(this.txtPayeeName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Name = "AddPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPaymentForm";
            this.Load += new System.EventHandler(this.AddPaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtPayeeName;
        private System.Windows.Forms.Label lblPayeeName;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.TextBox txtPaymentDate;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddPaymentTitle;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panel1;
    }
}