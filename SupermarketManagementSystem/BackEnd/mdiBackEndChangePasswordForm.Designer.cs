namespace BackEnd
{
    partial class mdiBackEndChangePasswordForm
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
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(144, 44);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(171, 20);
            this.txtEMail.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(144, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(171, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(144, 117);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(171, 20);
            this.txtPassword1.TabIndex = 2;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(144, 157);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(171, 20);
            this.txtPassword2.TabIndex = 3;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(101, 217);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(126, 23);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Change Password";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(290, 217);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(30, 47);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(77, 13);
            this.lblEMail.TabIndex = 6;
            this.lblEMail.Text = "E-Mail Address";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 83);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Location = new System.Drawing.Point(30, 120);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(78, 13);
            this.lblPassword1.TabIndex = 8;
            this.lblPassword1.Text = "New Password";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(30, 160);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(91, 13);
            this.lblPassword2.TabIndex = 9;
            this.lblPassword2.Text = "Confirm Password";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(30, 268);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 10;
            // 
            // mdiBackEndChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 290);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.lblPassword1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEMail);
            this.Name = "mdiBackEndChangePasswordForm";
            this.Text = "mdiBackEndChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblError;
    }
}