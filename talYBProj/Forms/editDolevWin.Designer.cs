namespace talYBProj.Forms
{
    partial class editDolevWin
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
            this.updateDolev = new Krypton.Toolkit.KryptonButton();
            this.dateTimeP = new System.Windows.Forms.DateTimePicker();
            this.txbNotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.cbxDolevNum = new System.Windows.Forms.ComboBox();
            this.numericUpDownBruto = new System.Windows.Forms.NumericUpDown();
            this.cbxUserName = new System.Windows.Forms.ComboBox();
            this.userTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxOrderId = new System.Windows.Forms.ComboBox();
            this.orderTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelUserName = new Krypton.Toolkit.KryptonLabel();
            this.LabelNotes = new Krypton.Toolkit.KryptonLabel();
            this.LabelBruto = new Krypton.Toolkit.KryptonLabel();
            this.LabelCurDate = new Krypton.Toolkit.KryptonLabel();
            this.LabelDolevNum = new Krypton.Toolkit.KryptonLabel();
            this.LabelOrderId = new Krypton.Toolkit.KryptonLabel();
            this.choseLabel = new Krypton.Toolkit.KryptonLabel();
            this.cbxchose = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateDolev
            // 
            this.updateDolev.Location = new System.Drawing.Point(333, 388);
            this.updateDolev.Name = "updateDolev";
            this.updateDolev.Size = new System.Drawing.Size(90, 25);
            this.updateDolev.TabIndex = 32;
            this.updateDolev.Values.Text = "עדכן דולב";
            this.updateDolev.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // dateTimeP
            // 
            this.dateTimeP.Location = new System.Drawing.Point(440, 123);
            this.dateTimeP.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeP.Name = "dateTimeP";
            this.dateTimeP.Size = new System.Drawing.Size(151, 20);
            this.dateTimeP.TabIndex = 31;
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(440, 243);
            this.txbNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(153, 93);
            this.txbNotes.TabIndex = 29;
            this.txbNotes.Text = "";
            // 
            // cbxDolevNum
            // 
            this.cbxDolevNum.FormattingEnabled = true;
            this.cbxDolevNum.Location = new System.Drawing.Point(499, 87);
            this.cbxDolevNum.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDolevNum.Name = "cbxDolevNum";
            this.cbxDolevNum.Size = new System.Drawing.Size(92, 21);
            this.cbxDolevNum.TabIndex = 28;
            // 
            // numericUpDownBruto
            // 
            this.numericUpDownBruto.Location = new System.Drawing.Point(501, 163);
            this.numericUpDownBruto.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBruto.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownBruto.Name = "numericUpDownBruto";
            this.numericUpDownBruto.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownBruto.TabIndex = 27;
            // 
            // cbxUserName
            // 
            this.cbxUserName.DataSource = this.userTBLBindingSource;
            this.cbxUserName.DisplayMember = "fullName";
            this.cbxUserName.FormattingEnabled = true;
            this.cbxUserName.Location = new System.Drawing.Point(497, 205);
            this.cbxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.cbxUserName.Name = "cbxUserName";
            this.cbxUserName.Size = new System.Drawing.Size(92, 21);
            this.cbxUserName.TabIndex = 26;
            // 
            // userTBLBindingSource
            // 
            this.userTBLBindingSource.DataSource = typeof(talYBProj.userTBL);
            // 
            // cbxOrderId
            // 
            this.cbxOrderId.DataSource = this.orderTBLBindingSource;
            this.cbxOrderId.DisplayMember = "Id";
            this.cbxOrderId.FormattingEnabled = true;
            this.cbxOrderId.Location = new System.Drawing.Point(499, 45);
            this.cbxOrderId.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOrderId.Name = "cbxOrderId";
            this.cbxOrderId.Size = new System.Drawing.Size(92, 21);
            this.cbxOrderId.TabIndex = 25;
            // 
            // orderTBLBindingSource
            // 
            this.orderTBLBindingSource.DataSource = typeof(talYBProj.orderTBL);
            // 
            // LabelUserName
            // 
            this.LabelUserName.Location = new System.Drawing.Point(632, 206);
            this.LabelUserName.Margin = new System.Windows.Forms.Padding(2);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(105, 24);
            this.LabelUserName.TabIndex = 24;
            this.LabelUserName.Values.Text = "שם המשתמש";
            // 
            // LabelNotes
            // 
            this.LabelNotes.Location = new System.Drawing.Point(632, 243);
            this.LabelNotes.Margin = new System.Windows.Forms.Padding(2);
            this.LabelNotes.Name = "LabelNotes";
            this.LabelNotes.Size = new System.Drawing.Size(55, 24);
            this.LabelNotes.TabIndex = 23;
            this.LabelNotes.Values.Text = "הערות";
            // 
            // LabelBruto
            // 
            this.LabelBruto.Location = new System.Drawing.Point(632, 163);
            this.LabelBruto.Margin = new System.Windows.Forms.Padding(2);
            this.LabelBruto.Name = "LabelBruto";
            this.LabelBruto.Size = new System.Drawing.Size(95, 24);
            this.LabelBruto.TabIndex = 21;
            this.LabelBruto.Values.Text = "משקל-ברוטו";
            // 
            // LabelCurDate
            // 
            this.LabelCurDate.Location = new System.Drawing.Point(632, 123);
            this.LabelCurDate.Margin = new System.Windows.Forms.Padding(2);
            this.LabelCurDate.Name = "LabelCurDate";
            this.LabelCurDate.Size = new System.Drawing.Size(112, 24);
            this.LabelCurDate.TabIndex = 20;
            this.LabelCurDate.Values.Text = "התאריך הנוכחי";
            // 
            // LabelDolevNum
            // 
            this.LabelDolevNum.Location = new System.Drawing.Point(632, 87);
            this.LabelDolevNum.Margin = new System.Windows.Forms.Padding(2);
            this.LabelDolevNum.Name = "LabelDolevNum";
            this.LabelDolevNum.Size = new System.Drawing.Size(94, 24);
            this.LabelDolevNum.TabIndex = 19;
            this.LabelDolevNum.Values.Text = "מספר הדולב";
            // 
            // LabelOrderId
            // 
            this.LabelOrderId.Location = new System.Drawing.Point(632, 45);
            this.LabelOrderId.Margin = new System.Windows.Forms.Padding(2);
            this.LabelOrderId.Name = "LabelOrderId";
            this.LabelOrderId.Size = new System.Drawing.Size(108, 24);
            this.LabelOrderId.TabIndex = 18;
            this.LabelOrderId.Values.Text = "מספר ההזמנה";
            // 
            // choseLabel
            // 
            this.choseLabel.Location = new System.Drawing.Point(497, 12);
            this.choseLabel.Name = "choseLabel";
            this.choseLabel.Size = new System.Drawing.Size(72, 24);
            this.choseLabel.TabIndex = 34;
            this.choseLabel.Values.Text = "בחר דולב";
            // 
            // cbxchose
            // 
            this.cbxchose.FormattingEnabled = true;
            this.cbxchose.Location = new System.Drawing.Point(355, 11);
            this.cbxchose.Name = "cbxchose";
            this.cbxchose.Size = new System.Drawing.Size(121, 21);
            this.cbxchose.TabIndex = 35;
            this.cbxchose.SelectedIndexChanged += new System.EventHandler(this.cbxchose_SelectedIndexChanged);
            // 
            // editDolevWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxchose);
            this.Controls.Add(this.choseLabel);
            this.Controls.Add(this.updateDolev);
            this.Controls.Add(this.dateTimeP);
            this.Controls.Add(this.txbNotes);
            this.Controls.Add(this.cbxDolevNum);
            this.Controls.Add(this.numericUpDownBruto);
            this.Controls.Add(this.cbxUserName);
            this.Controls.Add(this.cbxOrderId);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.LabelNotes);
            this.Controls.Add(this.LabelBruto);
            this.Controls.Add(this.LabelCurDate);
            this.Controls.Add(this.LabelDolevNum);
            this.Controls.Add(this.LabelOrderId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editDolevWin";
            this.Text = "editDolev";
            this.Load += new System.EventHandler(this.editDolevWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton updateDolev;
        private System.Windows.Forms.DateTimePicker dateTimeP;
        private Krypton.Toolkit.KryptonRichTextBox txbNotes;
        private System.Windows.Forms.ComboBox cbxDolevNum;
        private System.Windows.Forms.NumericUpDown numericUpDownBruto;
        private System.Windows.Forms.ComboBox cbxUserName;
        private System.Windows.Forms.ComboBox cbxOrderId;
        private Krypton.Toolkit.KryptonLabel LabelUserName;
        private Krypton.Toolkit.KryptonLabel LabelNotes;
        private Krypton.Toolkit.KryptonLabel LabelBruto;
        private Krypton.Toolkit.KryptonLabel LabelCurDate;
        private Krypton.Toolkit.KryptonLabel LabelDolevNum;
        private Krypton.Toolkit.KryptonLabel LabelOrderId;
        private Krypton.Toolkit.KryptonLabel choseLabel;
        private System.Windows.Forms.ComboBox cbxchose;
        private System.Windows.Forms.BindingSource userTBLBindingSource;
        private System.Windows.Forms.BindingSource orderTBLBindingSource;
    }
}