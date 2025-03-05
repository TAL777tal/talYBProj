namespace talYBProj.Forms
{
    partial class addUserWin
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
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.addBTN = new Krypton.Toolkit.KryptonButton();
            this.TBXfirstName = new Krypton.Toolkit.KryptonTextBox();
            this.TBXlastName = new Krypton.Toolkit.KryptonTextBox();
            this.TBXgmail = new Krypton.Toolkit.KryptonTextBox();
            this.MTXphoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(657, 82);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "שם פרטי";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(641, 134);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(74, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "שם משפחה";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(374, 41);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(86, 20);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "הוסף משתמש";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(672, 194);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "אימייל";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(640, 252);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "מספר טלפון";
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(374, 345);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(90, 25);
            this.addBTN.TabIndex = 5;
            this.addBTN.Values.Text = "הוספה";
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // TBXfirstName
            // 
            this.TBXfirstName.Location = new System.Drawing.Point(523, 82);
            this.TBXfirstName.Name = "TBXfirstName";
            this.TBXfirstName.Size = new System.Drawing.Size(100, 23);
            this.TBXfirstName.TabIndex = 6;
            // 
            // TBXlastName
            // 
            this.TBXlastName.Location = new System.Drawing.Point(523, 131);
            this.TBXlastName.Name = "TBXlastName";
            this.TBXlastName.Size = new System.Drawing.Size(100, 23);
            this.TBXlastName.TabIndex = 7;
            // 
            // TBXgmail
            // 
            this.TBXgmail.Location = new System.Drawing.Point(523, 194);
            this.TBXgmail.Name = "TBXgmail";
            this.TBXgmail.Size = new System.Drawing.Size(100, 23);
            this.TBXgmail.TabIndex = 8;
            // 
            // MTXphoneNumber
            // 
            this.MTXphoneNumber.Location = new System.Drawing.Point(523, 252);
            this.MTXphoneNumber.Mask = "(999) 000-0000";
            this.MTXphoneNumber.Name = "MTXphoneNumber";
            this.MTXphoneNumber.Size = new System.Drawing.Size(100, 20);
            this.MTXphoneNumber.TabIndex = 10;
            // 
            // addUserWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "addUserWin";
            this.Text = "addUserWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonButton addBTN;
        private Krypton.Toolkit.KryptonTextBox TBXfirstName;
        private Krypton.Toolkit.KryptonTextBox TBXlastName;
        private Krypton.Toolkit.KryptonTextBox TBXgmail;
        private System.Windows.Forms.MaskedTextBox MTXphoneNumber;
    }
}