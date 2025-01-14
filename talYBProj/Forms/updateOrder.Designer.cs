namespace talYBProj.Forms
{
    partial class updateOrder
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
            this.orderLabel = new Krypton.Toolkit.KryptonLabel();
            this.costomerNameLabel = new Krypton.Toolkit.KryptonLabel();
            this.oliveSpeciesLabel = new Krypton.Toolkit.KryptonLabel();
            this.numOfDolevimLabel = new Krypton.Toolkit.KryptonLabel();
            this.notesLabel = new Krypton.Toolkit.KryptonLabel();
            this.cbxOrders = new Krypton.Toolkit.KryptonComboBox();
            this.cbxCostumerName = new System.Windows.Forms.ComboBox();
            this.cbxOliveKind = new System.Windows.Forms.ComboBox();
            this.numericUpDownDolevim = new System.Windows.Forms.NumericUpDown();
            this.kRTBXnotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.updateButton = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbxOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDolevim)).BeginInit();
            this.SuspendLayout();
            // 
            // orderLabel
            // 
            this.orderLabel.Location = new System.Drawing.Point(491, 64);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(65, 24);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Values.Text = "ההזמנה";
            // 
            // costomerNameLabel
            // 
            this.costomerNameLabel.Location = new System.Drawing.Point(578, 134);
            this.costomerNameLabel.Name = "costomerNameLabel";
            this.costomerNameLabel.Size = new System.Drawing.Size(79, 24);
            this.costomerNameLabel.TabIndex = 1;
            this.costomerNameLabel.Values.Text = "שם הצרכן";
            // 
            // oliveSpeciesLabel
            // 
            this.oliveSpeciesLabel.Location = new System.Drawing.Point(578, 175);
            this.oliveSpeciesLabel.Name = "oliveSpeciesLabel";
            this.oliveSpeciesLabel.Size = new System.Drawing.Size(68, 24);
            this.oliveSpeciesLabel.TabIndex = 2;
            this.oliveSpeciesLabel.Values.Text = "סוג הזית";
            // 
            // numOfDolevimLabel
            // 
            this.numOfDolevimLabel.Location = new System.Drawing.Point(578, 217);
            this.numOfDolevimLabel.Name = "numOfDolevimLabel";
            this.numOfDolevimLabel.Size = new System.Drawing.Size(98, 24);
            this.numOfDolevimLabel.TabIndex = 3;
            this.numOfDolevimLabel.Values.Text = "מספר דולבים";
            // 
            // notesLabel
            // 
            this.notesLabel.Location = new System.Drawing.Point(578, 258);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(55, 24);
            this.notesLabel.TabIndex = 4;
            this.notesLabel.Values.Text = "הערות";
            // 
            // cbxOrders
            // 
            this.cbxOrders.DropDownWidth = 121;
            this.cbxOrders.IntegralHeight = false;
            this.cbxOrders.Location = new System.Drawing.Point(332, 62);
            this.cbxOrders.Name = "cbxOrders";
            this.cbxOrders.Size = new System.Drawing.Size(121, 26);
            this.cbxOrders.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxOrders.TabIndex = 5;
            this.cbxOrders.SelectedIndexChanged += new System.EventHandler(this.ordersComboBox_SelectedIndexChanged);
            // 
            // cbxCostumerName
            // 
            this.cbxCostumerName.FormattingEnabled = true;
            this.cbxCostumerName.Location = new System.Drawing.Point(400, 134);
            this.cbxCostumerName.Name = "cbxCostumerName";
            this.cbxCostumerName.Size = new System.Drawing.Size(121, 24);
            this.cbxCostumerName.TabIndex = 7;
            // 
            // cbxOliveKind
            // 
            this.cbxOliveKind.FormattingEnabled = true;
            this.cbxOliveKind.Location = new System.Drawing.Point(400, 175);
            this.cbxOliveKind.Name = "cbxOliveKind";
            this.cbxOliveKind.Size = new System.Drawing.Size(121, 24);
            this.cbxOliveKind.TabIndex = 8;
            // 
            // numericUpDownDolevim
            // 
            this.numericUpDownDolevim.Location = new System.Drawing.Point(401, 219);
            this.numericUpDownDolevim.Name = "numericUpDownDolevim";
            this.numericUpDownDolevim.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDolevim.TabIndex = 9;
            // 
            // kRTBXnotes
            // 
            this.kRTBXnotes.Location = new System.Drawing.Point(282, 268);
            this.kRTBXnotes.Name = "kRTBXnotes";
            this.kRTBXnotes.Size = new System.Drawing.Size(239, 125);
            this.kRTBXnotes.TabIndex = 10;
            this.kRTBXnotes.Text = "";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(341, 413);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(90, 25);
            this.updateButton.TabIndex = 11;
            this.updateButton.Values.Text = "עדכן";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "updateOrder";
            this.Text = "updateOrder";
            this.Load += new System.EventHandler(this.updateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbxOrders)).EndInit();
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
    }
}