namespace talYBProj
{
    partial class mainWin
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
            this.kryptonRibbon1 = new Krypton.Ribbon.KryptonRibbon();
            this.customerTab = new Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btnOpenCustWin = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.krRGBopenUpdateWin = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.BtnOpenCostomerListWin = new Krypton.Ribbon.KryptonRibbonGroupButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.kryptonRibbonTab1 = new Krypton.Ribbon.KryptonRibbonTab();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.AllowFormIntegrate = true;
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.QATLocation = Krypton.Ribbon.QATLocation.Hidden;
            this.kryptonRibbon1.RibbonAppButton.AppButtonText = "jadek";
            this.kryptonRibbon1.RibbonAppButton.AppButtonVisible = false;
            this.kryptonRibbon1.RibbonTabs.AddRange(new Krypton.Ribbon.KryptonRibbonTab[] {
            this.customerTab,
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedTab = this.customerTab;
            this.kryptonRibbon1.ShowMinimizeButton = false;
            this.kryptonRibbon1.Size = new System.Drawing.Size(800, 171);
            this.kryptonRibbon1.TabIndex = 0;
            // 
            // customerTab
            // 
            this.customerTab.Groups.AddRange(new Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            this.customerTab.Text = "ניהול לקוחות";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.kryptonRibbonGroup1.TextLine1 = "ניהול לקוחות";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btnOpenCustWin,
            this.krRGBopenUpdateWin,
            this.BtnOpenCostomerListWin});
            // 
            // btnOpenCustWin
            // 
            this.btnOpenCustWin.TextLine1 = "הוסף לקוח";
            this.btnOpenCustWin.Click += new System.EventHandler(this.btnOpenCustWin_Click);
            // 
            // krRGBopenUpdateWin
            // 
            this.krRGBopenUpdateWin.TextLine1 = "עדכן לקוח";
            this.krRGBopenUpdateWin.Click += new System.EventHandler(this.kryptonRibbonGroupButton2_Click);
            // 
            // BtnOpenCostomerListWin
            // 
            this.BtnOpenCostomerListWin.TextLine1 = "רשימת לקוחות";
            this.BtnOpenCostomerListWin.Click += new System.EventHandler(this.BtnOpenCostomerListWin_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 171);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 279);
            this.mainPanel.TabIndex = 1;
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.kryptonRibbon1);
            this.Name = "mainWin";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private Krypton.Ribbon.KryptonRibbonTab customerTab;
        private Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private Krypton.Ribbon.KryptonRibbonGroupButton btnOpenCustWin;
        private Krypton.Ribbon.KryptonRibbonGroupButton krRGBopenUpdateWin;
        private Krypton.Ribbon.KryptonRibbonGroupButton BtnOpenCostomerListWin;
        private System.Windows.Forms.Panel mainPanel;
        private Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
    }
}

