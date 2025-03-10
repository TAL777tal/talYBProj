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
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.choseCBX = new System.Windows.Forms.ComboBox();
            this.packTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zanTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zanTBLBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CBXweight = new System.Windows.Forms.ComboBox();
            this.userTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costomerTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notesTBX = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.nameTBX = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.packTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomerTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apdateButton
            // 
            this.apdateButton.Location = new System.Drawing.Point(432, 495);
            this.apdateButton.Name = "apdateButton";
            this.apdateButton.Size = new System.Drawing.Size(105, 33);
            this.apdateButton.TabIndex = 16;
            this.apdateButton.Values.Text = "עדכן";
            this.apdateButton.Click += new System.EventHandler(this.apdateButton_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(521, 61);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(112, 24);
            this.kryptonLabel4.TabIndex = 12;
            this.kryptonLabel4.Values.Text = "עדכן סוג חבילה";
            // 
            // choseCBX
            // 
            this.choseCBX.DataSource = this.packTBLBindingSource;
            this.choseCBX.DisplayMember = "packName";
            this.choseCBX.FormattingEnabled = true;
            this.choseCBX.Location = new System.Drawing.Point(352, 64);
            this.choseCBX.Name = "choseCBX";
            this.choseCBX.Size = new System.Drawing.Size(121, 21);
            this.choseCBX.TabIndex = 19;
            this.choseCBX.ValueMember = "weight";
            this.choseCBX.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // packTBLBindingSource
            // 
            this.packTBLBindingSource.DataSource = typeof(talYBProj.packTBL);
            // 
            // zanTBLBindingSource
            // 
            this.zanTBLBindingSource.DataSource = typeof(talYBProj.zanTBL);
            // 
            // zanTBLBindingSource1
            // 
            this.zanTBLBindingSource1.DataSource = typeof(talYBProj.zanTBL);
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
            this.CBXweight.Location = new System.Drawing.Point(570, 125);
            this.CBXweight.Name = "CBXweight";
            this.CBXweight.Size = new System.Drawing.Size(121, 21);
            this.CBXweight.TabIndex = 30;
            this.CBXweight.SelectedIndexChanged += new System.EventHandler(this.CBXweight_SelectedIndexChanged);
            // 
            // userTBLBindingSource
            // 
            this.userTBLBindingSource.DataSource = typeof(talYBProj.userTBL);
            // 
            // costomerTBLBindingSource
            // 
            this.costomerTBLBindingSource.DataSource = typeof(talYBProj.costomerTBL);
            // 
            // notesTBX
            // 
            this.notesTBX.Location = new System.Drawing.Point(530, 240);
            this.notesTBX.Name = "notesTBX";
            this.notesTBX.Size = new System.Drawing.Size(161, 104);
            this.notesTBX.TabIndex = 22;
            this.notesTBX.Text = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(743, 240);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(55, 24);
            this.kryptonLabel3.TabIndex = 21;
            this.kryptonLabel3.Values.Text = "הערות";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(743, 125);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(53, 24);
            this.kryptonLabel1.TabIndex = 20;
            this.kryptonLabel1.Values.Text = "משקל";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(743, 183);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(34, 24);
            this.kryptonLabel2.TabIndex = 31;
            this.kryptonLabel2.Values.Text = "שם";
            // 
            // nameTBX
            // 
            this.nameTBX.Location = new System.Drawing.Point(570, 180);
            this.nameTBX.Name = "nameTBX";
            this.nameTBX.Size = new System.Drawing.Size(121, 27);
            this.nameTBX.TabIndex = 32;
            // 
            // updatePack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 551);
            this.Controls.Add(this.nameTBX);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.CBXweight);
            this.Controls.Add(this.notesTBX);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.choseCBX);
            this.Controls.Add(this.apdateButton);
            this.Controls.Add(this.kryptonLabel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updatePack";
            this.Text = "updatePack";
            this.Load += new System.EventHandler(this.updatePack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomerTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton apdateButton;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private System.Windows.Forms.ComboBox choseCBX;
        private System.Windows.Forms.BindingSource packTBLBindingSource;
        private System.Windows.Forms.BindingSource zanTBLBindingSource;
        private System.Windows.Forms.BindingSource zanTBLBindingSource1;
        private System.Windows.Forms.ComboBox CBXweight;
        private Krypton.Toolkit.KryptonRichTextBox notesTBX;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.BindingSource userTBLBindingSource;
        private System.Windows.Forms.BindingSource costomerTBLBindingSource;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox nameTBX;
    }
}