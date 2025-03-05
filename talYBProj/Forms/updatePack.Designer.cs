namespace talYBProj.Forms
{
    partial class updatePack
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
            this.apdateButton = new Krypton.Toolkit.KryptonButton();
            this.priceNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.notesTBX = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.weightNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.choseCBX = new System.Windows.Forms.ComboBox();
            this.zanTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zanTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.packTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apdateButton
            // 
            this.apdateButton.Location = new System.Drawing.Point(360, 371);
            this.apdateButton.Name = "apdateButton";
            this.apdateButton.Size = new System.Drawing.Size(105, 33);
            this.apdateButton.TabIndex = 16;
            this.apdateButton.Values.Text = "עדכן";
            this.apdateButton.Click += new System.EventHandler(this.apdateButton_Click);
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceNumericUpDown.Location = new System.Drawing.Point(513, 175);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.priceNumericUpDown.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.priceNumericUpDown.TabIndex = 15;
            this.priceNumericUpDown.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // notesTBX
            // 
            this.notesTBX.Location = new System.Drawing.Point(472, 229);
            this.notesTBX.Name = "notesTBX";
            this.notesTBX.Size = new System.Drawing.Size(161, 104);
            this.notesTBX.TabIndex = 13;
            this.notesTBX.Text = "";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(484, 61);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel4.TabIndex = 12;
            this.kryptonLabel4.Values.Text = "עדכן סוג חבילה";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(685, 229);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel3.TabIndex = 11;
            this.kryptonLabel3.Values.Text = "הערות";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(692, 177);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(37, 20);
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "מחיר";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(685, 126);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "משקל";
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightNumericUpDown.Location = new System.Drawing.Point(513, 126);
            this.weightNumericUpDown.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.weightNumericUpDown.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.weightNumericUpDown.TabIndex = 18;
            this.weightNumericUpDown.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // choseCBX
            // 
            this.choseCBX.DataSource = this.packTBLBindingSource;
            this.choseCBX.DisplayMember = "weight";
            this.choseCBX.FormattingEnabled = true;
            this.choseCBX.Location = new System.Drawing.Point(328, 61);
            this.choseCBX.Name = "choseCBX";
            this.choseCBX.Size = new System.Drawing.Size(121, 21);
            this.choseCBX.TabIndex = 19;
            this.choseCBX.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // zanTBLBindingSource
            // 
            this.zanTBLBindingSource.DataSource = typeof(talYBProj.zanTBL);
            // 
            // zanTBLBindingSource1
            // 
            this.zanTBLBindingSource1.DataSource = typeof(talYBProj.zanTBL);
            // 
            // packTBLBindingSource
            // 
            this.packTBLBindingSource.DataSource = typeof(talYBProj.packTBL);
            // 
            // updatePack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.choseCBX);
            this.Controls.Add(this.weightNumericUpDown);
            this.Controls.Add(this.apdateButton);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.notesTBX);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "updatePack";
            this.Text = "updatePack";
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton apdateButton;
        private Krypton.Toolkit.KryptonNumericUpDown priceNumericUpDown;
        private Krypton.Toolkit.KryptonRichTextBox notesTBX;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonNumericUpDown weightNumericUpDown;
        private System.Windows.Forms.ComboBox choseCBX;
        private System.Windows.Forms.BindingSource packTBLBindingSource;
        private System.Windows.Forms.BindingSource zanTBLBindingSource;
        private System.Windows.Forms.BindingSource zanTBLBindingSource1;
    }
}