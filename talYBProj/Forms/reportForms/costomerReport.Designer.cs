namespace talYBProj.Forms.reportForms
{
    partial class costomerReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.kbtnGenerate = new Krypton.Toolkit.KryptonButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dgvCust = new System.Windows.Forms.DataGridView();
            this.customerViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kbtnGenerate
            // 
            this.kbtnGenerate.Location = new System.Drawing.Point(416, 40);
            this.kbtnGenerate.Name = "kbtnGenerate";
            this.kbtnGenerate.Size = new System.Drawing.Size(304, 46);
            this.kbtnGenerate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerate.TabIndex = 2;
            this.kbtnGenerate.Values.Text = "צור דוח";
            this.kbtnGenerate.Click += new System.EventHandler(this.kbtnGenerate_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 63;
            reportDataSource1.Name = "DScostomer";
            reportDataSource1.Value = this.customerViewBindingSource;
            reportDataSource2.Name = "DScostom";
            reportDataSource2.Value = this.customerViewBindingSource;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.customerViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "talYBProj.Forms.reportForms.costomerReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 116);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(527, 322);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dgvCust
            // 
            this.dgvCust.AllowUserToAddRows = false;
            this.dgvCust.AllowUserToDeleteRows = false;
            this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCust.Location = new System.Drawing.Point(587, 116);
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.ReadOnly = true;
            this.dgvCust.RowHeadersWidth = 51;
            this.dgvCust.RowTemplate.Height = 24;
            this.dgvCust.Size = new System.Drawing.Size(473, 322);
            this.dgvCust.TabIndex = 4;
            // 
            // customerViewBindingSource
            // 
            this.customerViewBindingSource.DataSource = typeof(talYBProj.customerView);
            // 
            // costomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1122, 531);
            this.Controls.Add(this.dgvCust);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.kbtnGenerate);
            this.Name = "costomerReport";
            this.Text = "costomerReport";
            this.Load += new System.EventHandler(this.costomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton kbtnGenerate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource customerViewBindingSource;
        private System.Windows.Forms.DataGridView dgvCust;
    }
}