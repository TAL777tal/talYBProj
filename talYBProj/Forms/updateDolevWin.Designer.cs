﻿namespace talYBProj.Forms
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
            this.components = new System.ComponentModel.Container();
            this.LabelOrderId = new Krypton.Toolkit.KryptonLabel();
            this.LabelDolevNum = new Krypton.Toolkit.KryptonLabel();
            this.LabelCurDate = new Krypton.Toolkit.KryptonLabel();
            this.LabelBruto = new Krypton.Toolkit.KryptonLabel();
            this.LabelNotes = new Krypton.Toolkit.KryptonLabel();
            this.LabelUserName = new Krypton.Toolkit.KryptonLabel();
            this.cbxOrderId = new System.Windows.Forms.ComboBox();
            this.orderTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxUserName = new System.Windows.Forms.ComboBox();
            this.userTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownBruto = new System.Windows.Forms.NumericUpDown();
            this.txbNotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.dateTimeP = new System.Windows.Forms.DateTimePicker();
            this.btnAddDolev = new Krypton.Toolkit.KryptonButton();
            this.dolevNum = new System.Windows.Forms.NumericUpDown();
            this.lblTotalDolevim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBruto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolevNum)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelOrderId
            // 
            this.LabelOrderId.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.LabelOrderId.Location = new System.Drawing.Point(624, 28);
            this.LabelOrderId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelOrderId.Name = "LabelOrderId";
            this.LabelOrderId.Size = new System.Drawing.Size(112, 24);
            this.LabelOrderId.TabIndex = 0;
            this.LabelOrderId.Values.Text = "מספר ההזמנה";
            // 
            // LabelDolevNum
            // 
            this.LabelDolevNum.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.LabelDolevNum.Location = new System.Drawing.Point(637, 76);
            this.LabelDolevNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelDolevNum.Name = "LabelDolevNum";
            this.LabelDolevNum.Size = new System.Drawing.Size(99, 24);
            this.LabelDolevNum.TabIndex = 2;
            this.LabelDolevNum.Values.Text = "מספר הדולב";
            // 
            // LabelCurDate
            // 
            this.LabelCurDate.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.LabelCurDate.Location = new System.Drawing.Point(618, 124);
            this.LabelCurDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelCurDate.Name = "LabelCurDate";
            this.LabelCurDate.Size = new System.Drawing.Size(118, 24);
            this.LabelCurDate.TabIndex = 3;
            this.LabelCurDate.Values.Text = "התאריך הנוכחי";
            this.LabelCurDate.Click += new System.EventHandler(this.kryptonLabel4_Click);
            // 
            // LabelBruto
            // 
            this.LabelBruto.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.LabelBruto.Location = new System.Drawing.Point(641, 171);
            this.LabelBruto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelBruto.Name = "LabelBruto";
            this.LabelBruto.Size = new System.Drawing.Size(99, 24);
            this.LabelBruto.TabIndex = 4;
            this.LabelBruto.Values.Text = "משקל-ברוטו";
            // 
            // LabelNotes
            // 
            this.LabelNotes.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.LabelNotes.Location = new System.Drawing.Point(681, 270);
            this.LabelNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelNotes.Name = "LabelNotes";
            this.LabelNotes.Size = new System.Drawing.Size(57, 24);
            this.LabelNotes.TabIndex = 6;
            this.LabelNotes.Values.Text = "הערות";
            // 
            // LabelUserName
            // 
            this.LabelUserName.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.LabelUserName.Location = new System.Drawing.Point(629, 217);
            this.LabelUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(107, 24);
            this.LabelUserName.TabIndex = 7;
            this.LabelUserName.Values.Text = "שם המשתמש";
            // 
            // cbxOrderId
            // 
            this.cbxOrderId.DataSource = this.orderTBLBindingSource;
            this.cbxOrderId.DisplayMember = "Id";
            this.cbxOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrderId.FormattingEnabled = true;
            this.cbxOrderId.Location = new System.Drawing.Point(440, 28);
            this.cbxOrderId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOrderId.Name = "cbxOrderId";
            this.cbxOrderId.Size = new System.Drawing.Size(121, 24);
            this.cbxOrderId.TabIndex = 8;
            this.cbxOrderId.SelectedIndexChanged += new System.EventHandler(this.cbxOrderId_SelectedIndexChanged);
            // 
            // orderTBLBindingSource
            // 
            this.orderTBLBindingSource.DataSource = typeof(talYBProj.orderTBL);
            // 
            // cbxUserName
            // 
            this.cbxUserName.DataSource = this.userTBLBindingSource;
            this.cbxUserName.DisplayMember = "fullName";
            this.cbxUserName.FormattingEnabled = true;
            this.cbxUserName.Location = new System.Drawing.Point(440, 217);
            this.cbxUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxUserName.Name = "cbxUserName";
            this.cbxUserName.Size = new System.Drawing.Size(121, 24);
            this.cbxUserName.TabIndex = 10;
            // 
            // userTBLBindingSource
            // 
            this.userTBLBindingSource.DataSource = typeof(talYBProj.userTBL);
            // 
            // numericUpDownBruto
            // 
            this.numericUpDownBruto.Location = new System.Drawing.Point(441, 173);
            this.numericUpDownBruto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownBruto.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownBruto.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownBruto.Name = "numericUpDownBruto";
            this.numericUpDownBruto.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownBruto.TabIndex = 11;
            this.numericUpDownBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownBruto.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownBruto.ValueChanged += new System.EventHandler(this.numericUpDownBruto_ValueChanged);
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(357, 270);
            this.txbNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(204, 114);
            this.txbNotes.TabIndex = 14;
            this.txbNotes.Text = "";
            // 
            // dateTimeP
            // 
            this.dateTimeP.Location = new System.Drawing.Point(361, 124);
            this.dateTimeP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeP.Name = "dateTimeP";
            this.dateTimeP.Size = new System.Drawing.Size(200, 22);
            this.dateTimeP.TabIndex = 16;
            // 
            // btnAddDolev
            // 
            this.btnAddDolev.Location = new System.Drawing.Point(325, 411);
            this.btnAddDolev.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDolev.Name = "btnAddDolev";
            this.btnAddDolev.Size = new System.Drawing.Size(161, 52);
            this.btnAddDolev.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddDolev.TabIndex = 17;
            this.btnAddDolev.Values.Text = "עצב דולב";
            this.btnAddDolev.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // dolevNum
            // 
            this.dolevNum.Location = new System.Drawing.Point(438, 76);
            this.dolevNum.Margin = new System.Windows.Forms.Padding(4);
            this.dolevNum.Name = "dolevNum";
            this.dolevNum.ReadOnly = true;
            this.dolevNum.Size = new System.Drawing.Size(123, 22);
            this.dolevNum.TabIndex = 18;
            this.dolevNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalDolevim
            // 
            this.lblTotalDolevim.Location = new System.Drawing.Point(131, 30);
            this.lblTotalDolevim.Name = "lblTotalDolevim";
            this.lblTotalDolevim.Size = new System.Drawing.Size(203, 22);
            this.lblTotalDolevim.TabIndex = 19;
            this.lblTotalDolevim.TextChanged += new System.EventHandler(this.lblTotalDolevim_TextChanged);
            // 
            // updateDolevWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(789, 500);
            this.Controls.Add(this.lblTotalDolevim);
            this.Controls.Add(this.dolevNum);
            this.Controls.Add(this.btnAddDolev);
            this.Controls.Add(this.dateTimeP);
            this.Controls.Add(this.txbNotes);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "updateDolevWin";
            this.Text = "updateDolev";
            this.Load += new System.EventHandler(this.updateDolevWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBruto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolevNum)).EndInit();
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
        private Krypton.Toolkit.KryptonRichTextBox txbNotes;
        private System.Windows.Forms.DateTimePicker dateTimeP;
        private Krypton.Toolkit.KryptonButton btnAddDolev;
        private System.Windows.Forms.BindingSource orderTBLBindingSource;
        private System.Windows.Forms.BindingSource userTBLBindingSource;
        private System.Windows.Forms.NumericUpDown dolevNum;
        private System.Windows.Forms.TextBox lblTotalDolevim;
    }
}