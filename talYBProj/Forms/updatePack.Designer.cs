﻿namespace talYBProj.Forms
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
            this.userTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costomerTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notesTBX = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.nameTBX = new Krypton.Toolkit.KryptonTextBox();
            this.CBXweight = new Krypton.Toolkit.KryptonNumericUpDown();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MTBprice = new System.Windows.Forms.MaskedTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.packTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomerTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep2)).BeginInit();
            this.SuspendLayout();
            // 
            // apdateButton
            // 
            this.apdateButton.Location = new System.Drawing.Point(510, 445);
            this.apdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.apdateButton.Name = "apdateButton";
            this.apdateButton.Size = new System.Drawing.Size(207, 59);
            this.apdateButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.apdateButton.TabIndex = 16;
            this.apdateButton.Values.Text = "עדכן";
            this.apdateButton.Click += new System.EventHandler(this.apdateButton_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(558, 33);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(119, 24);
            this.kryptonLabel4.TabIndex = 12;
            this.kryptonLabel4.Values.Text = "עדכן סוג חבילה";
            // 
            // choseCBX
            // 
            this.choseCBX.DataSource = this.packTBLBindingSource;
            this.choseCBX.DisplayMember = "packName";
            this.choseCBX.FormattingEnabled = true;
            this.choseCBX.Location = new System.Drawing.Point(530, 78);
            this.choseCBX.Margin = new System.Windows.Forms.Padding(4);
            this.choseCBX.Name = "choseCBX";
            this.choseCBX.Size = new System.Drawing.Size(160, 24);
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
            this.notesTBX.Location = new System.Drawing.Point(706, 283);
            this.notesTBX.Margin = new System.Windows.Forms.Padding(4);
            this.notesTBX.Name = "notesTBX";
            this.notesTBX.Size = new System.Drawing.Size(215, 128);
            this.notesTBX.TabIndex = 22;
            this.notesTBX.Text = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(987, 283);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(47, 19);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kryptonLabel3.TabIndex = 21;
            this.kryptonLabel3.Values.Text = "הערות";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(991, 145);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 19);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kryptonLabel1.TabIndex = 20;
            this.kryptonLabel1.Values.Text = "משקל";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(1006, 190);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(28, 19);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kryptonLabel2.TabIndex = 31;
            this.kryptonLabel2.Values.Text = "שם";
            // 
            // nameTBX
            // 
            this.nameTBX.Location = new System.Drawing.Point(760, 190);
            this.nameTBX.Margin = new System.Windows.Forms.Padding(4);
            this.nameTBX.Name = "nameTBX";
            this.nameTBX.Size = new System.Drawing.Size(161, 27);
            this.nameTBX.TabIndex = 32;
            // 
            // CBXweight
            // 
            this.CBXweight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CBXweight.Location = new System.Drawing.Point(761, 145);
            this.CBXweight.Margin = new System.Windows.Forms.Padding(4);
            this.CBXweight.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CBXweight.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.CBXweight.Name = "CBXweight";
            this.CBXweight.Size = new System.Drawing.Size(160, 26);
            this.CBXweight.TabIndex = 36;
            this.CBXweight.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // ep2
            // 
            this.ep2.ContainerControl = this;
            // 
            // MTBprice
            // 
            this.MTBprice.Location = new System.Drawing.Point(789, 235);
            this.MTBprice.Margin = new System.Windows.Forms.Padding(4);
            this.MTBprice.Mask = "00000.00";
            this.MTBprice.Name = "MTBprice";
            this.MTBprice.Size = new System.Drawing.Size(132, 22);
            this.MTBprice.TabIndex = 39;
            this.MTBprice.ValidatingType = typeof(int);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(995, 235);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(39, 19);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.kryptonLabel5.TabIndex = 38;
            this.kryptonLabel5.Values.Text = "מחיר";
            // 
            // updatePack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1206, 554);
            this.Controls.Add(this.MTBprice);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.CBXweight);
            this.Controls.Add(this.nameTBX);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.notesTBX);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.choseCBX);
            this.Controls.Add(this.apdateButton);
            this.Controls.Add(this.kryptonLabel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "updatePack";
            this.Text = "updatePack";
            this.Load += new System.EventHandler(this.updatePack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomerTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep2)).EndInit();
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
        private Krypton.Toolkit.KryptonRichTextBox notesTBX;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.BindingSource userTBLBindingSource;
        private System.Windows.Forms.BindingSource costomerTBLBindingSource;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox nameTBX;
        private Krypton.Toolkit.KryptonNumericUpDown CBXweight;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ErrorProvider ep2;
        private System.Windows.Forms.MaskedTextBox MTBprice;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
    }
}