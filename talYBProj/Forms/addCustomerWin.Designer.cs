namespace talYBProj.Forms
{
    partial class addCustomerWin
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
            this.addPanel = new System.Windows.Forms.Panel();
            this.addCostumer = new Krypton.Toolkit.KryptonButton();
            this.kTBXPrice = new System.Windows.Forms.MaskedTextBox();
            this.MTBXPOffice = new System.Windows.Forms.MaskedTextBox();
            this.MTBXPSecend = new System.Windows.Forms.MaskedTextBox();
            this.MTBXPFirst = new System.Windows.Forms.MaskedTextBox();
            this.kRTBXN = new Krypton.Toolkit.KryptonRichTextBox();
            this.kTBXEmail = new Krypton.Toolkit.KryptonTextBox();
            this.kTBXADD = new Krypton.Toolkit.KryptonTextBox();
            this.kTBXCN = new Krypton.Toolkit.KryptonTextBox();
            this.kTBXLN = new Krypton.Toolkit.KryptonTextBox();
            this.kTBXFN = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.kryptonLabel11);
            this.addPanel.Controls.Add(this.addCostumer);
            this.addPanel.Controls.Add(this.kTBXPrice);
            this.addPanel.Controls.Add(this.MTBXPOffice);
            this.addPanel.Controls.Add(this.MTBXPSecend);
            this.addPanel.Controls.Add(this.MTBXPFirst);
            this.addPanel.Controls.Add(this.kRTBXN);
            this.addPanel.Controls.Add(this.kTBXEmail);
            this.addPanel.Controls.Add(this.kTBXADD);
            this.addPanel.Controls.Add(this.kTBXCN);
            this.addPanel.Controls.Add(this.kTBXLN);
            this.addPanel.Controls.Add(this.kTBXFN);
            this.addPanel.Controls.Add(this.kryptonLabel10);
            this.addPanel.Controls.Add(this.kryptonLabel9);
            this.addPanel.Controls.Add(this.kryptonLabel8);
            this.addPanel.Controls.Add(this.kryptonLabel7);
            this.addPanel.Controls.Add(this.kryptonLabel6);
            this.addPanel.Controls.Add(this.kryptonLabel5);
            this.addPanel.Controls.Add(this.kryptonLabel4);
            this.addPanel.Controls.Add(this.kryptonLabel3);
            this.addPanel.Controls.Add(this.kryptonLabel2);
            this.addPanel.Controls.Add(this.kryptonLabel1);
            this.addPanel.Location = new System.Drawing.Point(64, 38);
            this.addPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(599, 356);
            this.addPanel.TabIndex = 0;
            // 
            // addCostumer
            // 
            this.addCostumer.Location = new System.Drawing.Point(283, 271);
            this.addCostumer.Margin = new System.Windows.Forms.Padding(2);
            this.addCostumer.Name = "addCostumer";
            this.addCostumer.Size = new System.Drawing.Size(68, 20);
            this.addCostumer.TabIndex = 11;
            this.addCostumer.Values.Text = "הוספה";
            this.addCostumer.Click += new System.EventHandler(this.addCostumer_Click);
            // 
            // kTBXPrice
            // 
            this.kTBXPrice.Location = new System.Drawing.Point(111, 119);
            this.kTBXPrice.Margin = new System.Windows.Forms.Padding(2);
            this.kTBXPrice.Mask = "00000.00";
            this.kTBXPrice.Name = "kTBXPrice";
            this.kTBXPrice.Size = new System.Drawing.Size(76, 20);
            this.kTBXPrice.TabIndex = 9;
            this.kTBXPrice.ValidatingType = typeof(int);
            // 
            // MTBXPOffice
            // 
            this.MTBXPOffice.Location = new System.Drawing.Point(111, 70);
            this.MTBXPOffice.Margin = new System.Windows.Forms.Padding(2);
            this.MTBXPOffice.Mask = "(999) 000-0000";
            this.MTBXPOffice.Name = "MTBXPOffice";
            this.MTBXPOffice.Size = new System.Drawing.Size(76, 20);
            this.MTBXPOffice.TabIndex = 7;
            // 
            // MTBXPSecend
            // 
            this.MTBXPSecend.Location = new System.Drawing.Point(397, 197);
            this.MTBXPSecend.Margin = new System.Windows.Forms.Padding(2);
            this.MTBXPSecend.Mask = "(999) 000-0000";
            this.MTBXPSecend.Name = "MTBXPSecend";
            this.MTBXPSecend.Size = new System.Drawing.Size(76, 20);
            this.MTBXPSecend.TabIndex = 6;
            // 
            // MTBXPFirst
            // 
            this.MTBXPFirst.Location = new System.Drawing.Point(397, 175);
            this.MTBXPFirst.Margin = new System.Windows.Forms.Padding(2);
            this.MTBXPFirst.Mask = "(999) 000-0000";
            this.MTBXPFirst.Name = "MTBXPFirst";
            this.MTBXPFirst.Size = new System.Drawing.Size(76, 20);
            this.MTBXPFirst.TabIndex = 5;
            // 
            // kRTBXN
            // 
            this.kRTBXN.Location = new System.Drawing.Point(32, 146);
            this.kRTBXN.Margin = new System.Windows.Forms.Padding(2);
            this.kRTBXN.Name = "kRTBXN";
            this.kRTBXN.Size = new System.Drawing.Size(154, 134);
            this.kRTBXN.TabIndex = 10;
            this.kRTBXN.Text = "";
            // 
            // kTBXEmail
            // 
            this.kTBXEmail.Location = new System.Drawing.Point(111, 93);
            this.kTBXEmail.Margin = new System.Windows.Forms.Padding(2);
            this.kTBXEmail.Name = "kTBXEmail";
            this.kTBXEmail.Size = new System.Drawing.Size(75, 23);
            this.kTBXEmail.TabIndex = 8;
            // 
            // kTBXADD
            // 
            this.kTBXADD.Location = new System.Drawing.Point(397, 146);
            this.kTBXADD.Margin = new System.Windows.Forms.Padding(2);
            this.kTBXADD.Name = "kTBXADD";
            this.kTBXADD.Size = new System.Drawing.Size(75, 23);
            this.kTBXADD.TabIndex = 4;
            // 
            // kTBXCN
            // 
            this.kTBXCN.Location = new System.Drawing.Point(397, 119);
            this.kTBXCN.Margin = new System.Windows.Forms.Padding(2);
            this.kTBXCN.Name = "kTBXCN";
            this.kTBXCN.Size = new System.Drawing.Size(75, 23);
            this.kTBXCN.TabIndex = 3;
            // 
            // kTBXLN
            // 
            this.kTBXLN.Location = new System.Drawing.Point(397, 93);
            this.kTBXLN.Margin = new System.Windows.Forms.Padding(2);
            this.kTBXLN.Name = "kTBXLN";
            this.kTBXLN.Size = new System.Drawing.Size(75, 23);
            this.kTBXLN.TabIndex = 2;
            // 
            // kTBXFN
            // 
            this.kTBXFN.Location = new System.Drawing.Point(397, 66);
            this.kTBXFN.Margin = new System.Windows.Forms.Padding(2);
            this.kTBXFN.Name = "kTBXFN";
            this.kTBXFN.Size = new System.Drawing.Size(75, 23);
            this.kTBXFN.TabIndex = 1;
            this.kTBXFN.TextChanged += new System.EventHandler(this.kTBXFN_TextChanged);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(245, 146);
            this.kryptonLabel10.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel10.TabIndex = 34;
            this.kryptonLabel10.Values.Text = "הערות";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(230, 119);
            this.kryptonLabel9.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel9.TabIndex = 33;
            this.kryptonLabel9.Values.Text = "מחיר עסקה";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(247, 93);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel8.TabIndex = 32;
            this.kryptonLabel8.Values.Text = "אימייל";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(203, 66);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(102, 20);
            this.kryptonLabel7.TabIndex = 31;
            this.kryptonLabel7.Values.Text = "טלפון של המשרד";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(517, 200);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel6.TabIndex = 30;
            this.kryptonLabel6.Values.Text = "טלפון 2";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(522, 173);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel5.TabIndex = 29;
            this.kryptonLabel5.Values.Text = "טלפון";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(517, 146);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel4.TabIndex = 28;
            this.kryptonLabel4.Values.Text = "כתובת";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(505, 119);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(63, 20);
            this.kryptonLabel3.TabIndex = 27;
            this.kryptonLabel3.Values.Text = "שם חברה";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(499, 93);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel2.TabIndex = 26;
            this.kryptonLabel2.Values.Text = "שם משפחה";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(509, 66);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel1.TabIndex = 25;
            this.kryptonLabel1.Values.Text = "שם פרטי";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(268, 15);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(68, 20);
            this.kryptonLabel11.TabIndex = 35;
            this.kryptonLabel11.Values.Text = "הוסף לקוח";
            // 
            // addCustomerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 443);
            this.Controls.Add(this.addPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addCustomerWin";
            this.Text = "customerWin";
            this.Load += new System.EventHandler(this.addCustomerWin_Load);
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPanel;
        private Krypton.Toolkit.KryptonButton addCostumer;
        private System.Windows.Forms.MaskedTextBox kTBXPrice;
        private System.Windows.Forms.MaskedTextBox MTBXPOffice;
        private System.Windows.Forms.MaskedTextBox MTBXPSecend;
        private System.Windows.Forms.MaskedTextBox MTBXPFirst;
        private Krypton.Toolkit.KryptonRichTextBox kRTBXN;
        private Krypton.Toolkit.KryptonTextBox kTBXEmail;
        private Krypton.Toolkit.KryptonTextBox kTBXADD;
        private Krypton.Toolkit.KryptonTextBox kTBXCN;
        private Krypton.Toolkit.KryptonTextBox kTBXLN;
        private Krypton.Toolkit.KryptonTextBox kTBXFN;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
    }
}