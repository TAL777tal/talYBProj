﻿namespace talYBProj.Forms
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
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.notesTBX = new Krypton.Toolkit.KryptonRichTextBox();
            this.weightNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.priceNumericUpDown = new Krypton.Toolkit.KryptonNumericUpDown();
            this.addButton = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(622, 78);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(44, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "משקל";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(622, 131);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(37, 20);
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "מחיר";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(623, 189);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "הערות";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(371, 26);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(105, 20);
            this.kryptonLabel4.TabIndex = 3;
            this.kryptonLabel4.Values.Text = "הוספת סוג חבילה";
            // 
            // notesTBX
            // 
            this.notesTBX.Location = new System.Drawing.Point(439, 189);
            this.notesTBX.Name = "notesTBX";
            this.notesTBX.Size = new System.Drawing.Size(161, 104);
            this.notesTBX.TabIndex = 5;
            this.notesTBX.Text = "";
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightNumericUpDown.Location = new System.Drawing.Point(480, 78);
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
            this.weightNumericUpDown.TabIndex = 6;
            this.weightNumericUpDown.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceNumericUpDown.Location = new System.Drawing.Point(480, 129);
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
            this.priceNumericUpDown.TabIndex = 7;
            this.priceNumericUpDown.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(371, 358);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 33);
            this.addButton.TabIndex = 8;
            this.addButton.Values.Text = "הוספה";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addPack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.weightNumericUpDown);
            this.Controls.Add(this.notesTBX);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Name = "addPack";
            this.Text = "addPack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonRichTextBox notesTBX;
        private Krypton.Toolkit.KryptonNumericUpDown weightNumericUpDown;
        private Krypton.Toolkit.KryptonNumericUpDown priceNumericUpDown;
        private Krypton.Toolkit.KryptonButton addButton;
    }
}