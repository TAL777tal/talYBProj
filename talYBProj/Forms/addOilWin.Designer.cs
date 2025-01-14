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
            this.Labelweight = new Krypton.Toolkit.KryptonLabel();
            this.Labelnotes = new Krypton.Toolkit.KryptonLabel();
            this.RichTextBoxNotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.NumUDWeight = new Krypton.Toolkit.KryptonNumericUpDown();
            this.AddButton = new Krypton.Toolkit.KryptonButton();
            this.labelNumOfDolevim = new System.Windows.Forms.Label();
            this.NumericUDOolevim = new Krypton.Toolkit.KryptonNumericUpDown();
            this.SuspendLayout();
            // 
            // Labelweight
            // 
            this.Labelweight.Location = new System.Drawing.Point(573, 177);
            this.Labelweight.Name = "Labelweight";
            this.Labelweight.Size = new System.Drawing.Size(130, 24);
            this.Labelweight.TabIndex = 1;
            this.Labelweight.Values.Text = "סך משקל הזייתים";
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
            // NumUDWeight
            // 
            this.NumUDWeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUDWeight.Location = new System.Drawing.Point(437, 177);
            this.NumUDWeight.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumUDWeight.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumUDWeight.Name = "NumUDWeight";
            this.NumUDWeight.Size = new System.Drawing.Size(120, 26);
            this.NumUDWeight.TabIndex = 10;
            this.NumUDWeight.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            // addOilWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumericUDOolevim);
            this.Controls.Add(this.labelNumOfDolevim);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NumUDWeight);
            this.Controls.Add(this.RichTextBoxNotes);
            this.Controls.Add(this.Labelnotes);
            this.Controls.Add(this.Labelweight);
            this.Name = "addOilWin";
            this.Text = "addOilWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel Labelweight;
        private Krypton.Toolkit.KryptonLabel Labelnotes;
        private Krypton.Toolkit.KryptonRichTextBox RichTextBoxNotes;
        private Krypton.Toolkit.KryptonNumericUpDown NumUDWeight;
        private Krypton.Toolkit.KryptonButton AddButton;
        private System.Windows.Forms.Label labelNumOfDolevim;
        private Krypton.Toolkit.KryptonNumericUpDown NumericUDOolevim;
    }
}