namespace talYBProj.Forms
{
    partial class packList
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
            this.dataGridVie1 = new System.Windows.Forms.DataGridView();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVie1
            // 
            this.dataGridVie1.AllowUserToAddRows = false;
            this.dataGridVie1.AllowUserToDeleteRows = false;
            this.dataGridVie1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVie1.AutoGenerateColumns = false;
            this.dataGridVie1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVie1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVie1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weightDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridVie1.DataSource = this.packTBLBindingSource;
            this.dataGridVie1.Location = new System.Drawing.Point(-1, -4);
            this.dataGridVie1.Name = "dataGridVie1";
            this.dataGridVie1.ReadOnly = true;
            this.dataGridVie1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridVie1.RowHeadersVisible = false;
            this.dataGridVie1.RowHeadersWidth = 51;
            this.dataGridVie1.Size = new System.Drawing.Size(854, 387);
            this.dataGridVie1.TabIndex = 0;
            this.dataGridVie1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // packTBLBindingSource
            // 
            this.packTBLBindingSource.DataSource = typeof(talYBProj.packTBL);
            // 
            // packList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.dataGridVie1);
            this.Name = "packList";
            this.Text = "packList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packTBLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVie1;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource packTBLBindingSource;
    }
}