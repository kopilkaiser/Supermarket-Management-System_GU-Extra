namespace BackEnd
{
    partial class AddStaffForm
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
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhonenum = new System.Windows.Forms.TextBox();
            this.txtDateJoined = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhonenum = new System.Windows.Forms.Label();
            this.lblDateJoined = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(134, 50);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNo.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtPhonenum
            // 
            this.txtPhonenum.Location = new System.Drawing.Point(134, 130);
            this.txtPhonenum.Name = "txtPhonenum";
            this.txtPhonenum.Size = new System.Drawing.Size(100, 20);
            this.txtPhonenum.TabIndex = 3;
            // 
            // txtDateJoined
            // 
            this.txtDateJoined.Location = new System.Drawing.Point(134, 171);
            this.txtDateJoined.Name = "txtDateJoined";
            this.txtDateJoined.Size = new System.Drawing.Size(100, 20);
            this.txtDateJoined.TabIndex = 4;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(134, 215);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 5;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(79, 287);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(38, 50);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(64, 13);
            this.lblAccountNo.TabIndex = 8;
            this.lblAccountNo.Text = "Account No";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // lblPhonenum
            // 
            this.lblPhonenum.AutoSize = true;
            this.lblPhonenum.Location = new System.Drawing.Point(38, 128);
            this.lblPhonenum.Name = "lblPhonenum";
            this.lblPhonenum.Size = new System.Drawing.Size(78, 13);
            this.lblPhonenum.TabIndex = 10;
            this.lblPhonenum.Text = "Phone Number";
            // 
            // lblDateJoined
            // 
            this.lblDateJoined.AutoSize = true;
            this.lblDateJoined.Location = new System.Drawing.Point(38, 169);
            this.lblDateJoined.Name = "lblDateJoined";
            this.lblDateJoined.Size = new System.Drawing.Size(64, 13);
            this.lblDateJoined.TabIndex = 11;
            this.lblDateJoined.Text = "Date Joined";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 349);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "label1";
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 371);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblDateJoined);
            this.Controls.Add(this.lblPhonenum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtDateJoined);
            this.Controls.Add(this.txtPhonenum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAccountNo);
            this.Name = "AddStaffForm";
            this.Text = "AddStaffForm";
            this.Load += new System.EventHandler(this.AddStaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhonenum;
        private System.Windows.Forms.TextBox txtDateJoined;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhonenum;
        private System.Windows.Forms.Label lblDateJoined;
        private System.Windows.Forms.Label lblError;
    }
}