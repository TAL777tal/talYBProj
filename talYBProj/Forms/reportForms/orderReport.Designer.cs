namespace talYBProj.Forms
{
    partial class orderReport
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
            this.orderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kbtnGenerate = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.orderViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderViewBindingSource
            // 
            this.orderViewBindingSource.DataSource = typeof(talYBProj.orderView);
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.orderViewBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "talYBProj.Forms.reportForms.orderReport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(22, 100);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(243, 316);
            this.reportViewer2.TabIndex = 0;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // kbtnGenerate
            // 
            this.kbtnGenerate.Location = new System.Drawing.Point(256, 31);
            this.kbtnGenerate.Name = "kbtnGenerate";
            this.kbtnGenerate.Size = new System.Drawing.Size(304, 46);
            this.kbtnGenerate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnGenerate.TabIndex = 1;
            this.kbtnGenerate.Values.Text = "צור דוח";
            this.kbtnGenerate.Click += new System.EventHandler(this.kbtnGenerate_Click);
            // 
            // orderReport
            // 
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.kbtnGenerate);
            this.Controls.Add(this.reportViewer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderReport";
            this.Load += new System.EventHandler(this.orderReport_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.orderViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnGenerate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Krypton.Toolkit.KryptonButton kbtnGenerate;
        private System.Windows.Forms.BindingSource orderViewBindingSource;
    }
}