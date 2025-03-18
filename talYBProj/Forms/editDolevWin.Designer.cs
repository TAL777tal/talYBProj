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
            this.numericUpDownBruto = new System.Windows.Forms.NumericUpDown();
            this.cbxUserName = new System.Windows.Forms.ComboBox();
            this.userTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxOrderId = new System.Windows.Forms.ComboBox();
            this.orderTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelUserName = new Krypton.Toolkit.KryptonLabel();
            this.LabelNotes = new Krypton.Toolkit.KryptonLabel();
            this.LabelBruto = new Krypton.Toolkit.KryptonLabel();
            this.LabelCurDate = new Krypton.Toolkit.KryptonLabel();
            this.LabelOrderId = new Krypton.Toolkit.KryptonLabel();
            this.choseLabel = new Krypton.Toolkit.KryptonLabel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.dolevNumb = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolevNumb)).BeginInit();
            this.SuspendLayout();
            // 
            // updateDolev
            // 
            this.updateDolev.Location = new System.Drawing.Point(360, 413);
            this.updateDolev.Name = "updateDolev";
            this.updateDolev.Size = new System.Drawing.Size(90, 25);
            this.updateDolev.TabIndex = 32;
            this.updateDolev.Values.Text = "עדכן דולב";
            this.updateDolev.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // dateTimeP
            // 
            this.dateTimeP.Location = new System.Drawing.Point(440, 136);
            this.dateTimeP.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeP.Name = "dateTimeP";
            this.dateTimeP.Size = new System.Drawing.Size(151, 20);
            this.dateTimeP.TabIndex = 31;
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(440, 304);
            this.txbNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(153, 93);
            this.txbNotes.TabIndex = 29;
            this.txbNotes.Text = "";
            // 
            // numericUpDownBruto
            // 
            this.numericUpDownBruto.Location = new System.Drawing.Point(503, 185);
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
            this.cbxUserName.Location = new System.Drawing.Point(501, 244);
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
            this.cbxOrderId.Location = new System.Drawing.Point(501, 32);
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
            this.LabelUserName.Location = new System.Drawing.Point(619, 244);
            this.LabelUserName.Margin = new System.Windows.Forms.Padding(2);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(105, 24);
            this.LabelUserName.TabIndex = 24;
            this.LabelUserName.Values.Text = "שם המשתמש";
            // 
            // LabelNotes
            // 
            this.LabelNotes.Location = new System.Drawing.Point(629, 304);
            this.LabelNotes.Margin = new System.Windows.Forms.Padding(2);
            this.LabelNotes.Name = "LabelNotes";
            this.LabelNotes.Size = new System.Drawing.Size(55, 24);
            this.LabelNotes.TabIndex = 23;
            this.LabelNotes.Values.Text = "הערות";
            // 
            // LabelBruto
            // 
            this.LabelBruto.Location = new System.Drawing.Point(629, 185);
            this.LabelBruto.Margin = new System.Windows.Forms.Padding(2);
            this.LabelBruto.Name = "LabelBruto";
            this.LabelBruto.Size = new System.Drawing.Size(95, 24);
            this.LabelBruto.TabIndex = 21;
            this.LabelBruto.Values.Text = "משקל-ברוטו";
            // 
            // LabelCurDate
            // 
            this.LabelCurDate.Location = new System.Drawing.Point(629, 136);
            this.LabelCurDate.Margin = new System.Windows.Forms.Padding(2);
            this.LabelCurDate.Name = "LabelCurDate";
            this.LabelCurDate.Size = new System.Drawing.Size(112, 24);
            this.LabelCurDate.TabIndex = 20;
            this.LabelCurDate.Values.Text = "התאריך הנוכחי";
            // 
            // LabelOrderId
            // 
            this.LabelOrderId.Location = new System.Drawing.Point(629, 29);
            this.LabelOrderId.Margin = new System.Windows.Forms.Padding(2);
            this.LabelOrderId.Name = "LabelOrderId";
            this.LabelOrderId.Size = new System.Drawing.Size(108, 24);
            this.LabelOrderId.TabIndex = 18;
            this.LabelOrderId.Values.Text = "מספר ההזמנה";
            // 
            // choseLabel
            // 
            this.choseLabel.Location = new System.Drawing.Point(629, 90);
            this.choseLabel.Name = "choseLabel";
            this.choseLabel.Size = new System.Drawing.Size(44, 24);
            this.choseLabel.TabIndex = 34;
            this.choseLabel.Values.Text = " דולב";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(333, 90);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(105, 20);
            this.kryptonButton1.TabIndex = 37;
            this.kryptonButton1.Values.Text = "שנה מס\' דולב";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click_1);
            // 
            // dolevNumb
            // 
            this.dolevNumb.Location = new System.Drawing.Point(473, 90);
            this.dolevNumb.Name = "dolevNumb";
            this.dolevNumb.ReadOnly = true;
            this.dolevNumb.Size = new System.Drawing.Size(120, 20);
            this.dolevNumb.TabIndex = 38;
            this.dolevNumb.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dolevNumb.ValueChanged += new System.EventHandler(this.dolevNumb_ValueChanged);
            // 
            // editDolevWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dolevNumb);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.choseLabel);
            this.Controls.Add(this.updateDolev);
            this.Controls.Add(this.dateTimeP);
            this.Controls.Add(this.txbNotes);
            this.Controls.Add(this.numericUpDownBruto);
            this.Controls.Add(this.cbxUserName);
            this.Controls.Add(this.cbxOrderId);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.LabelNotes);
            this.Controls.Add(this.LabelBruto);
            this.Controls.Add(this.LabelCurDate);
            this.Controls.Add(this.LabelOrderId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editDolevWin";
            this.Text = "editDolev";
            this.Load += new System.EventHandler(this.editDolevWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolevNumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton updateDolev;
        private System.Windows.Forms.DateTimePicker dateTimeP;
        private Krypton.Toolkit.KryptonRichTextBox txbNotes;
        private System.Windows.Forms.NumericUpDown numericUpDownBruto;
        private System.Windows.Forms.ComboBox cbxUserName;
        private System.Windows.Forms.ComboBox cbxOrderId;
        private Krypton.Toolkit.KryptonLabel LabelUserName;
        private Krypton.Toolkit.KryptonLabel LabelNotes;
        private Krypton.Toolkit.KryptonLabel LabelBruto;
        private Krypton.Toolkit.KryptonLabel LabelCurDate;
        private Krypton.Toolkit.KryptonLabel LabelOrderId;
        private Krypton.Toolkit.KryptonLabel choseLabel;
        private System.Windows.Forms.BindingSource userTBLBindingSource;
        private System.Windows.Forms.BindingSource orderTBLBindingSource;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.NumericUpDown dolevNumb;
    }
}