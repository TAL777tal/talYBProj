namespace talYBProj.Forms
{
    partial class customerWin
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
            this.tabControlAddCostomer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.tabControlAddCostomer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAddCostomer
            // 
            this.tabControlAddCostomer.Controls.Add(this.tabPage1);
            this.tabControlAddCostomer.Controls.Add(this.tabPage2);
            this.tabControlAddCostomer.Location = new System.Drawing.Point(0, 0);
            this.tabControlAddCostomer.Name = "tabControlAddCostomer";
            this.tabControlAddCostomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControlAddCostomer.RightToLeftLayout = true;
            this.tabControlAddCostomer.SelectedIndex = 0;
            this.tabControlAddCostomer.Size = new System.Drawing.Size(810, 466);
            this.tabControlAddCostomer.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "הוסף תלמיד";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addCostumer);
            this.panel2.Controls.Add(this.kTBXPrice);
            this.panel2.Controls.Add(this.MTBXPOffice);
            this.panel2.Controls.Add(this.MTBXPSecend);
            this.panel2.Controls.Add(this.MTBXPFirst);
            this.panel2.Controls.Add(this.kRTBXN);
            this.panel2.Controls.Add(this.kTBXEmail);
            this.panel2.Controls.Add(this.kTBXADD);
            this.panel2.Controls.Add(this.kTBXCN);
            this.panel2.Controls.Add(this.kTBXLN);
            this.panel2.Controls.Add(this.kTBXFN);
            this.panel2.Controls.Add(this.kryptonLabel10);
            this.panel2.Controls.Add(this.kryptonLabel9);
            this.panel2.Controls.Add(this.kryptonLabel8);
            this.panel2.Controls.Add(this.kryptonLabel7);
            this.panel2.Controls.Add(this.kryptonLabel6);
            this.panel2.Controls.Add(this.kryptonLabel5);
            this.panel2.Controls.Add(this.kryptonLabel4);
            this.panel2.Controls.Add(this.kryptonLabel3);
            this.panel2.Controls.Add(this.kryptonLabel2);
            this.panel2.Controls.Add(this.kryptonLabel1);
            this.panel2.Location = new System.Drawing.Point(1, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 417);
            this.panel2.TabIndex = 5;
            // 
            // addCostumer
            // 
            this.addCostumer.Location = new System.Drawing.Point(384, 264);
            this.addCostumer.Name = "addCostumer";
            this.addCostumer.Size = new System.Drawing.Size(90, 25);
            this.addCostumer.TabIndex = 24;
            this.addCostumer.Values.Text = "הוספה";
            // 
            // kTBXPrice
            // 
            this.kTBXPrice.Location = new System.Drawing.Point(155, 78);
            this.kTBXPrice.Mask = "00000.00";
            this.kTBXPrice.Name = "kTBXPrice";
            this.kTBXPrice.Size = new System.Drawing.Size(100, 22);
            this.kTBXPrice.TabIndex = 22;
            this.kTBXPrice.ValidatingType = typeof(int);
            // 
            // MTBXPOffice
            // 
            this.MTBXPOffice.Location = new System.Drawing.Point(155, 17);
            this.MTBXPOffice.Mask = "(999) 000-0000";
            this.MTBXPOffice.Name = "MTBXPOffice";
            this.MTBXPOffice.Size = new System.Drawing.Size(100, 22);
            this.MTBXPOffice.TabIndex = 22;
            // 
            // MTBXPSecend
            // 
            this.MTBXPSecend.Location = new System.Drawing.Point(536, 174);
            this.MTBXPSecend.Mask = "(999) 000-0000";
            this.MTBXPSecend.Name = "MTBXPSecend";
            this.MTBXPSecend.Size = new System.Drawing.Size(100, 22);
            this.MTBXPSecend.TabIndex = 21;
            // 
            // MTBXPFirst
            // 
            this.MTBXPFirst.Location = new System.Drawing.Point(536, 146);
            this.MTBXPFirst.Mask = "(999) 000-0000";
            this.MTBXPFirst.Name = "MTBXPFirst";
            this.MTBXPFirst.Size = new System.Drawing.Size(100, 22);
            this.MTBXPFirst.TabIndex = 20;
            // 
            // kRTBXN
            // 
            this.kRTBXN.Location = new System.Drawing.Point(49, 111);
            this.kRTBXN.Name = "kRTBXN";
            this.kRTBXN.Size = new System.Drawing.Size(206, 165);
            this.kRTBXN.TabIndex = 19;
            this.kRTBXN.Text = "";
            // 
            // kTBXEmail
            // 
            this.kTBXEmail.Location = new System.Drawing.Point(155, 45);
            this.kTBXEmail.Name = "kTBXEmail";
            this.kTBXEmail.Size = new System.Drawing.Size(100, 27);
            this.kTBXEmail.TabIndex = 16;
            // 
            // kTBXADD
            // 
            this.kTBXADD.Location = new System.Drawing.Point(536, 111);
            this.kTBXADD.Name = "kTBXADD";
            this.kTBXADD.Size = new System.Drawing.Size(100, 27);
            this.kTBXADD.TabIndex = 13;
            // 
            // kTBXCN
            // 
            this.kTBXCN.Location = new System.Drawing.Point(536, 78);
            this.kTBXCN.Name = "kTBXCN";
            this.kTBXCN.Size = new System.Drawing.Size(100, 27);
            this.kTBXCN.TabIndex = 12;
            // 
            // kTBXLN
            // 
            this.kTBXLN.Location = new System.Drawing.Point(536, 45);
            this.kTBXLN.Name = "kTBXLN";
            this.kTBXLN.Size = new System.Drawing.Size(100, 27);
            this.kTBXLN.TabIndex = 11;
            // 
            // kTBXFN
            // 
            this.kTBXFN.Location = new System.Drawing.Point(536, 12);
            this.kTBXFN.Name = "kTBXFN";
            this.kTBXFN.Size = new System.Drawing.Size(100, 27);
            this.kTBXFN.TabIndex = 10;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(334, 111);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(55, 24);
            this.kryptonLabel10.TabIndex = 9;
            this.kryptonLabel10.Values.Text = "הערות";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(314, 78);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(90, 24);
            this.kryptonLabel9.TabIndex = 8;
            this.kryptonLabel9.Values.Text = "מחיר עסקה";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(336, 45);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(53, 24);
            this.kryptonLabel8.TabIndex = 7;
            this.kryptonLabel8.Values.Text = "אימייל";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(278, 12);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(126, 24);
            this.kryptonLabel7.TabIndex = 6;
            this.kryptonLabel7.Values.Text = "טלפון של המשרד";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(696, 177);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(61, 24);
            this.kryptonLabel6.TabIndex = 5;
            this.kryptonLabel6.Values.Text = "טלפון 2";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(703, 144);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(48, 24);
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "טלפון";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(696, 111);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(55, 24);
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "כתובת";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(680, 78);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(77, 24);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "שם חברה";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(672, 45);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(91, 24);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "שם משפחה";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(686, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(71, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "שם פרטי";
            // 
            // customerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlAddCostomer);
            this.Name = "customerWin";
            this.Text = "customerWin";
            this.tabControlAddCostomer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAddCostomer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.TabPage tabPage2;
    }
}