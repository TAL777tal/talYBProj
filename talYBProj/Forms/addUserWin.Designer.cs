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
            this.components = new System.ComponentModel.Container();
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
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(885, 101);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(59, 19);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "שם פרטי";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(870, 169);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(74, 19);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "שם משפחה";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(513, 44);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(87, 19);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "הוסף משתמש";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(896, 222);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(48, 19);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "אימייל";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(866, 292);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(78, 19);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "מספר טלפון";
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(478, 420);
            this.addBTN.Margin = new System.Windows.Forms.Padding(4);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(159, 61);
            this.addBTN.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addBTN.TabIndex = 5;
            this.addBTN.Values.Text = "הוספה";
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // TBXfirstName
            // 
            this.TBXfirstName.Location = new System.Drawing.Point(697, 101);
            this.TBXfirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TBXfirstName.Name = "TBXfirstName";
            this.TBXfirstName.Size = new System.Drawing.Size(133, 27);
            this.TBXfirstName.TabIndex = 6;
            // 
            // TBXlastName
            // 
            this.TBXlastName.Location = new System.Drawing.Point(697, 161);
            this.TBXlastName.Margin = new System.Windows.Forms.Padding(4);
            this.TBXlastName.Name = "TBXlastName";
            this.TBXlastName.Size = new System.Drawing.Size(133, 27);
            this.TBXlastName.TabIndex = 7;
            // 
            // TBXgmail
            // 
            this.TBXgmail.Location = new System.Drawing.Point(697, 222);
            this.TBXgmail.Margin = new System.Windows.Forms.Padding(4);
            this.TBXgmail.Name = "TBXgmail";
            this.TBXgmail.Size = new System.Drawing.Size(133, 27);
            this.TBXgmail.TabIndex = 8;
            // 
            // MTXphoneNumber
            // 
            this.MTXphoneNumber.Location = new System.Drawing.Point(698, 289);
            this.MTXphoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.MTXphoneNumber.Mask = "(999) 000-0000";
            this.MTXphoneNumber.Name = "MTXphoneNumber";
            this.MTXphoneNumber.Size = new System.Drawing.Size(132, 22);
            this.MTXphoneNumber.TabIndex = 10;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // addUserWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Name = "addUserWin";
            this.Text = "addUserWin";
            this.Load += new System.EventHandler(this.addUserWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
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
        private System.Windows.Forms.ErrorProvider ep;
    }
}