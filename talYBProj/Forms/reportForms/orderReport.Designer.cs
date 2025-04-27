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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kbtnGenerate = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(21, 112);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(755, 316);
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
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.kbtnGenerate);
            this.Controls.Add(this.reportViewer2);
            this.Name = "orderReport";
            this.Load += new System.EventHandler(this.orderReport_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnGenerate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Krypton.Toolkit.KryptonButton kbtnGenerate;
    }
}