namespace talYBProj.Forms
{
    partial class addPack
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
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.notesTBX = new Krypton.Toolkit.KryptonRichTextBox();
            this.addButton = new Krypton.Toolkit.KryptonButton();
            this.costomerTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zanTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CBXweight = new System.Windows.Forms.ComboBox();
            this.nameTBX = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.costomerTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(628, 102);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(53, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "משקל";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(628, 230);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(55, 24);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "הערות";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(541, 31);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(104, 24);
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "הוספת חבילה";
            // 
            // notesTBX
            // 
            this.notesTBX.Location = new System.Drawing.Point(439, 230);
            this.notesTBX.Name = "notesTBX";
            this.notesTBX.Size = new System.Drawing.Size(161, 104);
            this.notesTBX.TabIndex = 5;
            this.notesTBX.Text = "";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(439, 413);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 33);
            this.addButton.TabIndex = 8;
            this.addButton.Values.Text = "הוספה";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // costomerTBLBindingSource
            // 
            this.costomerTBLBindingSource.DataSource = typeof(talYBProj.costomerTBL);
            // 
            // zanTBLBindingSource
            // 
            this.zanTBLBindingSource.DataSource = typeof(talYBProj.zanTBL);
            // 
            // userTBLBindingSource
            // 
            this.userTBLBindingSource.DataSource = typeof(talYBProj.userTBL);
            // 
            // CBXweight
            // 
            this.CBXweight.FormattingEnabled = true;
            this.CBXweight.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5",
            "10",
            "15",
            "20"});
            this.CBXweight.Location = new System.Drawing.Point(479, 102);
            this.CBXweight.Name = "CBXweight";
            this.CBXweight.Size = new System.Drawing.Size(121, 21);
            this.CBXweight.TabIndex = 16;
            // 
            // nameTBX
            // 
            this.nameTBX.Location = new System.Drawing.Point(479, 164);
            this.nameTBX.Name = "nameTBX";
            this.nameTBX.Size = new System.Drawing.Size(121, 27);
            this.nameTBX.TabIndex = 34;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(628, 164);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(34, 24);
            this.kryptonLabel2.TabIndex = 33;
            this.kryptonLabel2.Values.Text = "שם";
            // 
            // addPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.nameTBX);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.CBXweight);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.notesTBX);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addPack";
            this.Text = "addPack";
            ((System.ComponentModel.ISupportInitialize)(this.costomerTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonRichTextBox notesTBX;
        private Krypton.Toolkit.KryptonButton addButton;
        private System.Windows.Forms.ComboBox CBXweight;
        private System.Windows.Forms.BindingSource costomerTBLBindingSource;
        private System.Windows.Forms.BindingSource zanTBLBindingSource;
        private System.Windows.Forms.BindingSource userTBLBindingSource;
        private Krypton.Toolkit.KryptonTextBox nameTBX;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}