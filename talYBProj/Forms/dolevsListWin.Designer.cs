namespace talYBProj.Forms
{
    partial class dolevsListWin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dolevNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightNetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oliveTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oliveTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dolevNumDataGridViewTextBoxColumn,
            this.currDateDataGridViewTextBoxColumn,
            this.weightBrutoDataGridViewTextBoxColumn,
            this.weightNetoDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oliveTBLBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(729, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dolevNumDataGridViewTextBoxColumn
            // 
            this.dolevNumDataGridViewTextBoxColumn.DataPropertyName = "dolevNum";
            this.dolevNumDataGridViewTextBoxColumn.HeaderText = "dolevNum";
            this.dolevNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dolevNumDataGridViewTextBoxColumn.Name = "dolevNumDataGridViewTextBoxColumn";
            this.dolevNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currDateDataGridViewTextBoxColumn
            // 
            this.currDateDataGridViewTextBoxColumn.DataPropertyName = "currDate";
            this.currDateDataGridViewTextBoxColumn.HeaderText = "currDate";
            this.currDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currDateDataGridViewTextBoxColumn.Name = "currDateDataGridViewTextBoxColumn";
            this.currDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dolevsListWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dolevsListWin";
            this.Text = "dolevsListWin";
            this.Load += new System.EventHandler(this.dolevsListWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oliveTBLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource oliveTBLBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolevNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightBrutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightNetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}