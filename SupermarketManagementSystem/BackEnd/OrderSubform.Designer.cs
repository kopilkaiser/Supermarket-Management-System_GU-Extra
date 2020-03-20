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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrdermanagement
            // 
            this.btnOrdermanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdermanagement.Location = new System.Drawing.Point(173, 174);
            this.btnOrdermanagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrdermanagement.Name = "btnOrdermanagement";
            this.btnOrdermanagement.Size = new System.Drawing.Size(201, 98);
            this.btnOrdermanagement.TabIndex = 0;
            this.btnOrdermanagement.Text = "&Order Management";
            this.btnOrdermanagement.UseVisualStyleBackColor = true;
            this.btnOrdermanagement.Click += new System.EventHandler(this.btnOrdermanagement_Click);
            // 
            // btnOrderlinemanagement
            // 
            this.btnOrderlinemanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderlinemanagement.Location = new System.Drawing.Point(400, 174);
            this.btnOrderlinemanagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrderlinemanagement.Name = "btnOrderlinemanagement";
            this.btnOrderlinemanagement.Size = new System.Drawing.Size(209, 98);
            this.btnOrderlinemanagement.TabIndex = 1;
            this.btnOrderlinemanagement.Text = "&Show Orderline List";
            this.btnOrderlinemanagement.UseVisualStyleBackColor = true;
            this.btnOrderlinemanagement.Click += new System.EventHandler(this.btnOrderlinemanagement_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Cornsilk;
            this.btnMainMenu.FlatAppearance.BorderSize = 5;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnMainMenu.Location = new System.Drawing.Point(550, 375);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(209, 53);
            this.btnMainMenu.TabIndex = 8;
            this.btnMainMenu.Text = "Back To MainMenu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // OrderSubform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnOrderlinemanagement);
            this.Controls.Add(this.btnOrdermanagement);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderSubform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderSubform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdermanagement;
        private System.Windows.Forms.Button btnOrderlinemanagement;
        private System.Windows.Forms.Button btnMainMenu;
    }
}