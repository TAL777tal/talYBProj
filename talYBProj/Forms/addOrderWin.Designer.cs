﻿namespace talYBProj.Forms
{
    partial class addOrderWin
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
            this.oliveSpeciesLabel = new Krypton.Toolkit.KryptonLabel();
            this.numOfDolevimLabel = new Krypton.Toolkit.KryptonLabel();
            this.notesLabel = new Krypton.Toolkit.KryptonLabel();
            this.costomerNameLabel = new Krypton.Toolkit.KryptonLabel();
            this.TBXnotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.btnAddOrder = new Krypton.Toolkit.KryptonButton();
            this.cbxCust = new System.Windows.Forms.ComboBox();
            this.costomerTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxZan = new System.Windows.Forms.ComboBox();
            this.zanTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nUDnumOfDolevim = new System.Windows.Forms.NumericUpDown();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.cbxUsers = new System.Windows.Forms.ComboBox();
            this.userTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.MTBprice = new System.Windows.Forms.MaskedTextBox();
            this.orderTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costomerTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.costomerTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDnumOfDolevim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomerTBLBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // oliveSpeciesLabel
            // 
            this.oliveSpeciesLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.oliveSpeciesLabel.Location = new System.Drawing.Point(629, 111);
            this.oliveSpeciesLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oliveSpeciesLabel.Name = "oliveSpeciesLabel";
            this.oliveSpeciesLabel.Size = new System.Drawing.Size(72, 24);
            this.oliveSpeciesLabel.TabIndex = 1;
            this.oliveSpeciesLabel.Values.Text = "סוג הזית";
            // 
            // numOfDolevimLabel
            // 
            this.numOfDolevimLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.numOfDolevimLabel.Location = new System.Drawing.Point(603, 149);
            this.numOfDolevimLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOfDolevimLabel.Name = "numOfDolevimLabel";
            this.numOfDolevimLabel.Size = new System.Drawing.Size(104, 24);
            this.numOfDolevimLabel.TabIndex = 2;
            this.numOfDolevimLabel.Values.Text = "מספר דולבים";
            // 
            // notesLabel
            // 
            this.notesLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.notesLabel.Location = new System.Drawing.Point(646, 228);
            this.notesLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(57, 24);
            this.notesLabel.TabIndex = 5;
            this.notesLabel.Values.Text = "הערות";
            // 
            // costomerNameLabel
            // 
            this.costomerNameLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.costomerNameLabel.Location = new System.Drawing.Point(619, 81);
            this.costomerNameLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costomerNameLabel.Name = "costomerNameLabel";
            this.costomerNameLabel.Size = new System.Drawing.Size(83, 24);
            this.costomerNameLabel.TabIndex = 11;
            this.costomerNameLabel.Values.Text = "שם הצרכן";
            // 
            // TBXnotes
            // 
            this.TBXnotes.Location = new System.Drawing.Point(421, 228);
            this.TBXnotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBXnotes.Name = "TBXnotes";
            this.TBXnotes.Size = new System.Drawing.Size(173, 138);
            this.TBXnotes.TabIndex = 14;
            this.TBXnotes.Text = "";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(356, 389);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(147, 34);
            this.btnAddOrder.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddOrder.TabIndex = 25;
            this.btnAddOrder.Values.Text = "הוסף הזמנה";
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // cbxCust
            // 
            this.cbxCust.DataSource = this.costomerTBLBindingSource1;
            this.cbxCust.DisplayMember = "fullName";
            this.cbxCust.FormattingEnabled = true;
            this.cbxCust.Location = new System.Drawing.Point(393, 81);
            this.cbxCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCust.Name = "cbxCust";
            this.cbxCust.Size = new System.Drawing.Size(200, 24);
            this.cbxCust.TabIndex = 26;
            this.cbxCust.SelectedIndexChanged += new System.EventHandler(this.cbxCust_SelectedIndexChanged);
            // 
            // cbxZan
            // 
            this.cbxZan.DataSource = this.zanTBLBindingSource;
            this.cbxZan.DisplayMember = "name";
            this.cbxZan.FormattingEnabled = true;
            this.cbxZan.Location = new System.Drawing.Point(393, 111);
            this.cbxZan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxZan.Name = "cbxZan";
            this.cbxZan.Size = new System.Drawing.Size(201, 24);
            this.cbxZan.TabIndex = 26;
            this.cbxZan.ValueMember = "Id";
            // 
            // nUDnumOfDolevim
            // 
            this.nUDnumOfDolevim.Location = new System.Drawing.Point(523, 151);
            this.nUDnumOfDolevim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUDnumOfDolevim.Name = "nUDnumOfDolevim";
            this.nUDnumOfDolevim.Size = new System.Drawing.Size(69, 22);
            this.nUDnumOfDolevim.TabIndex = 27;
            this.nUDnumOfDolevim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(619, 50);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(82, 24);
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "שם העובד";
            // 
            // cbxUsers
            // 
            this.cbxUsers.DataSource = this.userTBLBindingSource;
            this.cbxUsers.DisplayMember = "fullName";
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.Location = new System.Drawing.Point(393, 50);
            this.cbxUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(200, 24);
            this.cbxUsers.TabIndex = 26;
            this.cbxUsers.ValueMember = "Id";
            this.cbxUsers.SelectedIndexChanged += new System.EventHandler(this.cbxCust_SelectedIndexChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(612, 178);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(93, 24);
            this.kryptonLabel2.TabIndex = 28;
            this.kryptonLabel2.Values.Text = "מחיר עסקה";
            // 
            // MTBprice
            // 
            this.MTBprice.Location = new System.Drawing.Point(517, 180);
            this.MTBprice.Mask = "00000.00";
            this.MTBprice.Name = "MTBprice";
            this.MTBprice.Size = new System.Drawing.Size(77, 22);
            this.MTBprice.TabIndex = 29;
            // 
            // orderTBLBindingSource
            // 
            this.orderTBLBindingSource.DataSource = typeof(talYBProj.orderTBL);
            // 
            // costomerTBLBindingSource1
            // 
            this.costomerTBLBindingSource1.DataSource = typeof(talYBProj.costomerTBL);
            // 
            // addOrderWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MTBprice);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.nUDnumOfDolevim);
            this.Controls.Add(this.cbxZan);
            this.Controls.Add(this.cbxUsers);
            this.Controls.Add(this.cbxCust);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.TBXnotes);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.costomerNameLabel);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.numOfDolevimLabel);
            this.Controls.Add(this.oliveSpeciesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addOrderWin";
            this.Text = "addOrderWin";
            this.Load += new System.EventHandler(this.addOrderWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costomerTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDnumOfDolevim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomerTBLBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel oliveSpeciesLabel;
        private Krypton.Toolkit.KryptonLabel numOfDolevimLabel;
        private Krypton.Toolkit.KryptonLabel notesLabel;
        private Krypton.Toolkit.KryptonLabel costomerNameLabel;
        private Krypton.Toolkit.KryptonRichTextBox TBXnotes;
        private Krypton.Toolkit.KryptonButton btnAddOrder;
        private System.Windows.Forms.ComboBox cbxCust;
        private System.Windows.Forms.ComboBox cbxZan;
        private System.Windows.Forms.NumericUpDown nUDnumOfDolevim;
        private System.Windows.Forms.BindingSource costomerTBLBindingSource;
        private System.Windows.Forms.BindingSource zanTBLBindingSource;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.ComboBox cbxUsers;
        private System.Windows.Forms.BindingSource userTBLBindingSource;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.MaskedTextBox MTBprice;
        private System.Windows.Forms.BindingSource orderTBLBindingSource;
        private System.Windows.Forms.BindingSource costomerTBLBindingSource1;
    }
}