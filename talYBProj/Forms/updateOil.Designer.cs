namespace talYBProj.Forms
{
    partial class updateOil
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
            this.dgvOil = new System.Windows.Forms.DataGridView();
            this.oilTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apdateQuantity = new Krypton.Toolkit.KryptonButton();
            this.kNUDquantity = new Krypton.Toolkit.KryptonNumericUpDown();
            this.orderLabel = new Krypton.Toolkit.KryptonLabel();
            this.cbxOrder = new System.Windows.Forms.ComboBox();
            this.orderTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxOil = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOil
            // 
            this.dgvOil.AllowUserToAddRows = false;
            this.dgvOil.AllowUserToDeleteRows = false;
            this.dgvOil.AutoGenerateColumns = false;
            this.dgvOil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.packIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.currDateDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dgvOil.DataSource = this.oilTBLBindingSource;
            this.dgvOil.Location = new System.Drawing.Point(91, 79);
            this.dgvOil.Name = "dgvOil";
            this.dgvOil.ReadOnly = true;
            this.dgvOil.RowHeadersWidth = 51;
            this.dgvOil.RowTemplate.Height = 24;
            this.dgvOil.Size = new System.Drawing.Size(612, 238);
            this.dgvOil.TabIndex = 0;
            // 
            // oilTBLBindingSource
            // 
            this.oilTBLBindingSource.DataSource = typeof(talYBProj.oilTBL);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packIDDataGridViewTextBoxColumn
            // 
            this.packIDDataGridViewTextBoxColumn.DataPropertyName = "PackID";
            this.packIDDataGridViewTextBoxColumn.HeaderText = "PackID";
            this.packIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.packIDDataGridViewTextBoxColumn.Name = "packIDDataGridViewTextBoxColumn";
            this.packIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currDateDataGridViewTextBoxColumn
            // 
            this.currDateDataGridViewTextBoxColumn.DataPropertyName = "currDate";
            this.currDateDataGridViewTextBoxColumn.HeaderText = "currDate";
            this.currDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currDateDataGridViewTextBoxColumn.Name = "currDateDataGridViewTextBoxColumn";
            this.currDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apdateQuantity
            // 
            this.apdateQuantity.Location = new System.Drawing.Point(307, 422);
            this.apdateQuantity.Name = "apdateQuantity";
            this.apdateQuantity.Size = new System.Drawing.Size(190, 41);
            this.apdateQuantity.TabIndex = 1;
            this.apdateQuantity.Values.Text = "עדכן כמות";
            this.apdateQuantity.Click += new System.EventHandler(this.apdateQuantity_Click);
            // 
            // kNUDquantity
            // 
            this.kNUDquantity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kNUDquantity.Location = new System.Drawing.Point(336, 368);
            this.kNUDquantity.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.kNUDquantity.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.kNUDquantity.Name = "kNUDquantity";
            this.kNUDquantity.Size = new System.Drawing.Size(138, 26);
            this.kNUDquantity.TabIndex = 2;
            this.kNUDquantity.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // orderLabel
            // 
            this.orderLabel.Location = new System.Drawing.Point(594, 30);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(98, 24);
            this.orderLabel.TabIndex = 3;
            this.orderLabel.Values.Text = "מספר הזמנה";
            // 
            // cbxOrder
            // 
            this.cbxOrder.DataSource = this.orderTBLBindingSource;
            this.cbxOrder.DisplayMember = "Id";
            this.cbxOrder.FormattingEnabled = true;
            this.cbxOrder.Location = new System.Drawing.Point(431, 30);
            this.cbxOrder.Name = "cbxOrder";
            this.cbxOrder.Size = new System.Drawing.Size(121, 24);
            this.cbxOrder.TabIndex = 4;
            this.cbxOrder.SelectedIndexChanged += new System.EventHandler(this.cbxOrder_SelectedIndexChanged);
            // 
            // orderTBLBindingSource
            // 
            this.orderTBLBindingSource.DataSource = typeof(talYBProj.orderTBL);
            // 
            // cbxOil
            // 
            this.cbxOil.FormattingEnabled = true;
            this.cbxOil.Location = new System.Drawing.Point(395, 166);
            this.cbxOil.Name = "cbxOil";
            this.cbxOil.Size = new System.Drawing.Size(121, 24);
            this.cbxOil.TabIndex = 5;
            this.cbxOil.Visible = false;
            this.cbxOil.SelectedIndexChanged += new System.EventHandler(this.cbxOil_SelectedIndexChanged);
            // 
            // updateOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.cbxOil);
            this.Controls.Add(this.cbxOrder);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.kNUDquantity);
            this.Controls.Add(this.apdateQuantity);
            this.Controls.Add(this.dgvOil);
            this.Name = "updateOil";
            this.Text = "updateOil";
            this.Load += new System.EventHandler(this.updateOil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOil;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oilTBLBindingSource;
        private Krypton.Toolkit.KryptonButton apdateQuantity;
        private Krypton.Toolkit.KryptonNumericUpDown kNUDquantity;
        private Krypton.Toolkit.KryptonLabel orderLabel;
        private System.Windows.Forms.ComboBox cbxOrder;
        private System.Windows.Forms.BindingSource orderTBLBindingSource;
        private System.Windows.Forms.ComboBox cbxOil;
    }
}