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
            this.cbxZanName = new System.Windows.Forms.ComboBox();
            this.zanTBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apdateBtn
            // 
            this.apdateBtn.Location = new System.Drawing.Point(322, 378);
            this.apdateBtn.Name = "apdateBtn";
            this.apdateBtn.Size = new System.Drawing.Size(123, 30);
            this.apdateBtn.TabIndex = 11;
            this.apdateBtn.Values.Text = "עדכן";
            this.apdateBtn.Click += new System.EventHandler(this.apdateBtn_Click);
            // 
            // tbxDes
            // 
            this.tbxDes.Location = new System.Drawing.Point(434, 188);
            this.tbxDes.Name = "tbxDes";
            this.tbxDes.Size = new System.Drawing.Size(166, 152);
            this.tbxDes.TabIndex = 10;
            this.tbxDes.Text = "";
            // 
            // PresentLabel
            // 
            this.PresentLabel.Location = new System.Drawing.Point(352, 44);
            this.PresentLabel.Name = "PresentLabel";
            this.PresentLabel.Size = new System.Drawing.Size(45, 20);
            this.PresentLabel.TabIndex = 8;
            this.PresentLabel.Values.Text = "עדכן זן";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(663, 188);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(41, 20);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Values.Text = "תיאור";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(663, 134);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(48, 20);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Values.Text = "שם הזן";
            // 
            // cbxZanName
            // 
            this.cbxZanName.DataSource = this.zanTBLBindingSource;
            this.cbxZanName.DisplayMember = "name";
            this.cbxZanName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxZanName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxZanName.FormattingEnabled = true;
            this.cbxZanName.Location = new System.Drawing.Point(479, 133);
            this.cbxZanName.Name = "cbxZanName";
            this.cbxZanName.Size = new System.Drawing.Size(121, 21);
            this.cbxZanName.TabIndex = 12;
            this.cbxZanName.SelectedIndexChanged += new System.EventHandler(this.cbxZanName_SelectedIndexChanged);
            // 
            // zanTBLBindingSource
            // 
            this.zanTBLBindingSource.DataSource = typeof(talYBProj.zanTBL);
            // 
            // updateZanWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxZanName);
            this.Controls.Add(this.apdateBtn);
            this.Controls.Add(this.tbxDes);
            this.Controls.Add(this.PresentLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "updateZanWin";
            this.Text = "updateZanWin";
            ((System.ComponentModel.ISupportInitialize)(this.zanTBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton apdateBtn;
        private Krypton.Toolkit.KryptonRichTextBox tbxDes;
        private Krypton.Toolkit.KryptonLabel PresentLabel;
        private Krypton.Toolkit.KryptonLabel descriptionLabel;
        private Krypton.Toolkit.KryptonLabel nameLabel;
        private System.Windows.Forms.ComboBox cbxZanName;
        private System.Windows.Forms.BindingSource zanTBLBindingSource;
    }
}