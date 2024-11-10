namespace talYBProj
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ניהולמוצריםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הוספתמוצרToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עדכוןמוצרToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מחיקתמוצרToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ניהולמוצריםToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ניהולמוצריםToolStripMenuItem
            // 
            this.ניהולמוצריםToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הוספתמוצרToolStripMenuItem,
            this.עדכוןמוצרToolStripMenuItem,
            this.מחיקתמוצרToolStripMenuItem});
            this.ניהולמוצריםToolStripMenuItem.Name = "ניהולמוצריםToolStripMenuItem";
            this.ניהולמוצריםToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.ניהולמוצריםToolStripMenuItem.Text = "ניהול מוצרים";
            // 
            // הוספתמוצרToolStripMenuItem
            // 
            this.הוספתמוצרToolStripMenuItem.Name = "הוספתמוצרToolStripMenuItem";
            this.הוספתמוצרToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.הוספתמוצרToolStripMenuItem.Text = "הוספת מוצר";
            // 
            // עדכוןמוצרToolStripMenuItem
            // 
            this.עדכוןמוצרToolStripMenuItem.Name = "עדכוןמוצרToolStripMenuItem";
            this.עדכוןמוצרToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.עדכוןמוצרToolStripMenuItem.Text = "עדכון מוצר";
            // 
            // מחיקתמוצרToolStripMenuItem
            // 
            this.מחיקתמוצרToolStripMenuItem.Name = "מחיקתמוצרToolStripMenuItem";
            this.מחיקתמוצרToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.מחיקתמוצרToolStripMenuItem.Text = "מחיקת מוצר";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 113);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "מערכת לניהול הבית בד";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::talYBProj.Properties.Resources.תמונה_של_זית;
            this.pictureBox1.Location = new System.Drawing.Point(-105, -55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 167);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 310);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ניהולמוצריםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הוספתמוצרToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem עדכוןמוצרToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מחיקתמוצרToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

