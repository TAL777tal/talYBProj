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
            this.LabelNameCust = new Krypton.Toolkit.KryptonLabel();
            this.LabelZan = new Krypton.Toolkit.KryptonLabel();
            this.LabelDolevNum = new Krypton.Toolkit.KryptonLabel();
            this.LabelCurDate = new Krypton.Toolkit.KryptonLabel();
            this.LabelBruto = new Krypton.Toolkit.KryptonLabel();
            this.LabelNeto = new Krypton.Toolkit.KryptonLabel();
            this.LabelNotes = new Krypton.Toolkit.KryptonLabel();
            this.LabelUserName = new Krypton.Toolkit.KryptonLabel();
            this.cbxNameCust = new System.Windows.Forms.ComboBox();
            this.cbxZan = new System.Windows.Forms.ComboBox();
            this.cbxUserName = new System.Windows.Forms.ComboBox();
            this.numericUpDownBruto = new System.Windows.Forms.NumericUpDown();
            this.cbxDolevNum = new System.Windows.Forms.ComboBox();
            this.txbNotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.NetoText = new Krypton.Toolkit.KryptonTextBox();
            this.dateTimeP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBruto)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNameCust
            // 
            this.LabelNameCust.Location = new System.Drawing.Point(629, 46);
            this.LabelNameCust.Name = "LabelNameCust";
            this.LabelNameCust.Size = new System.Drawing.Size(79, 24);
            this.LabelNameCust.TabIndex = 0;
            this.LabelNameCust.Values.Text = "שם הצרכן";
            // 
            // LabelZan
            // 
            this.LabelZan.Location = new System.Drawing.Point(629, 86);
            this.LabelZan.Name = "LabelZan";
            this.LabelZan.Size = new System.Drawing.Size(57, 24);
            this.LabelZan.TabIndex = 1;
            this.LabelZan.Values.Text = "סוג הזן";
            // 
            // LabelDolevNum
            // 
            this.LabelDolevNum.Location = new System.Drawing.Point(629, 127);
            this.LabelDolevNum.Name = "LabelDolevNum";
            this.LabelDolevNum.Size = new System.Drawing.Size(94, 24);
            this.LabelDolevNum.TabIndex = 2;
            this.LabelDolevNum.Values.Text = "מספר הדולב";
            // 
            // LabelCurDate
            // 
            this.LabelCurDate.Location = new System.Drawing.Point(625, 167);
            this.LabelCurDate.Name = "LabelCurDate";
            this.LabelCurDate.Size = new System.Drawing.Size(112, 24);
            this.LabelCurDate.TabIndex = 3;
            this.LabelCurDate.Values.Text = "התאריך הנוכחי";
            this.LabelCurDate.Click += new System.EventHandler(this.kryptonLabel4_Click);
            // 
            // LabelBruto
            // 
            this.LabelBruto.Location = new System.Drawing.Point(632, 199);
            this.LabelBruto.Name = "LabelBruto";
            this.LabelBruto.Size = new System.Drawing.Size(95, 24);
            this.LabelBruto.TabIndex = 4;
            this.LabelBruto.Values.Text = "משקל-ברוטו";
            // 
            // LabelNeto
            // 
            this.LabelNeto.Location = new System.Drawing.Point(629, 243);
            this.LabelNeto.Name = "LabelNeto";
            this.LabelNeto.Size = new System.Drawing.Size(80, 24);
            this.LabelNeto.TabIndex = 5;
            this.LabelNeto.Values.Text = "משקל-נטו";
            // 
            // LabelNotes
            // 
            this.LabelNotes.Location = new System.Drawing.Point(629, 323);
            this.LabelNotes.Name = "LabelNotes";
            this.LabelNotes.Size = new System.Drawing.Size(55, 24);
            this.LabelNotes.TabIndex = 6;
            this.LabelNotes.Values.Text = "הערות";
            // 
            // LabelUserName
            // 
            this.LabelUserName.Location = new System.Drawing.Point(632, 284);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(105, 24);
            this.LabelUserName.TabIndex = 7;
            this.LabelUserName.Values.Text = "שם המשתמש";
            // 
            // cbxNameCust
            // 
            this.cbxNameCust.FormattingEnabled = true;
            this.cbxNameCust.Location = new System.Drawing.Point(442, 46);
            this.cbxNameCust.Name = "cbxNameCust";
            this.cbxNameCust.Size = new System.Drawing.Size(121, 24);
            this.cbxNameCust.TabIndex = 8;
            // 
            // cbxZan
            // 
            this.cbxZan.FormattingEnabled = true;
            this.cbxZan.Location = new System.Drawing.Point(442, 86);
            this.cbxZan.Name = "cbxZan";
            this.cbxZan.Size = new System.Drawing.Size(121, 24);
            this.cbxZan.TabIndex = 9;
            // 
            // cbxUserName
            // 
            this.cbxUserName.FormattingEnabled = true;
            this.cbxUserName.Location = new System.Drawing.Point(442, 284);
            this.cbxUserName.Name = "cbxUserName";
            this.cbxUserName.Size = new System.Drawing.Size(121, 24);
            this.cbxUserName.TabIndex = 10;
            // 
            // numericUpDownBruto
            // 
            this.numericUpDownBruto.Location = new System.Drawing.Point(443, 199);
            this.numericUpDownBruto.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownBruto.Name = "numericUpDownBruto";
            this.numericUpDownBruto.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownBruto.TabIndex = 11;
            // 
            // cbxDolevNum
            // 
            this.cbxDolevNum.FormattingEnabled = true;
            this.cbxDolevNum.Location = new System.Drawing.Point(443, 127);
            this.cbxDolevNum.Name = "cbxDolevNum";
            this.cbxDolevNum.Size = new System.Drawing.Size(121, 24);
            this.cbxDolevNum.TabIndex = 13;
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(359, 323);
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(204, 115);
            this.txbNotes.TabIndex = 14;
            this.txbNotes.Text = "";
            // 
            // NetoText
            // 
            this.NetoText.Location = new System.Drawing.Point(443, 243);
            this.NetoText.Name = "NetoText";
            this.NetoText.Size = new System.Drawing.Size(121, 27);
            this.NetoText.TabIndex = 15;
            // 
            // dateTimeP
            // 
            this.dateTimeP.Location = new System.Drawing.Point(364, 169);
            this.dateTimeP.Name = "dateTimeP";
            this.dateTimeP.Size = new System.Drawing.Size(200, 22);
            this.dateTimeP.TabIndex = 16;
            // 
            // updateDolevWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimeP);
            this.Controls.Add(this.NetoText);
            this.Controls.Add(this.txbNotes);
            this.Controls.Add(this.cbxDolevNum);
            this.Controls.Add(this.numericUpDownBruto);
            this.Controls.Add(this.cbxUserName);
            this.Controls.Add(this.cbxZan);
            this.Controls.Add(this.cbxNameCust);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.LabelNotes);
            this.Controls.Add(this.LabelNeto);
            this.Controls.Add(this.LabelBruto);
            this.Controls.Add(this.LabelCurDate);
            this.Controls.Add(this.LabelDolevNum);
            this.Controls.Add(this.LabelZan);
            this.Controls.Add(this.LabelNameCust);
            this.Name = "updateDolevWin";
            this.Text = "updateDolev";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBruto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel LabelNameCust;
        private Krypton.Toolkit.KryptonLabel LabelZan;
        private Krypton.Toolkit.KryptonLabel LabelDolevNum;
        private Krypton.Toolkit.KryptonLabel LabelCurDate;
        private Krypton.Toolkit.KryptonLabel LabelBruto;
        private Krypton.Toolkit.KryptonLabel LabelNeto;
        private Krypton.Toolkit.KryptonLabel LabelNotes;
        private Krypton.Toolkit.KryptonLabel LabelUserName;
        private System.Windows.Forms.ComboBox cbxNameCust;
        private System.Windows.Forms.ComboBox cbxZan;
        private System.Windows.Forms.ComboBox cbxUserName;
        private System.Windows.Forms.NumericUpDown numericUpDownBruto;
        private System.Windows.Forms.ComboBox cbxDolevNum;
        private Krypton.Toolkit.KryptonRichTextBox txbNotes;
        private Krypton.Toolkit.KryptonTextBox NetoText;
        private System.Windows.Forms.DateTimePicker dateTimeP;
    }
}