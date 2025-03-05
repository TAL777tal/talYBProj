namespace talYBProj.Forms
{
    partial class addPack
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
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.notesTBX = new Krypton.Toolkit.KryptonRichTextBox();
            this.addButton = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.CBXcostumer = new System.Windows.Forms.ComboBox();
            this.CBXzan = new System.Windows.Forms.ComboBox();
            this.CBXuser = new System.Windows.Forms.ComboBox();
            this.CBXweight = new System.Windows.Forms.ComboBox();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(625, 150);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "משקל";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(628, 283);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "הערות";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(371, 26);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(84, 20);
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "הוספת חבילה";
            // 
            // notesTBX
            // 
            this.notesTBX.Location = new System.Drawing.Point(439, 283);
            this.notesTBX.Name = "notesTBX";
            this.notesTBX.Size = new System.Drawing.Size(161, 104);
            this.notesTBX.TabIndex = 5;
            this.notesTBX.Text = "";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(360, 416);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 33);
            this.addButton.TabIndex = 8;
            this.addButton.Values.Text = "הוספה";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(625, 73);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel5.TabIndex = 9;
            this.kryptonLabel5.Values.Text = "שם הצרכן";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(625, 198);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(80, 20);
            this.kryptonLabel6.TabIndex = 10;
            this.kryptonLabel6.Values.Text = "התאריך היום";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(625, 242);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(85, 20);
            this.kryptonLabel7.TabIndex = 11;
            this.kryptonLabel7.Values.Text = "שם המשתמש";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(625, 109);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(47, 20);
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "סוג הזן";
            // 
            // CBXcostumer
            // 
            this.CBXcostumer.FormattingEnabled = true;
            this.CBXcostumer.Location = new System.Drawing.Point(479, 73);
            this.CBXcostumer.Name = "CBXcostumer";
            this.CBXcostumer.Size = new System.Drawing.Size(121, 21);
            this.CBXcostumer.TabIndex = 13;
            // 
            // CBXzan
            // 
            this.CBXzan.FormattingEnabled = true;
            this.CBXzan.Location = new System.Drawing.Point(479, 109);
            this.CBXzan.Name = "CBXzan";
            this.CBXzan.Size = new System.Drawing.Size(121, 21);
            this.CBXzan.TabIndex = 14;
            // 
            // CBXuser
            // 
            this.CBXuser.FormattingEnabled = true;
            this.CBXuser.Location = new System.Drawing.Point(479, 242);
            this.CBXuser.Name = "CBXuser";
            this.CBXuser.Size = new System.Drawing.Size(121, 21);
            this.CBXuser.TabIndex = 15;
            // 
            // CBXweight
            // 
            this.CBXweight.FormattingEnabled = true;
            this.CBXweight.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5",
            "10",
            "15",
            "20"});
            this.CBXweight.Location = new System.Drawing.Point(479, 150);
            this.CBXweight.Name = "CBXweight";
            this.CBXweight.Size = new System.Drawing.Size(121, 21);
            this.CBXweight.TabIndex = 16;
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(400, 198);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(200, 20);
            this.DTP.TabIndex = 17;
            // 
            // addPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.CBXweight);
            this.Controls.Add(this.CBXuser);
            this.Controls.Add(this.CBXzan);
            this.Controls.Add(this.CBXcostumer);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.notesTBX);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "addPack";
            this.Text = "addPack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonRichTextBox notesTBX;
        private Krypton.Toolkit.KryptonButton addButton;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.ComboBox CBXcostumer;
        private System.Windows.Forms.ComboBox CBXzan;
        private System.Windows.Forms.ComboBox CBXuser;
        private System.Windows.Forms.ComboBox CBXweight;
        private System.Windows.Forms.DateTimePicker DTP;
    }
}