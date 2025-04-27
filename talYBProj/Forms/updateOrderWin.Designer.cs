namespace talYBProj.Forms
{
    partial class updateOrderWin
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
            this.orderLabel = new Krypton.Toolkit.KryptonLabel();
            this.costomerNameLabel = new Krypton.Toolkit.KryptonLabel();
            this.oliveSpeciesLabel = new Krypton.Toolkit.KryptonLabel();
            this.numOfDolevimLabel = new Krypton.Toolkit.KryptonLabel();
            this.notesLabel = new Krypton.Toolkit.KryptonLabel();
            this.cbxOrders = new Krypton.Toolkit.KryptonComboBox();
            this.orderTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCostumerName = new System.Windows.Forms.ComboBox();
            this.cbxOliveKind = new System.Windows.Forms.ComboBox();
            this.numericUpDownDolevim = new System.Windows.Forms.NumericUpDown();
            this.kRTBXnotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.updateButton = new Krypton.Toolkit.KryptonButton();
            this.cbxUsers = new System.Windows.Forms.ComboBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.MTBprice = new System.Windows.Forms.MaskedTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cbxOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDolevim)).BeginInit();
            this.SuspendLayout();
            // 
            // orderLabel
            // 
            this.orderLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.orderLabel.Location = new System.Drawing.Point(552, 34);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(66, 24);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Values.Text = "ההזמנה";
            // 
            // costomerNameLabel
            // 
            this.costomerNameLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.costomerNameLabel.Location = new System.Drawing.Point(552, 124);
            this.costomerNameLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costomerNameLabel.Name = "costomerNameLabel";
            this.costomerNameLabel.Size = new System.Drawing.Size(83, 24);
            this.costomerNameLabel.TabIndex = 1;
            this.costomerNameLabel.Values.Text = "שם הצרכן";
            // 
            // oliveSpeciesLabel
            // 
            this.oliveSpeciesLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.oliveSpeciesLabel.Location = new System.Drawing.Point(552, 164);
            this.oliveSpeciesLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oliveSpeciesLabel.Name = "oliveSpeciesLabel";
            this.oliveSpeciesLabel.Size = new System.Drawing.Size(72, 24);
            this.oliveSpeciesLabel.TabIndex = 2;
            this.oliveSpeciesLabel.Values.Text = "סוג הזית";
            // 
            // numOfDolevimLabel
            // 
            this.numOfDolevimLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.numOfDolevimLabel.Location = new System.Drawing.Point(552, 230);
            this.numOfDolevimLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numOfDolevimLabel.Name = "numOfDolevimLabel";
            this.numOfDolevimLabel.Size = new System.Drawing.Size(104, 24);
            this.numOfDolevimLabel.TabIndex = 3;
            this.numOfDolevimLabel.Values.Text = "מספר דולבים";
            // 
            // notesLabel
            // 
            this.notesLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.notesLabel.Location = new System.Drawing.Point(552, 268);
            this.notesLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(57, 24);
            this.notesLabel.TabIndex = 4;
            this.notesLabel.Values.Text = "הערות";
            // 
            // cbxOrders
            // 
            this.cbxOrders.DataSource = this.orderTBLBindingSource;
            this.cbxOrders.DisplayMember = "Id";
            this.cbxOrders.DropDownWidth = 121;
            this.cbxOrders.IntegralHeight = false;
            this.cbxOrders.Location = new System.Drawing.Point(400, 34);
            this.cbxOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOrders.Name = "cbxOrders";
            this.cbxOrders.Size = new System.Drawing.Size(121, 26);
            this.cbxOrders.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxOrders.TabIndex = 5;
            this.cbxOrders.SelectedIndexChanged += new System.EventHandler(this.ordersComboBox_SelectedIndexChanged);
            // 
            // orderTBLBindingSource
            // 
            this.orderTBLBindingSource.DataSource = typeof(talYBProj.orderTBL);
            // 
            // cbxCostumerName
            // 
            this.cbxCostumerName.FormattingEnabled = true;
            this.cbxCostumerName.Location = new System.Drawing.Point(400, 124);
            this.cbxCostumerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxCostumerName.Name = "cbxCostumerName";
            this.cbxCostumerName.Size = new System.Drawing.Size(121, 24);
            this.cbxCostumerName.TabIndex = 7;
            this.cbxCostumerName.SelectedIndexChanged += new System.EventHandler(this.cbxCostumerName_SelectedIndexChanged);
            // 
            // cbxOliveKind
            // 
            this.cbxOliveKind.FormattingEnabled = true;
            this.cbxOliveKind.Location = new System.Drawing.Point(401, 164);
            this.cbxOliveKind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOliveKind.Name = "cbxOliveKind";
            this.cbxOliveKind.Size = new System.Drawing.Size(121, 24);
            this.cbxOliveKind.TabIndex = 8;
            // 
            // numericUpDownDolevim
            // 
            this.numericUpDownDolevim.Location = new System.Drawing.Point(401, 230);
            this.numericUpDownDolevim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDolevim.Name = "numericUpDownDolevim";
            this.numericUpDownDolevim.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDolevim.TabIndex = 9;
            // 
            // kRTBXnotes
            // 
            this.kRTBXnotes.Location = new System.Drawing.Point(283, 268);
            this.kRTBXnotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kRTBXnotes.Name = "kRTBXnotes";
            this.kRTBXnotes.Size = new System.Drawing.Size(239, 126);
            this.kRTBXnotes.TabIndex = 10;
            this.kRTBXnotes.Text = "";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(356, 413);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(150, 26);
            this.updateButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateButton.TabIndex = 11;
            this.updateButton.Values.Text = "עדכן";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cbxUsers
            // 
            this.cbxUsers.DisplayMember = "fullName";
            this.cbxUsers.FormattingEnabled = true;
            this.cbxUsers.Location = new System.Drawing.Point(400, 82);
            this.cbxUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxUsers.Name = "cbxUsers";
            this.cbxUsers.Size = new System.Drawing.Size(121, 24);
            this.cbxUsers.TabIndex = 28;
            this.cbxUsers.ValueMember = "Id";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(552, 82);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(82, 24);
            this.kryptonLabel1.TabIndex = 27;
            this.kryptonLabel1.Values.Text = "שם העובד";
            // 
            // MTBprice
            // 
            this.MTBprice.Location = new System.Drawing.Point(445, 195);
            this.MTBprice.Mask = "00000.00";
            this.MTBprice.Name = "MTBprice";
            this.MTBprice.Size = new System.Drawing.Size(77, 22);
            this.MTBprice.TabIndex = 31;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(552, 195);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(93, 24);
            this.kryptonLabel2.TabIndex = 30;
            this.kryptonLabel2.Values.Text = "מחיר עסקה";
            // 
            // updateOrderWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MTBprice);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.cbxUsers);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.kRTBXnotes);
            this.Controls.Add(this.numericUpDownDolevim);
            this.Controls.Add(this.cbxOliveKind);
            this.Controls.Add(this.cbxCostumerName);
            this.Controls.Add(this.cbxOrders);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.numOfDolevimLabel);
            this.Controls.Add(this.oliveSpeciesLabel);
            this.Controls.Add(this.costomerNameLabel);
            this.Controls.Add(this.orderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "updateOrderWin";
            this.Text = "updateOrder";
            this.Load += new System.EventHandler(this.updateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbxOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDolevim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel orderLabel;
        private Krypton.Toolkit.KryptonLabel costomerNameLabel;
        private Krypton.Toolkit.KryptonLabel oliveSpeciesLabel;
        private Krypton.Toolkit.KryptonLabel numOfDolevimLabel;
        private Krypton.Toolkit.KryptonLabel notesLabel;
        private Krypton.Toolkit.KryptonComboBox cbxOrders;
        private System.Windows.Forms.ComboBox cbxCostumerName;
        private System.Windows.Forms.ComboBox cbxOliveKind;
        private System.Windows.Forms.NumericUpDown numericUpDownDolevim;
        private Krypton.Toolkit.KryptonRichTextBox kRTBXnotes;
        private Krypton.Toolkit.KryptonButton updateButton;
        private System.Windows.Forms.BindingSource orderTBLBindingSource;
        private System.Windows.Forms.ComboBox cbxUsers;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.MaskedTextBox MTBprice;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}