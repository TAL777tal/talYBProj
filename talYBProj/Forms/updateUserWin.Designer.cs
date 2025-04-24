namespace talYBProj.Forms
{
    partial class updateUserWin
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
            this.MTXphoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.TBXgmail = new Krypton.Toolkit.KryptonTextBox();
            this.TBXlastName = new Krypton.Toolkit.KryptonTextBox();
            this.TBXfirstName = new Krypton.Toolkit.KryptonTextBox();
            this.addBTN = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.chooseCBX = new Krypton.Toolkit.KryptonComboBox();
            this.userTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chooseCBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // MTXphoneNumber
            // 
            this.MTXphoneNumber.Location = new System.Drawing.Point(725, 383);
            this.MTXphoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.MTXphoneNumber.Mask = "(999) 000-0000";
            this.MTXphoneNumber.Name = "MTXphoneNumber";
            this.MTXphoneNumber.Size = new System.Drawing.Size(132, 22);
            this.MTXphoneNumber.TabIndex = 20;
            // 
            // TBXgmail
            // 
            this.TBXgmail.Location = new System.Drawing.Point(724, 310);
            this.TBXgmail.Margin = new System.Windows.Forms.Padding(4);
            this.TBXgmail.Name = "TBXgmail";
            this.TBXgmail.Size = new System.Drawing.Size(133, 27);
            this.TBXgmail.TabIndex = 19;
            // 
            // TBXlastName
            // 
            this.TBXlastName.Location = new System.Drawing.Point(724, 236);
            this.TBXlastName.Margin = new System.Windows.Forms.Padding(4);
            this.TBXlastName.Name = "TBXlastName";
            this.TBXlastName.Size = new System.Drawing.Size(133, 27);
            this.TBXlastName.TabIndex = 18;
            // 
            // TBXfirstName
            // 
            this.TBXfirstName.Location = new System.Drawing.Point(724, 171);
            this.TBXfirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TBXfirstName.Name = "TBXfirstName";
            this.TBXfirstName.Size = new System.Drawing.Size(133, 27);
            this.TBXfirstName.TabIndex = 17;
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(475, 457);
            this.addBTN.Margin = new System.Windows.Forms.Padding(4);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(204, 53);
            this.addBTN.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addBTN.TabIndex = 16;
            this.addBTN.Values.Text = "עדכן";
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(902, 383);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(78, 19);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kryptonLabel5.TabIndex = 15;
            this.kryptonLabel5.Values.Text = "מספר טלפון";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(924, 294);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(56, 24);
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "אימייל";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(559, 49);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(85, 19);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "עדכן משתמש";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(886, 239);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(94, 24);
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "שם משפחה";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(906, 171);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(74, 24);
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "שם פרטי";
            // 
            // chooseCBX
            // 
            this.chooseCBX.DataSource = this.userTBLBindingSource;
            this.chooseCBX.DisplayMember = "fullName";
            this.chooseCBX.DropDownWidth = 121;
            this.chooseCBX.IntegralHeight = false;
            this.chooseCBX.Location = new System.Drawing.Point(508, 94);
            this.chooseCBX.Margin = new System.Windows.Forms.Padding(4);
            this.chooseCBX.Name = "chooseCBX";
            this.chooseCBX.Size = new System.Drawing.Size(161, 26);
            this.chooseCBX.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.chooseCBX.TabIndex = 22;
            this.chooseCBX.SelectedIndexChanged += new System.EventHandler(this.chooseCBX_SelectedIndexChanged_1);
            // 
            // userTBLBindingSource
            // 
            this.userTBLBindingSource.DataSource = typeof(talYBProj.userTBL);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // updateUserWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.chooseCBX);
            this.Controls.Add(this.MTXphoneNumber);
            this.Controls.Add(this.TBXgmail);
            this.Controls.Add(this.TBXlastName);
            this.Controls.Add(this.TBXfirstName);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "updateUserWin";
            this.Text = "apdateUserWin";
            this.Load += new System.EventHandler(this.apdateUserWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chooseCBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MTXphoneNumber;
        private Krypton.Toolkit.KryptonTextBox TBXgmail;
        private Krypton.Toolkit.KryptonTextBox TBXlastName;
        private Krypton.Toolkit.KryptonTextBox TBXfirstName;
        private Krypton.Toolkit.KryptonButton addBTN;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.BindingSource userTBLBindingSource;
        private Krypton.Toolkit.KryptonComboBox chooseCBX;
        private System.Windows.Forms.ErrorProvider ep;
    }
}