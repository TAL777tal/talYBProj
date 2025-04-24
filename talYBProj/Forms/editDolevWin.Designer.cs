namespace talYBProj.Forms
{
    partial class editDolevWin
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
            this.userTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxOrderId = new System.Windows.Forms.ComboBox();
            this.orderTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelOrderId = new Krypton.Toolkit.KryptonLabel();
            this.dgvOlives = new System.Windows.Forms.DataGridView();
            this.dolevNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightNetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oliveTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxOlives = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nupEditDolev = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOlives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oliveTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEditDolev)).BeginInit();
            this.SuspendLayout();
            // 
            // userTBLBindingSource
            // 
            this.userTBLBindingSource.DataSource = typeof(talYBProj.userTBL);
            // 
            // cbxOrderId
            // 
            this.cbxOrderId.DataSource = this.orderTBLBindingSource;
            this.cbxOrderId.DisplayMember = "Id";
            this.cbxOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrderId.FormattingEnabled = true;
            this.cbxOrderId.Location = new System.Drawing.Point(742, 39);
            this.cbxOrderId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOrderId.Name = "cbxOrderId";
            this.cbxOrderId.Size = new System.Drawing.Size(121, 24);
            this.cbxOrderId.TabIndex = 25;
            this.cbxOrderId.SelectedIndexChanged += new System.EventHandler(this.cbxOrderId_SelectedIndexChanged);
            // 
            // orderTBLBindingSource
            // 
            this.orderTBLBindingSource.DataSource = typeof(talYBProj.orderTBL);
            // 
            // LabelOrderId
            // 
            this.LabelOrderId.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.LabelOrderId.Location = new System.Drawing.Point(923, 39);
            this.LabelOrderId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelOrderId.Name = "LabelOrderId";
            this.LabelOrderId.Size = new System.Drawing.Size(112, 24);
            this.LabelOrderId.TabIndex = 18;
            this.LabelOrderId.Values.Text = "מספר ההזמנה";
            // 
            // dgvOlives
            // 
            this.dgvOlives.AllowUserToAddRows = false;
            this.dgvOlives.AllowUserToDeleteRows = false;
            this.dgvOlives.AutoGenerateColumns = false;
            this.dgvOlives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOlives.BackgroundColor = System.Drawing.Color.Teal;
            this.dgvOlives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOlives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dolevNumDataGridViewTextBoxColumn,
            this.weightBrutoDataGridViewTextBoxColumn,
            this.weightNetoDataGridViewTextBoxColumn,
            this.currDateDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dgvOlives.DataSource = this.oliveTBLBindingSource;
            this.dgvOlives.Location = new System.Drawing.Point(164, 84);
            this.dgvOlives.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOlives.Name = "dgvOlives";
            this.dgvOlives.ReadOnly = true;
            this.dgvOlives.RowHeadersVisible = false;
            this.dgvOlives.RowHeadersWidth = 51;
            this.dgvOlives.Size = new System.Drawing.Size(699, 185);
            this.dgvOlives.TabIndex = 26;
            this.dgvOlives.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOlives_CellContentClick);
            // 
            // dolevNumDataGridViewTextBoxColumn
            // 
            this.dolevNumDataGridViewTextBoxColumn.DataPropertyName = "dolevNum";
            this.dolevNumDataGridViewTextBoxColumn.HeaderText = "dolevNum";
            this.dolevNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dolevNumDataGridViewTextBoxColumn.Name = "dolevNumDataGridViewTextBoxColumn";
            this.dolevNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightBrutoDataGridViewTextBoxColumn
            // 
            this.weightBrutoDataGridViewTextBoxColumn.DataPropertyName = "weightBruto";
            this.weightBrutoDataGridViewTextBoxColumn.HeaderText = "weightBruto";
            this.weightBrutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightBrutoDataGridViewTextBoxColumn.Name = "weightBrutoDataGridViewTextBoxColumn";
            this.weightBrutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightNetoDataGridViewTextBoxColumn
            // 
            this.weightNetoDataGridViewTextBoxColumn.DataPropertyName = "weightNeto";
            this.weightNetoDataGridViewTextBoxColumn.HeaderText = "weightNeto";
            this.weightNetoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightNetoDataGridViewTextBoxColumn.Name = "weightNetoDataGridViewTextBoxColumn";
            this.weightNetoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // oliveTBLBindingSource
            // 
            this.oliveTBLBindingSource.DataSource = typeof(talYBProj.oliveTBL);
            // 
            // cbxOlives
            // 
            this.cbxOlives.FormattingEnabled = true;
            this.cbxOlives.Location = new System.Drawing.Point(481, 142);
            this.cbxOlives.Margin = new System.Windows.Forms.Padding(4);
            this.cbxOlives.Name = "cbxOlives";
            this.cbxOlives.Size = new System.Drawing.Size(160, 24);
            this.cbxOlives.TabIndex = 27;
            this.cbxOlives.Visible = false;
            this.cbxOlives.SelectedIndexChanged += new System.EventHandler(this.cbxOlives_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Coral;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnUpdate.Location = new System.Drawing.Point(440, 416);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(230, 71);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "עדכן משקל";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // nupEditDolev
            // 
            this.nupEditDolev.BackColor = System.Drawing.Color.White;
            this.nupEditDolev.ForeColor = System.Drawing.Color.Red;
            this.nupEditDolev.Location = new System.Drawing.Point(496, 334);
            this.nupEditDolev.Margin = new System.Windows.Forms.Padding(4);
            this.nupEditDolev.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupEditDolev.Name = "nupEditDolev";
            this.nupEditDolev.Size = new System.Drawing.Size(122, 22);
            this.nupEditDolev.TabIndex = 30;
            this.nupEditDolev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupEditDolev.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // editDolevWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.nupEditDolev);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbxOlives);
            this.Controls.Add(this.dgvOlives);
            this.Controls.Add(this.cbxOrderId);
            this.Controls.Add(this.LabelOrderId);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editDolevWin";
            this.Text = "editDolev";
            this.Load += new System.EventHandler(this.editDolevWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOlives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oliveTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupEditDolev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxOrderId;
        private Krypton.Toolkit.KryptonLabel LabelOrderId;
        private System.Windows.Forms.BindingSource userTBLBindingSource;
        private System.Windows.Forms.BindingSource orderTBLBindingSource;
        private System.Windows.Forms.DataGridView dgvOlives;
        private System.Windows.Forms.ComboBox cbxOlives;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown nupEditDolev;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolevNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightBrutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightNetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oliveTBLBindingSource;
    }
}