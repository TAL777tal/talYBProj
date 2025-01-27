namespace talYBProj.Forms
{
    partial class addOilWin
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
            this.Labelnotes = new Krypton.Toolkit.KryptonLabel();
            this.RichTextBoxNotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.AddButton = new Krypton.Toolkit.KryptonButton();
            this.labelNumOfDolevim = new System.Windows.Forms.Label();
            this.NumericUDOolevim = new Krypton.Toolkit.KryptonNumericUpDown();
            this.labelIDorder = new System.Windows.Forms.Label();
            this.cbxCustomers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxZan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Labelnotes
            // 
            this.Labelnotes.Location = new System.Drawing.Point(573, 240);
            this.Labelnotes.Name = "Labelnotes";
            this.Labelnotes.Size = new System.Drawing.Size(55, 24);
            this.Labelnotes.TabIndex = 5;
            this.Labelnotes.Values.Text = "הערות";
            // 
            // RichTextBoxNotes
            // 
            this.RichTextBoxNotes.Location = new System.Drawing.Point(371, 240);
            this.RichTextBoxNotes.Name = "RichTextBoxNotes";
            this.RichTextBoxNotes.Size = new System.Drawing.Size(196, 139);
            this.RichTextBoxNotes.TabIndex = 6;
            this.RichTextBoxNotes.Text = "";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(393, 401);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 25);
            this.AddButton.TabIndex = 12;
            this.AddButton.Values.Text = "הוסף נתונים להזמנה";
            // 
            // labelNumOfDolevim
            // 
            this.labelNumOfDolevim.AutoSize = true;
            this.labelNumOfDolevim.Location = new System.Drawing.Point(584, 121);
            this.labelNumOfDolevim.Name = "labelNumOfDolevim";
            this.labelNumOfDolevim.Size = new System.Drawing.Size(82, 16);
            this.labelNumOfDolevim.TabIndex = 13;
            this.labelNumOfDolevim.Text = "מספר דולבים";
            // 
            // NumericUDOolevim
            // 
            this.NumericUDOolevim.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUDOolevim.Location = new System.Drawing.Point(437, 121);
            this.NumericUDOolevim.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUDOolevim.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumericUDOolevim.Name = "NumericUDOolevim";
            this.NumericUDOolevim.Size = new System.Drawing.Size(120, 26);
            this.NumericUDOolevim.TabIndex = 14;
            this.NumericUDOolevim.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // labelIDorder
            // 
            this.labelIDorder.AutoSize = true;
            this.labelIDorder.Location = new System.Drawing.Point(584, 62);
            this.labelIDorder.Name = "labelIDorder";
            this.labelIDorder.Size = new System.Drawing.Size(61, 16);
            this.labelIDorder.TabIndex = 15;
            this.labelIDorder.Text = "בחר לקוח";
            // 
            // cbxCustomers
            // 
            this.cbxCustomers.FormattingEnabled = true;
            this.cbxCustomers.Location = new System.Drawing.Point(436, 62);
            this.cbxCustomers.Name = "cbxCustomers";
            this.cbxCustomers.Size = new System.Drawing.Size(121, 24);
            this.cbxCustomers.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "הוספת הזמנה חדשה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "בחר זן";
            // 
            // cbxZan
            // 
            this.cbxZan.FormattingEnabled = true;
            this.cbxZan.Location = new System.Drawing.Point(436, 174);
            this.cbxZan.Name = "cbxZan";
            this.cbxZan.Size = new System.Drawing.Size(121, 24);
            this.cbxZan.TabIndex = 16;
            // 
            // addOilWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxZan);
            this.Controls.Add(this.cbxCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIDorder);
            this.Controls.Add(this.NumericUDOolevim);
            this.Controls.Add(this.labelNumOfDolevim);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RichTextBoxNotes);
            this.Controls.Add(this.Labelnotes);
            this.Name = "addOilWin";
            this.Text = "addOilWin";
            this.Load += new System.EventHandler(this.addOilWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel Labelnotes;
        private Krypton.Toolkit.KryptonRichTextBox RichTextBoxNotes;
        private Krypton.Toolkit.KryptonButton AddButton;
        private System.Windows.Forms.Label labelNumOfDolevim;
        private Krypton.Toolkit.KryptonNumericUpDown NumericUDOolevim;
        private System.Windows.Forms.Label labelIDorder;
        private System.Windows.Forms.ComboBox cbxCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxZan;
    }
}