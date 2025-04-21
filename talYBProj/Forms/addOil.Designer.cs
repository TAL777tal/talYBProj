namespace talYBProj.Forms
{
    partial class addOil
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
            this.orderIDlabel = new Krypton.Toolkit.KryptonLabel();
            this.userIDlabel = new Krypton.Toolkit.KryptonLabel();
            this.packLabel = new Krypton.Toolkit.KryptonLabel();
            this.quantityLabel = new Krypton.Toolkit.KryptonLabel();
            this.currDateLabel = new Krypton.Toolkit.KryptonLabel();
            this.notesLabel = new Krypton.Toolkit.KryptonLabel();
            this.rTBXpackDes = new Krypton.Toolkit.KryptonRichTextBox();
            this.orderCBX = new System.Windows.Forms.ComboBox();
            this.userCBX = new System.Windows.Forms.ComboBox();
            this.packCBX = new System.Windows.Forms.ComboBox();
            this.NUPquantity = new Krypton.Toolkit.KryptonNumericUpDown();
            this.DTPdate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.rTBXnotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.addBTN = new Krypton.Toolkit.KryptonButton();
            this.orderTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIDlabel
            // 
            this.orderIDlabel.Location = new System.Drawing.Point(656, 12);
            this.orderIDlabel.Name = "orderIDlabel";
            this.orderIDlabel.Size = new System.Drawing.Size(65, 24);
            this.orderIDlabel.TabIndex = 0;
            this.orderIDlabel.Values.Text = "ההזמנה";
            // 
            // userIDlabel
            // 
            this.userIDlabel.Location = new System.Drawing.Point(656, 59);
            this.userIDlabel.Name = "userIDlabel";
            this.userIDlabel.Size = new System.Drawing.Size(52, 24);
            this.userIDlabel.TabIndex = 1;
            this.userIDlabel.Values.Text = "העובד";
            // 
            // packLabel
            // 
            this.packLabel.Location = new System.Drawing.Point(656, 102);
            this.packLabel.Name = "packLabel";
            this.packLabel.Size = new System.Drawing.Size(109, 24);
            this.packLabel.TabIndex = 2;
            this.packLabel.Values.Text = "משקל החבילה";
            // 
            // quantityLabel
            // 
            this.quantityLabel.Location = new System.Drawing.Point(656, 222);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(111, 24);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Values.Text = "כמויות החבילה";
            // 
            // currDateLabel
            // 
            this.currDateLabel.Location = new System.Drawing.Point(656, 267);
            this.currDateLabel.Name = "currDateLabel";
            this.currDateLabel.Size = new System.Drawing.Size(107, 24);
            this.currDateLabel.TabIndex = 4;
            this.currDateLabel.Values.Text = "התאריך עכשיו";
            // 
            // notesLabel
            // 
            this.notesLabel.Location = new System.Drawing.Point(656, 308);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(55, 24);
            this.notesLabel.TabIndex = 5;
            this.notesLabel.Values.Text = "הערות";
            // 
            // rTBXpackDes
            // 
            this.rTBXpackDes.Location = new System.Drawing.Point(126, 102);
            this.rTBXpackDes.Name = "rTBXpackDes";
            this.rTBXpackDes.Size = new System.Drawing.Size(307, 115);
            this.rTBXpackDes.TabIndex = 6;
            this.rTBXpackDes.Text = "";
            this.rTBXpackDes.TextChanged += new System.EventHandler(this.rTBXpackDes_TextChanged);
            // 
            // orderCBX
            // 
            this.orderCBX.DataSource = this.orderTBLBindingSource;
            this.orderCBX.DisplayMember = "Id";
            this.orderCBX.FormattingEnabled = true;
            this.orderCBX.Location = new System.Drawing.Point(508, 12);
            this.orderCBX.Name = "orderCBX";
            this.orderCBX.Size = new System.Drawing.Size(121, 24);
            this.orderCBX.TabIndex = 7;
            // 
            // userCBX
            // 
            this.userCBX.DataSource = this.userTBLBindingSource;
            this.userCBX.DisplayMember = "fullName";
            this.userCBX.FormattingEnabled = true;
            this.userCBX.Location = new System.Drawing.Point(508, 59);
            this.userCBX.Name = "userCBX";
            this.userCBX.Size = new System.Drawing.Size(121, 24);
            this.userCBX.TabIndex = 8;
            // 
            // packCBX
            // 
            this.packCBX.DataSource = this.packTBLBindingSource;
            this.packCBX.DisplayMember = "price";
            this.packCBX.FormattingEnabled = true;
            this.packCBX.Location = new System.Drawing.Point(509, 102);
            this.packCBX.Name = "packCBX";
            this.packCBX.Size = new System.Drawing.Size(121, 24);
            this.packCBX.TabIndex = 9;
            this.packCBX.SelectedIndexChanged += new System.EventHandler(this.packCBX_SelectedIndexChanged);
            // 
            // NUPquantity
            // 
            this.NUPquantity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUPquantity.Location = new System.Drawing.Point(509, 220);
            this.NUPquantity.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NUPquantity.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NUPquantity.Name = "NUPquantity";
            this.NUPquantity.Size = new System.Drawing.Size(120, 26);
            this.NUPquantity.TabIndex = 10;
            this.NUPquantity.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // DTPdate
            // 
            this.DTPdate.Location = new System.Drawing.Point(452, 266);
            this.DTPdate.Name = "DTPdate";
            this.DTPdate.Size = new System.Drawing.Size(177, 25);
            this.DTPdate.TabIndex = 11;
            // 
            // rTBXnotes
            // 
            this.rTBXnotes.Location = new System.Drawing.Point(322, 323);
            this.rTBXnotes.Name = "rTBXnotes";
            this.rTBXnotes.Size = new System.Drawing.Size(307, 115);
            this.rTBXnotes.TabIndex = 12;
            this.rTBXnotes.Text = "";
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(335, 444);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(181, 25);
            this.addBTN.TabIndex = 13;
            this.addBTN.Values.Text = "הוסף חבילות שמן";
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // orderTBLBindingSource
            // 
            this.orderTBLBindingSource.DataSource = typeof(talYBProj.orderTBL);
            // 
            // userTBLBindingSource
            // 
            this.userTBLBindingSource.DataSource = typeof(talYBProj.userTBL);
            // 
            // packTBLBindingSource
            // 
            this.packTBLBindingSource.DataSource = typeof(talYBProj.packTBL);
            // 
            // addOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.rTBXnotes);
            this.Controls.Add(this.DTPdate);
            this.Controls.Add(this.NUPquantity);
            this.Controls.Add(this.packCBX);
            this.Controls.Add(this.userCBX);
            this.Controls.Add(this.orderCBX);
            this.Controls.Add(this.rTBXpackDes);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.currDateLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.packLabel);
            this.Controls.Add(this.userIDlabel);
            this.Controls.Add(this.orderIDlabel);
            this.Name = "addOil";
            this.Text = "addOil";
            this.Load += new System.EventHandler(this.addOil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel orderIDlabel;
        private Krypton.Toolkit.KryptonLabel userIDlabel;
        private Krypton.Toolkit.KryptonLabel packLabel;
        private Krypton.Toolkit.KryptonLabel quantityLabel;
        private Krypton.Toolkit.KryptonLabel currDateLabel;
        private Krypton.Toolkit.KryptonLabel notesLabel;
        private Krypton.Toolkit.KryptonRichTextBox rTBXpackDes;
        private System.Windows.Forms.ComboBox orderCBX;
        private System.Windows.Forms.ComboBox userCBX;
        private System.Windows.Forms.ComboBox packCBX;
        private Krypton.Toolkit.KryptonNumericUpDown NUPquantity;
        private Krypton.Toolkit.KryptonDateTimePicker DTPdate;
        private Krypton.Toolkit.KryptonRichTextBox rTBXnotes;
        private Krypton.Toolkit.KryptonButton addBTN;
        private System.Windows.Forms.BindingSource orderTBLBindingSource;
        private System.Windows.Forms.BindingSource userTBLBindingSource;
        private System.Windows.Forms.BindingSource packTBLBindingSource;
    }
}