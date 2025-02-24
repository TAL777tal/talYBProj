namespace talYBProj.Forms
{
    partial class updateCostomerWin
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
            this.updatePanel = new System.Windows.Forms.Panel();
            this.kLabelChose = new Krypton.Toolkit.KryptonLabel();
            this.kCBXchose = new Krypton.Toolkit.KryptonComboBox();
            this.kBtnUpdate = new Krypton.Toolkit.KryptonButton();
            this.MTBXprice = new System.Windows.Forms.MaskedTextBox();
            this.MTBOfficephone = new System.Windows.Forms.MaskedTextBox();
            this.MTBphone2 = new System.Windows.Forms.MaskedTextBox();
            this.MTBphone1 = new System.Windows.Forms.MaskedTextBox();
            this.kRTBXNotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.kTBXEmail = new Krypton.Toolkit.KryptonTextBox();
            this.kTBXAddress = new Krypton.Toolkit.KryptonTextBox();
            this.kTBXCompanyName = new Krypton.Toolkit.KryptonTextBox();
            this.kTBXLastName = new Krypton.Toolkit.KryptonTextBox();
            this.kTBXFirstName = new Krypton.Toolkit.KryptonTextBox();
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
            this.costomerTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCBXchose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomerTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.kLabelChose);
            this.updatePanel.Controls.Add(this.kCBXchose);
            this.updatePanel.Controls.Add(this.kBtnUpdate);
            this.updatePanel.Controls.Add(this.MTBXprice);
            this.updatePanel.Controls.Add(this.MTBOfficephone);
            this.updatePanel.Controls.Add(this.MTBphone2);
            this.updatePanel.Controls.Add(this.MTBphone1);
            this.updatePanel.Controls.Add(this.kRTBXNotes);
            this.updatePanel.Controls.Add(this.kTBXEmail);
            this.updatePanel.Controls.Add(this.kTBXAddress);
            this.updatePanel.Controls.Add(this.kTBXCompanyName);
            this.updatePanel.Controls.Add(this.kTBXLastName);
            this.updatePanel.Controls.Add(this.kTBXFirstName);
            this.updatePanel.Controls.Add(this.kryptonLabel10);
            this.updatePanel.Controls.Add(this.kryptonLabel9);
            this.updatePanel.Controls.Add(this.kryptonLabel8);
            this.updatePanel.Controls.Add(this.kryptonLabel7);
            this.updatePanel.Controls.Add(this.kryptonLabel6);
            this.updatePanel.Controls.Add(this.kryptonLabel5);
            this.updatePanel.Controls.Add(this.kryptonLabel4);
            this.updatePanel.Controls.Add(this.kryptonLabel3);
            this.updatePanel.Controls.Add(this.kryptonLabel2);
            this.updatePanel.Controls.Add(this.kryptonLabel1);
            this.updatePanel.Location = new System.Drawing.Point(0, 0);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(798, 455);
            this.updatePanel.TabIndex = 0;
            // 
            // kLabelChose
            // 
            this.kLabelChose.Location = new System.Drawing.Point(364, 26);
            this.kLabelChose.Name = "kLabelChose";
            this.kLabelChose.Size = new System.Drawing.Size(77, 24);
            this.kLabelChose.TabIndex = 53;
            this.kLabelChose.Values.Text = "בחר לקוח";
            this.kLabelChose.Click += new System.EventHandler(this.kLabelChose_Click);
            // 
            // kCBXchose
            // 
            this.kCBXchose.DataSource = this.costomerTBLBindingSource;
            this.kCBXchose.DisplayMember = "fullName";
            this.kCBXchose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kCBXchose.DropDownWidth = 121;
            this.kCBXchose.IntegralHeight = false;
            this.kCBXchose.Location = new System.Drawing.Point(311, 56);
            this.kCBXchose.Name = "kCBXchose";
            this.kCBXchose.Size = new System.Drawing.Size(200, 26);
            this.kCBXchose.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kCBXchose.TabIndex = 52;
            this.kCBXchose.ValueMember = "Id";
            this.kCBXchose.SelectedIndexChanged += new System.EventHandler(this.kCBXchose_SelectedIndexChanged);
            // 
            // kBtnUpdate
            // 
            this.kBtnUpdate.Location = new System.Drawing.Point(345, 362);
            this.kBtnUpdate.Name = "kBtnUpdate";
            this.kBtnUpdate.Size = new System.Drawing.Size(137, 43);
            this.kBtnUpdate.TabIndex = 51;
            this.kBtnUpdate.Values.Text = "עדכן";
            this.kBtnUpdate.Click += new System.EventHandler(this.kBtnUpdate_Click);
            // 
            // MTBXprice
            // 
            this.MTBXprice.Location = new System.Drawing.Point(101, 159);
            this.MTBXprice.Mask = "00000.00";
            this.MTBXprice.Name = "MTBXprice";
            this.MTBXprice.Size = new System.Drawing.Size(100, 22);
            this.MTBXprice.TabIndex = 50;
            this.MTBXprice.ValidatingType = typeof(int);
            // 
            // MTBOfficephone
            // 
            this.MTBOfficephone.Location = new System.Drawing.Point(101, 88);
            this.MTBOfficephone.Mask = "(999) 000-0000";
            this.MTBOfficephone.Name = "MTBOfficephone";
            this.MTBOfficephone.Size = new System.Drawing.Size(100, 22);
            this.MTBOfficephone.TabIndex = 49;
            // 
            // MTBphone2
            // 
            this.MTBphone2.Location = new System.Drawing.Point(531, 255);
            this.MTBphone2.Mask = "(999) 000-0000";
            this.MTBphone2.Name = "MTBphone2";
            this.MTBphone2.Size = new System.Drawing.Size(100, 22);
            this.MTBphone2.TabIndex = 48;
            // 
            // MTBphone1
            // 
            this.MTBphone1.Location = new System.Drawing.Point(531, 222);
            this.MTBphone1.Mask = "(999) 000-0000";
            this.MTBphone1.Name = "MTBphone1";
            this.MTBphone1.Size = new System.Drawing.Size(100, 22);
            this.MTBphone1.TabIndex = 47;
            // 
            // kRTBXNotes
            // 
            this.kRTBXNotes.Location = new System.Drawing.Point(53, 201);
            this.kRTBXNotes.Name = "kRTBXNotes";
            this.kRTBXNotes.Size = new System.Drawing.Size(148, 142);
            this.kRTBXNotes.TabIndex = 46;
            this.kRTBXNotes.Text = "";
            // 
            // kTBXEmail
            // 
            this.kTBXEmail.Location = new System.Drawing.Point(101, 121);
            this.kTBXEmail.Name = "kTBXEmail";
            this.kTBXEmail.Size = new System.Drawing.Size(100, 27);
            this.kTBXEmail.TabIndex = 45;
            this.kTBXEmail.TextChanged += new System.EventHandler(this.kTBXEmail_TextChanged);
            // 
            // kTBXAddress
            // 
            this.kTBXAddress.Location = new System.Drawing.Point(531, 187);
            this.kTBXAddress.Name = "kTBXAddress";
            this.kTBXAddress.Size = new System.Drawing.Size(100, 27);
            this.kTBXAddress.TabIndex = 44;
            // 
            // kTBXCompanyName
            // 
            this.kTBXCompanyName.Location = new System.Drawing.Point(531, 154);
            this.kTBXCompanyName.Name = "kTBXCompanyName";
            this.kTBXCompanyName.Size = new System.Drawing.Size(100, 27);
            this.kTBXCompanyName.TabIndex = 43;
            // 
            // kTBXLastName
            // 
            this.kTBXLastName.Location = new System.Drawing.Point(531, 121);
            this.kTBXLastName.Name = "kTBXLastName";
            this.kTBXLastName.Size = new System.Drawing.Size(100, 27);
            this.kTBXLastName.TabIndex = 42;
            // 
            // kTBXFirstName
            // 
            this.kTBXFirstName.Location = new System.Drawing.Point(531, 88);
            this.kTBXFirstName.Name = "kTBXFirstName";
            this.kTBXFirstName.Size = new System.Drawing.Size(100, 27);
            this.kTBXFirstName.TabIndex = 41;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(275, 187);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(55, 24);
            this.kryptonLabel10.TabIndex = 40;
            this.kryptonLabel10.Values.Text = "הערות";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(255, 154);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(90, 24);
            this.kryptonLabel9.TabIndex = 39;
            this.kryptonLabel9.Values.Text = "מחיר עסקה";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(277, 121);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(53, 24);
            this.kryptonLabel8.TabIndex = 38;
            this.kryptonLabel8.Values.Text = "אימייל";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(219, 88);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(126, 24);
            this.kryptonLabel7.TabIndex = 37;
            this.kryptonLabel7.Values.Text = "טלפון של המשרד";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(689, 253);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(61, 24);
            this.kryptonLabel6.TabIndex = 36;
            this.kryptonLabel6.Values.Text = "טלפון 2";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(696, 220);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(48, 24);
            this.kryptonLabel5.TabIndex = 35;
            this.kryptonLabel5.Values.Text = "טלפון";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(689, 187);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(55, 24);
            this.kryptonLabel4.TabIndex = 34;
            this.kryptonLabel4.Values.Text = "כתובת";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(673, 154);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(77, 24);
            this.kryptonLabel3.TabIndex = 33;
            this.kryptonLabel3.Values.Text = "שם חברה";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(665, 121);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(91, 24);
            this.kryptonLabel2.TabIndex = 32;
            this.kryptonLabel2.Values.Text = "שם משפחה";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(679, 88);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(71, 24);
            this.kryptonLabel1.TabIndex = 31;
            this.kryptonLabel1.Values.Text = "שם פרטי";
            // 
            // costomerTBLBindingSource
            // 
            // 
            // updateCostomerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updatePanel);
            this.Name = "updateCostomerWin";
            this.Text = "updateCostomerWin";
            this.Load += new System.EventHandler(this.updateCostomerWin_Load);
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kCBXchose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomerTBLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel updatePanel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonRichTextBox kRTBXNotes;
        private Krypton.Toolkit.KryptonTextBox kTBXEmail;
        private Krypton.Toolkit.KryptonTextBox kTBXAddress;
        private Krypton.Toolkit.KryptonTextBox kTBXCompanyName;
        private Krypton.Toolkit.KryptonTextBox kTBXLastName;
        private Krypton.Toolkit.KryptonTextBox kTBXFirstName;
        private System.Windows.Forms.MaskedTextBox MTBOfficephone;
        private System.Windows.Forms.MaskedTextBox MTBphone2;
        private System.Windows.Forms.MaskedTextBox MTBphone1;
        private Krypton.Toolkit.KryptonButton kBtnUpdate;
        private System.Windows.Forms.MaskedTextBox MTBXprice;
        private Krypton.Toolkit.KryptonLabel kLabelChose;
        private Krypton.Toolkit.KryptonComboBox kCBXchose;
        private System.Windows.Forms.BindingSource costomerTBLBindingSource;
    }
}