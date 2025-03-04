namespace talYBProj.Forms
{
    partial class updateDolevWin
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
            this.LabelOrderId = new Krypton.Toolkit.KryptonLabel();
            this.LabelDolevNum = new Krypton.Toolkit.KryptonLabel();
            this.LabelCurDate = new Krypton.Toolkit.KryptonLabel();
            this.LabelBruto = new Krypton.Toolkit.KryptonLabel();
            this.LabelNotes = new Krypton.Toolkit.KryptonLabel();
            this.LabelUserName = new Krypton.Toolkit.KryptonLabel();
            this.cbxOrderId = new System.Windows.Forms.ComboBox();
            this.cbxUserName = new System.Windows.Forms.ComboBox();
            this.numericUpDownBruto = new System.Windows.Forms.NumericUpDown();
            this.cbxDolevNum = new System.Windows.Forms.ComboBox();
            this.txbNotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.dateTimeP = new System.Windows.Forms.DateTimePicker();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBruto)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelOrderId
            // 
            this.LabelOrderId.Location = new System.Drawing.Point(468, 23);
            this.LabelOrderId.Margin = new System.Windows.Forms.Padding(2);
            this.LabelOrderId.Name = "LabelOrderId";
            this.LabelOrderId.Size = new System.Drawing.Size(88, 20);
            this.LabelOrderId.TabIndex = 0;
            this.LabelOrderId.Values.Text = "מספר ההזמנה";
            // 
            // LabelDolevNum
            // 
            this.LabelDolevNum.Location = new System.Drawing.Point(468, 66);
            this.LabelDolevNum.Margin = new System.Windows.Forms.Padding(2);
            this.LabelDolevNum.Name = "LabelDolevNum";
            this.LabelDolevNum.Size = new System.Drawing.Size(76, 20);
            this.LabelDolevNum.TabIndex = 2;
            this.LabelDolevNum.Values.Text = "מספר הדולב";
            // 
            // LabelCurDate
            // 
            this.LabelCurDate.Location = new System.Drawing.Point(465, 102);
            this.LabelCurDate.Margin = new System.Windows.Forms.Padding(2);
            this.LabelCurDate.Name = "LabelCurDate";
            this.LabelCurDate.Size = new System.Drawing.Size(91, 20);
            this.LabelCurDate.TabIndex = 3;
            this.LabelCurDate.Values.Text = "התאריך הנוכחי";
            this.LabelCurDate.Click += new System.EventHandler(this.kryptonLabel4_Click);
            // 
            // LabelBruto
            // 
            this.LabelBruto.Location = new System.Drawing.Point(468, 142);
            this.LabelBruto.Margin = new System.Windows.Forms.Padding(2);
            this.LabelBruto.Name = "LabelBruto";
            this.LabelBruto.Size = new System.Drawing.Size(77, 20);
            this.LabelBruto.TabIndex = 4;
            this.LabelBruto.Values.Text = "משקל-ברוטו";
            // 
            // LabelNotes
            // 
            this.LabelNotes.Location = new System.Drawing.Point(468, 243);
            this.LabelNotes.Margin = new System.Windows.Forms.Padding(2);
            this.LabelNotes.Name = "LabelNotes";
            this.LabelNotes.Size = new System.Drawing.Size(46, 20);
            this.LabelNotes.TabIndex = 6;
            this.LabelNotes.Values.Text = "הערות";
            // 
            // LabelUserName
            // 
            this.LabelUserName.Location = new System.Drawing.Point(468, 196);
            this.LabelUserName.Margin = new System.Windows.Forms.Padding(2);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(85, 20);
            this.LabelUserName.TabIndex = 7;
            this.LabelUserName.Values.Text = "שם המשתמש";
            // 
            // cbxOrderId
            // 
            this.cbxOrderId.FormattingEnabled = true;
            this.cbxOrderId.Location = new System.Drawing.Point(330, 23);
            this.cbxOrderId.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOrderId.Name = "cbxOrderId";
            this.cbxOrderId.Size = new System.Drawing.Size(92, 21);
            this.cbxOrderId.TabIndex = 8;
            this.cbxOrderId.SelectedIndexChanged += new System.EventHandler(this.cbxNameCust_SelectedIndexChanged);
            // 
            // cbxUserName
            // 
            this.cbxUserName.FormattingEnabled = true;
            this.cbxUserName.Location = new System.Drawing.Point(330, 196);
            this.cbxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.cbxUserName.Name = "cbxUserName";
            this.cbxUserName.Size = new System.Drawing.Size(92, 21);
            this.cbxUserName.TabIndex = 10;
            // 
            // numericUpDownBruto
            // 
            this.numericUpDownBruto.Location = new System.Drawing.Point(334, 142);
            this.numericUpDownBruto.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownBruto.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownBruto.Name = "numericUpDownBruto";
            this.numericUpDownBruto.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownBruto.TabIndex = 11;
            // 
            // cbxDolevNum
            // 
            this.cbxDolevNum.FormattingEnabled = true;
            this.cbxDolevNum.Location = new System.Drawing.Point(330, 65);
            this.cbxDolevNum.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDolevNum.Name = "cbxDolevNum";
            this.cbxDolevNum.Size = new System.Drawing.Size(92, 21);
            this.cbxDolevNum.TabIndex = 13;
            this.cbxDolevNum.SelectedIndexChanged += new System.EventHandler(this.cbxDolevNum_SelectedIndexChanged);
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(273, 243);
            this.txbNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(153, 93);
            this.txbNotes.TabIndex = 14;
            this.txbNotes.Text = "";
            // 
            // dateTimeP
            // 
            this.dateTimeP.Location = new System.Drawing.Point(273, 102);
            this.dateTimeP.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeP.Name = "dateTimeP";
            this.dateTimeP.Size = new System.Drawing.Size(151, 20);
            this.dateTimeP.TabIndex = 16;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(223, 369);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton1.TabIndex = 17;
            this.kryptonButton1.Values.Text = "עצב דולב";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // updateDolevWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 406);
            this.Controls.Add(this.kryptonButton1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "updateDolevWin";
            this.Text = "updateDolev";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBruto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel LabelOrderId;
        private Krypton.Toolkit.KryptonLabel LabelDolevNum;
        private Krypton.Toolkit.KryptonLabel LabelCurDate;
        private Krypton.Toolkit.KryptonLabel LabelBruto;
        private Krypton.Toolkit.KryptonLabel LabelNotes;
        private Krypton.Toolkit.KryptonLabel LabelUserName;
        private System.Windows.Forms.ComboBox cbxOrderId;
        private System.Windows.Forms.ComboBox cbxUserName;
        private System.Windows.Forms.NumericUpDown numericUpDownBruto;
        private System.Windows.Forms.ComboBox cbxDolevNum;
        private Krypton.Toolkit.KryptonRichTextBox txbNotes;
        private System.Windows.Forms.DateTimePicker dateTimeP;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}