﻿namespace BackEnd
{
    partial class ConfirmPaymentDeleteForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblDeleteMessage = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOk.Location = new System.Drawing.Point(102, 115);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 34);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblDeleteMessage
            // 
            this.lblDeleteMessage.AutoSize = true;
            this.lblDeleteMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteMessage.Location = new System.Drawing.Point(40, 61);
            this.lblDeleteMessage.Name = "lblDeleteMessage";
            this.lblDeleteMessage.Size = new System.Drawing.Size(370, 24);
            this.lblDeleteMessage.TabIndex = 1;
            this.lblDeleteMessage.Text = "Are you Confirm to Delete Payment Id?";
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNo.Location = new System.Drawing.Point(247, 115);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(83, 34);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "&No";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // ConfirmPaymentDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 226);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lblDeleteMessage);
            this.Controls.Add(this.btnOk);
            this.Name = "ConfirmPaymentDeleteForm";
            this.Text = "ConfirmPaymentDeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblDeleteMessage;
        private System.Windows.Forms.Button btnNo;
    }
}