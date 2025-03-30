namespace talYBProj.Forms
{
    partial class addZanWin
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
            this.nameLabel = new Krypton.Toolkit.KryptonLabel();
            this.descriptionLabel = new Krypton.Toolkit.KryptonLabel();
            this.PresentLabel = new Krypton.Toolkit.KryptonLabel();
            this.tbxZan = new Krypton.Toolkit.KryptonTextBox();
            this.tbxDes = new Krypton.Toolkit.KryptonRichTextBox();
            this.addBtn = new Krypton.Toolkit.KryptonButton();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(832, 106);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 24);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Values.Text = "שם הזן";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(832, 185);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(49, 24);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Values.Text = "תיאור";
            // 
            // PresentLabel
            // 
            this.PresentLabel.Location = new System.Drawing.Point(459, 36);
            this.PresentLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PresentLabel.Name = "PresentLabel";
            this.PresentLabel.Size = new System.Drawing.Size(60, 24);
            this.PresentLabel.TabIndex = 2;
            this.PresentLabel.Values.Text = "הוסף זן";
            // 
            // tbxZan
            // 
            this.tbxZan.Location = new System.Drawing.Point(649, 106);
            this.tbxZan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxZan.Name = "tbxZan";
            this.tbxZan.Size = new System.Drawing.Size(133, 27);
            this.tbxZan.TabIndex = 3;
            // 
            // tbxDes
            // 
            this.tbxDes.Location = new System.Drawing.Point(561, 185);
            this.tbxDes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDes.Name = "tbxDes";
            this.tbxDes.Size = new System.Drawing.Size(221, 187);
            this.tbxDes.TabIndex = 4;
            this.tbxDes.Text = "";
            this.tbxDes.TextChanged += new System.EventHandler(this.kryptonRichTextBox1_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(429, 436);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(164, 37);
            this.addBtn.TabIndex = 5;
            this.addBtn.Values.Text = "הוסף";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // addZanWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.tbxDes);
            this.Controls.Add(this.tbxZan);
            this.Controls.Add(this.PresentLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addZanWin";
            this.Text = "addZanWin";
            this.Load += new System.EventHandler(this.addZanWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel nameLabel;
        private Krypton.Toolkit.KryptonLabel descriptionLabel;
        private Krypton.Toolkit.KryptonLabel PresentLabel;
        private Krypton.Toolkit.KryptonTextBox tbxZan;
        private Krypton.Toolkit.KryptonRichTextBox tbxDes;
        private Krypton.Toolkit.KryptonButton addBtn;
        private System.Windows.Forms.ErrorProvider ep;
    }
}