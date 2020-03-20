namespace BackEnd
{
    partial class OrderlineListForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewOrderLine = new System.Windows.Forms.DataGridView();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.sMS_SSDBDataSet_OrderLineTable = new BackEnd.SMS_SSDBDataSet_OrderLineTable();
            this.sMSSSDBDataSetOrderLineTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrderlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrderlineTableAdapter = new BackEnd.SMS_SSDBDataSet_OrderLineTableTableAdapters.tblOrderlineTableAdapter();
            this.orderlineIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMS_SSDBDataSet_OrderLineTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSSSDBDataSetOrderLineTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderlineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrderLine
            // 
            this.dataGridViewOrderLine.AutoGenerateColumns = false;
            this.dataGridViewOrderLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderlineIdDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.inventoryIdDataGridViewTextBoxColumn});
            this.dataGridViewOrderLine.DataSource = this.tblOrderlineBindingSource;
            this.dataGridViewOrderLine.Location = new System.Drawing.Point(166, 89);
            this.dataGridViewOrderLine.Name = "dataGridViewOrderLine";
            this.dataGridViewOrderLine.RowTemplate.Height = 24;
            this.dataGridViewOrderLine.Size = new System.Drawing.Size(840, 349);
            this.dataGridViewOrderLine.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Cornsilk;
            this.btnMainMenu.FlatAppearance.BorderSize = 5;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnMainMenu.Location = new System.Drawing.Point(959, 476);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(209, 53);
            this.btnMainMenu.TabIndex = 9;
            this.btnMainMenu.Text = "Back To MainMenu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // sMS_SSDBDataSet_OrderLineTable
            // 
            this.sMS_SSDBDataSet_OrderLineTable.DataSetName = "SMS_SSDBDataSet_OrderLineTable";
            this.sMS_SSDBDataSet_OrderLineTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sMSSSDBDataSetOrderLineTableBindingSource
            // 
            this.sMSSSDBDataSetOrderLineTableBindingSource.DataSource = this.sMS_SSDBDataSet_OrderLineTable;
            this.sMSSSDBDataSetOrderLineTableBindingSource.Position = 0;
            // 
            // tblOrderlineBindingSource
            // 
            this.tblOrderlineBindingSource.DataMember = "tblOrderline";
            this.tblOrderlineBindingSource.DataSource = this.sMSSSDBDataSetOrderLineTableBindingSource;
            // 
            // tblOrderlineTableAdapter
            // 
            this.tblOrderlineTableAdapter.ClearBeforeFill = true;
            // 
            // orderlineIdDataGridViewTextBoxColumn
            // 
            this.orderlineIdDataGridViewTextBoxColumn.DataPropertyName = "OrderlineId";
            this.orderlineIdDataGridViewTextBoxColumn.HeaderText = "OrderlineId";
            this.orderlineIdDataGridViewTextBoxColumn.Name = "orderlineIdDataGridViewTextBoxColumn";
            this.orderlineIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // inventoryIdDataGridViewTextBoxColumn
            // 
            this.inventoryIdDataGridViewTextBoxColumn.DataPropertyName = "InventoryId";
            this.inventoryIdDataGridViewTextBoxColumn.HeaderText = "InventoryId";
            this.inventoryIdDataGridViewTextBoxColumn.Name = "inventoryIdDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(446, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Order Line List";
            // 
            // OrderlineListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1197, 551);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.dataGridViewOrderLine);
            this.Name = "OrderlineListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderlineListForm";
            this.Load += new System.EventHandler(this.OrderlineListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMS_SSDBDataSet_OrderLineTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMSSSDBDataSetOrderLineTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderlineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrderLine;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.BindingSource sMSSSDBDataSetOrderLineTableBindingSource;
        private SMS_SSDBDataSet_OrderLineTable sMS_SSDBDataSet_OrderLineTable;
        private System.Windows.Forms.BindingSource tblOrderlineBindingSource;
        private SMS_SSDBDataSet_OrderLineTableTableAdapters.tblOrderlineTableAdapter tblOrderlineTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderlineIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}