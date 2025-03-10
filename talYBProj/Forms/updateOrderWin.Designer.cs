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
            ((System.ComponentModel.ISupportInitialize)(this.cbxOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDolevim)).BeginInit();
            this.SuspendLayout();
            // 
            // orderLabel
            // 
            this.orderLabel.Location = new System.Drawing.Point(368, 52);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(2);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(65, 24);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Values.Text = "ההזמנה";
            // 
            // costomerNameLabel
            // 
            this.costomerNameLabel.Location = new System.Drawing.Point(434, 109);
            this.costomerNameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.costomerNameLabel.Name = "costomerNameLabel";
            this.costomerNameLabel.Size = new System.Drawing.Size(79, 24);
            this.costomerNameLabel.TabIndex = 1;
            this.costomerNameLabel.Values.Text = "שם הצרכן";
            // 
            // oliveSpeciesLabel
            // 
            this.oliveSpeciesLabel.Location = new System.Drawing.Point(434, 142);
            this.oliveSpeciesLabel.Margin = new System.Windows.Forms.Padding(2);
            this.oliveSpeciesLabel.Name = "oliveSpeciesLabel";
            this.oliveSpeciesLabel.Size = new System.Drawing.Size(68, 24);
            this.oliveSpeciesLabel.TabIndex = 2;
            this.oliveSpeciesLabel.Values.Text = "סוג הזית";
            // 
            // numOfDolevimLabel
            // 
            this.numOfDolevimLabel.Location = new System.Drawing.Point(434, 176);
            this.numOfDolevimLabel.Margin = new System.Windows.Forms.Padding(2);
            this.numOfDolevimLabel.Name = "numOfDolevimLabel";
            this.numOfDolevimLabel.Size = new System.Drawing.Size(98, 24);
            this.numOfDolevimLabel.TabIndex = 3;
            this.numOfDolevimLabel.Values.Text = "מספר דולבים";
            // 
            // notesLabel
            // 
            this.notesLabel.Location = new System.Drawing.Point(434, 210);
            this.notesLabel.Margin = new System.Windows.Forms.Padding(2);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(55, 24);
            this.notesLabel.TabIndex = 4;
            this.notesLabel.Values.Text = "הערות";
            // 
            // cbxOrders
            // 
            this.cbxOrders.DataSource = this.orderTBLBindingSource;
            this.cbxOrders.DisplayMember = "costomerID";
            this.cbxOrders.DropDownWidth = 121;
            this.cbxOrders.IntegralHeight = false;
            this.cbxOrders.Location = new System.Drawing.Point(249, 50);
            this.cbxOrders.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOrders.Name = "cbxOrders";
            this.cbxOrders.Size = new System.Drawing.Size(91, 26);
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
            this.cbxCostumerName.Location = new System.Drawing.Point(300, 109);
            this.cbxCostumerName.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCostumerName.Name = "cbxCostumerName";
            this.cbxCostumerName.Size = new System.Drawing.Size(92, 21);
            this.cbxCostumerName.TabIndex = 7;
            this.cbxCostumerName.SelectedIndexChanged += new System.EventHandler(this.cbxCostumerName_SelectedIndexChanged);
            // 
            // cbxOliveKind
            // 
            this.cbxOliveKind.FormattingEnabled = true;
            this.cbxOliveKind.Location = new System.Drawing.Point(300, 142);
            this.cbxOliveKind.Margin = new System.Windows.Forms.Padding(2);
            this.cbxOliveKind.Name = "cbxOliveKind";
            this.cbxOliveKind.Size = new System.Drawing.Size(92, 21);
            this.cbxOliveKind.TabIndex = 8;
            // 
            // numericUpDownDolevim
            // 
            this.numericUpDownDolevim.Location = new System.Drawing.Point(301, 178);
            this.numericUpDownDolevim.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownDolevim.Name = "numericUpDownDolevim";
            this.numericUpDownDolevim.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownDolevim.TabIndex = 9;
            // 
            // kRTBXnotes
            // 
            this.kRTBXnotes.Location = new System.Drawing.Point(212, 218);
            this.kRTBXnotes.Margin = new System.Windows.Forms.Padding(2);
            this.kRTBXnotes.Name = "kRTBXnotes";
            this.kRTBXnotes.Size = new System.Drawing.Size(179, 102);
            this.kRTBXnotes.TabIndex = 10;
            this.kRTBXnotes.Text = "";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(256, 336);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(68, 20);
            this.updateButton.TabIndex = 11;
            this.updateButton.Values.Text = "עדכן";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateOrderWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}