﻿namespace talYBProj.Forms
{
    partial class updateZanWin
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
            this.apdateBtn = new Krypton.Toolkit.KryptonButton();
            this.tbxDes = new Krypton.Toolkit.KryptonRichTextBox();
            this.PresentLabel = new Krypton.Toolkit.KryptonLabel();
            this.descriptionLabel = new Krypton.Toolkit.KryptonLabel();
            this.nameLabel = new Krypton.Toolkit.KryptonLabel();
            this.zanTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxZanName = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxZanName)).BeginInit();
            this.SuspendLayout();
            // 
            // apdateBtn
            // 
            this.apdateBtn.Location = new System.Drawing.Point(436, 459);
            this.apdateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apdateBtn.Name = "apdateBtn";
            this.apdateBtn.Size = new System.Drawing.Size(192, 61);
            this.apdateBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.apdateBtn.TabIndex = 11;
            this.apdateBtn.Values.Text = "עדכן";
            this.apdateBtn.Click += new System.EventHandler(this.apdateBtn_Click);
            // 
            // tbxDes
            // 
            this.tbxDes.Location = new System.Drawing.Point(579, 231);
            this.tbxDes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDes.Name = "tbxDes";
            this.tbxDes.Size = new System.Drawing.Size(221, 187);
            this.tbxDes.TabIndex = 10;
            this.tbxDes.Text = "";
            // 
            // PresentLabel
            // 
            this.PresentLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.PresentLabel.Location = new System.Drawing.Point(478, 41);
            this.PresentLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PresentLabel.Name = "PresentLabel";
            this.PresentLabel.Size = new System.Drawing.Size(58, 24);
            this.PresentLabel.TabIndex = 8;
            this.PresentLabel.Values.Text = "עדכן זן";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.descriptionLabel.Location = new System.Drawing.Point(884, 231);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(53, 24);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Values.Text = "תיאור";
            // 
            // nameLabel
            // 
            this.nameLabel.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.nameLabel.Location = new System.Drawing.Point(875, 165);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(60, 24);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Values.Text = "שם הזן";
            // 
            // zanTBLBindingSource
            // 
            this.zanTBLBindingSource.DataSource = typeof(talYBProj.zanTBL);
            // 
            // cbxZanName
            // 
            this.cbxZanName.DataSource = this.zanTBLBindingSource;
            this.cbxZanName.DisplayMember = "name";
            this.cbxZanName.DropDownWidth = 121;
            this.cbxZanName.IntegralHeight = false;
            this.cbxZanName.Location = new System.Drawing.Point(639, 163);
            this.cbxZanName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxZanName.Name = "cbxZanName";
            this.cbxZanName.Size = new System.Drawing.Size(161, 26);
            this.cbxZanName.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxZanName.TabIndex = 13;
            this.cbxZanName.SelectedIndexChanged += new System.EventHandler(this.cbxZanName_SelectedIndexChanged_1);
            // 
            // updateZanWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbxZanName);
            this.Controls.Add(this.apdateBtn);
            this.Controls.Add(this.tbxDes);
            this.Controls.Add(this.PresentLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "updateZanWin";
            this.Text = "updateZanWin";
            this.Load += new System.EventHandler(this.updateZanWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxZanName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton apdateBtn;
        private Krypton.Toolkit.KryptonRichTextBox tbxDes;
        private Krypton.Toolkit.KryptonLabel PresentLabel;
        private Krypton.Toolkit.KryptonLabel descriptionLabel;
        private Krypton.Toolkit.KryptonLabel nameLabel;
        private System.Windows.Forms.BindingSource zanTBLBindingSource;
        private Krypton.Toolkit.KryptonComboBox cbxZanName;
    }
}