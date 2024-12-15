namespace talYBProj.Forms
{
    partial class addOrderWin
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
            this.orderDateLabel = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLanguageManager1 = new Krypton.Toolkit.KryptonLanguageManager();
            this.oliveSpeciesLabel = new Krypton.Toolkit.KryptonLabel();
            this.numOfDolevimLabel = new Krypton.Toolkit.KryptonLabel();
            this.isDoneLabel = new Krypton.Toolkit.KryptonLabel();
            this.isPaydLabel = new Krypton.Toolkit.KryptonLabel();
            this.notesLabel = new Krypton.Toolkit.KryptonLabel();
            this.totalPaymentLabel = new Krypton.Toolkit.KryptonLabel();
            this.totalOliveLabel = new Krypton.Toolkit.KryptonLabel();
            this.totalOilLabel = new Krypton.Toolkit.KryptonLabel();
            this.numOfOilPacksLabel = new Krypton.Toolkit.KryptonLabel();
            this.orderPriceLabel = new Krypton.Toolkit.KryptonLabel();
            this.costomerNameLabel = new Krypton.Toolkit.KryptonLabel();
            this.TBXisDone = new Krypton.Toolkit.KryptonTextBox();
            this.TBXisPayd = new Krypton.Toolkit.KryptonTextBox();
            this.TBXnotes = new Krypton.Toolkit.KryptonRichTextBox();
            this.TBXnumOfDolevim = new Krypton.Toolkit.KryptonTextBox();
            this.TBXoliveSpecies = new Krypton.Toolkit.KryptonTextBox();
            this.TBXtotalPaynemt = new Krypton.Toolkit.KryptonTextBox();
            this.TBXtotalOlive = new Krypton.Toolkit.KryptonTextBox();
            this.TBXtotalOil = new Krypton.Toolkit.KryptonTextBox();
            this.TBXnumOfOilPacks = new Krypton.Toolkit.KryptonTextBox();
            this.TBXorderPrice = new Krypton.Toolkit.KryptonTextBox();
            this.TBXcostomerName = new Krypton.Toolkit.KryptonTextBox();
            this.kDTP = new Krypton.Toolkit.KryptonDateTimePicker();
            this.btnAddOrder = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.Location = new System.Drawing.Point(643, 87);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(88, 24);
            this.orderDateLabel.TabIndex = 0;
            this.orderDateLabel.Values.Text = "זמן ההזמנה";
            // 
            // oliveSpeciesLabel
            // 
            this.oliveSpeciesLabel.Location = new System.Drawing.Point(643, 120);
            this.oliveSpeciesLabel.Name = "oliveSpeciesLabel";
            this.oliveSpeciesLabel.Size = new System.Drawing.Size(68, 24);
            this.oliveSpeciesLabel.TabIndex = 1;
            this.oliveSpeciesLabel.Values.Text = "סוג הזית";
            // 
            // numOfDolevimLabel
            // 
            this.numOfDolevimLabel.Location = new System.Drawing.Point(643, 150);
            this.numOfDolevimLabel.Name = "numOfDolevimLabel";
            this.numOfDolevimLabel.Size = new System.Drawing.Size(98, 24);
            this.numOfDolevimLabel.TabIndex = 2;
            this.numOfDolevimLabel.Values.Text = "מספר דולבים";
            // 
            // isDoneLabel
            // 
            this.isDoneLabel.Location = new System.Drawing.Point(643, 180);
            this.isDoneLabel.Name = "isDoneLabel";
            this.isDoneLabel.Size = new System.Drawing.Size(146, 24);
            this.isDoneLabel.TabIndex = 3;
            this.isDoneLabel.Values.Text = "האם ההזמנה נסגרה";
            this.isDoneLabel.Click += new System.EventHandler(this.isDoneLabel_Click);
            // 
            // isPaydLabel
            // 
            this.isPaydLabel.Location = new System.Drawing.Point(643, 210);
            this.isPaydLabel.Name = "isPaydLabel";
            this.isPaydLabel.Size = new System.Drawing.Size(82, 24);
            this.isPaydLabel.TabIndex = 4;
            this.isPaydLabel.Values.Text = "האם שולם";
            // 
            // notesLabel
            // 
            this.notesLabel.Location = new System.Drawing.Point(643, 240);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(55, 24);
            this.notesLabel.TabIndex = 5;
            this.notesLabel.Values.Text = "הערות";
            // 
            // totalPaymentLabel
            // 
            this.totalPaymentLabel.Location = new System.Drawing.Point(254, 93);
            this.totalPaymentLabel.Name = "totalPaymentLabel";
            this.totalPaymentLabel.Size = new System.Drawing.Size(92, 24);
            this.totalPaymentLabel.TabIndex = 6;
            this.totalPaymentLabel.Values.Text = "סך התשלום";
            // 
            // totalOliveLabel
            // 
            this.totalOliveLabel.Location = new System.Drawing.Point(254, 126);
            this.totalOliveLabel.Name = "totalOliveLabel";
            this.totalOliveLabel.Size = new System.Drawing.Size(81, 24);
            this.totalOliveLabel.TabIndex = 7;
            this.totalOliveLabel.Values.Text = "סך הזיתים";
            // 
            // totalOilLabel
            // 
            this.totalOilLabel.Location = new System.Drawing.Point(254, 156);
            this.totalOilLabel.Name = "totalOilLabel";
            this.totalOilLabel.Size = new System.Drawing.Size(72, 24);
            this.totalOilLabel.TabIndex = 8;
            this.totalOilLabel.Values.Text = "סך השמן";
            // 
            // numOfOilPacksLabel
            // 
            this.numOfOilPacksLabel.Location = new System.Drawing.Point(254, 189);
            this.numOfOilPacksLabel.Name = "numOfOilPacksLabel";
            this.numOfOilPacksLabel.Size = new System.Drawing.Size(158, 24);
            this.numOfOilPacksLabel.TabIndex = 9;
            this.numOfOilPacksLabel.Values.Text = "מספר של חבילות שמן";
            this.numOfOilPacksLabel.Click += new System.EventHandler(this.kryptonLabel10_Click);
            // 
            // orderPriceLabel
            // 
            this.orderPriceLabel.Location = new System.Drawing.Point(254, 222);
            this.orderPriceLabel.Name = "orderPriceLabel";
            this.orderPriceLabel.Size = new System.Drawing.Size(92, 24);
            this.orderPriceLabel.TabIndex = 10;
            this.orderPriceLabel.Values.Text = "מחיר הזמנה";
            // 
            // costomerNameLabel
            // 
            this.costomerNameLabel.Location = new System.Drawing.Point(254, 252);
            this.costomerNameLabel.Name = "costomerNameLabel";
            this.costomerNameLabel.Size = new System.Drawing.Size(79, 24);
            this.costomerNameLabel.TabIndex = 11;
            this.costomerNameLabel.Values.Text = "שם הצרכן";
            // 
            // TBXisDone
            // 
            this.TBXisDone.Location = new System.Drawing.Point(521, 180);
            this.TBXisDone.Name = "TBXisDone";
            this.TBXisDone.Size = new System.Drawing.Size(100, 27);
            this.TBXisDone.TabIndex = 12;
            // 
            // TBXisPayd
            // 
            this.TBXisPayd.Location = new System.Drawing.Point(521, 213);
            this.TBXisPayd.Name = "TBXisPayd";
            this.TBXisPayd.Size = new System.Drawing.Size(100, 27);
            this.TBXisPayd.TabIndex = 13;
            // 
            // TBXnotes
            // 
            this.TBXnotes.Location = new System.Drawing.Point(447, 246);
            this.TBXnotes.Name = "TBXnotes";
            this.TBXnotes.Size = new System.Drawing.Size(174, 138);
            this.TBXnotes.TabIndex = 14;
            this.TBXnotes.Text = "";
            // 
            // TBXnumOfDolevim
            // 
            this.TBXnumOfDolevim.Location = new System.Drawing.Point(521, 147);
            this.TBXnumOfDolevim.Name = "TBXnumOfDolevim";
            this.TBXnumOfDolevim.Size = new System.Drawing.Size(100, 27);
            this.TBXnumOfDolevim.TabIndex = 15;
            // 
            // TBXoliveSpecies
            // 
            this.TBXoliveSpecies.Location = new System.Drawing.Point(521, 120);
            this.TBXoliveSpecies.Name = "TBXoliveSpecies";
            this.TBXoliveSpecies.Size = new System.Drawing.Size(100, 27);
            this.TBXoliveSpecies.TabIndex = 16;
            // 
            // TBXtotalPaynemt
            // 
            this.TBXtotalPaynemt.Location = new System.Drawing.Point(148, 90);
            this.TBXtotalPaynemt.Name = "TBXtotalPaynemt";
            this.TBXtotalPaynemt.Size = new System.Drawing.Size(100, 27);
            this.TBXtotalPaynemt.TabIndex = 18;
            // 
            // TBXtotalOlive
            // 
            this.TBXtotalOlive.Location = new System.Drawing.Point(148, 120);
            this.TBXtotalOlive.Name = "TBXtotalOlive";
            this.TBXtotalOlive.Size = new System.Drawing.Size(100, 27);
            this.TBXtotalOlive.TabIndex = 19;
            // 
            // TBXtotalOil
            // 
            this.TBXtotalOil.Location = new System.Drawing.Point(148, 153);
            this.TBXtotalOil.Name = "TBXtotalOil";
            this.TBXtotalOil.Size = new System.Drawing.Size(100, 27);
            this.TBXtotalOil.TabIndex = 20;
            // 
            // TBXnumOfOilPacks
            // 
            this.TBXnumOfOilPacks.Location = new System.Drawing.Point(148, 186);
            this.TBXnumOfOilPacks.Name = "TBXnumOfOilPacks";
            this.TBXnumOfOilPacks.Size = new System.Drawing.Size(100, 27);
            this.TBXnumOfOilPacks.TabIndex = 21;
            // 
            // TBXorderPrice
            // 
            this.TBXorderPrice.Location = new System.Drawing.Point(148, 219);
            this.TBXorderPrice.Name = "TBXorderPrice";
            this.TBXorderPrice.Size = new System.Drawing.Size(100, 27);
            this.TBXorderPrice.TabIndex = 22;
            // 
            // TBXcostomerName
            // 
            this.TBXcostomerName.Location = new System.Drawing.Point(148, 252);
            this.TBXcostomerName.Name = "TBXcostomerName";
            this.TBXcostomerName.Size = new System.Drawing.Size(100, 27);
            this.TBXcostomerName.TabIndex = 23;
            // 
            // kDTP
            // 
            this.kDTP.Location = new System.Drawing.Point(521, 86);
            this.kDTP.Name = "kDTP";
            this.kDTP.Size = new System.Drawing.Size(100, 25);
            this.kDTP.TabIndex = 24;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(327, 399);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(122, 25);
            this.btnAddOrder.TabIndex = 25;
            this.btnAddOrder.Values.Text = "הוסף הזמנה";
            // 
            // addOrderWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.kDTP);
            this.Controls.Add(this.TBXcostomerName);
            this.Controls.Add(this.TBXorderPrice);
            this.Controls.Add(this.TBXnumOfOilPacks);
            this.Controls.Add(this.TBXtotalOil);
            this.Controls.Add(this.TBXtotalOlive);
            this.Controls.Add(this.TBXtotalPaynemt);
            this.Controls.Add(this.TBXoliveSpecies);
            this.Controls.Add(this.TBXnumOfDolevim);
            this.Controls.Add(this.TBXnotes);
            this.Controls.Add(this.TBXisPayd);
            this.Controls.Add(this.TBXisDone);
            this.Controls.Add(this.costomerNameLabel);
            this.Controls.Add(this.orderPriceLabel);
            this.Controls.Add(this.numOfOilPacksLabel);
            this.Controls.Add(this.totalOilLabel);
            this.Controls.Add(this.totalOliveLabel);
            this.Controls.Add(this.totalPaymentLabel);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.isPaydLabel);
            this.Controls.Add(this.isDoneLabel);
            this.Controls.Add(this.numOfDolevimLabel);
            this.Controls.Add(this.oliveSpeciesLabel);
            this.Controls.Add(this.orderDateLabel);
            this.Name = "addOrderWin";
            this.Text = "addOrderWin";
            this.Load += new System.EventHandler(this.addOrderWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel orderDateLabel;
        private Krypton.Toolkit.KryptonLanguageManager kryptonLanguageManager1;
        private Krypton.Toolkit.KryptonLabel oliveSpeciesLabel;
        private Krypton.Toolkit.KryptonLabel numOfDolevimLabel;
        private Krypton.Toolkit.KryptonLabel isDoneLabel;
        private Krypton.Toolkit.KryptonLabel isPaydLabel;
        private Krypton.Toolkit.KryptonLabel notesLabel;
        private Krypton.Toolkit.KryptonLabel totalPaymentLabel;
        private Krypton.Toolkit.KryptonLabel totalOliveLabel;
        private Krypton.Toolkit.KryptonLabel totalOilLabel;
        private Krypton.Toolkit.KryptonLabel numOfOilPacksLabel;
        private Krypton.Toolkit.KryptonLabel orderPriceLabel;
        private Krypton.Toolkit.KryptonLabel costomerNameLabel;
        private Krypton.Toolkit.KryptonTextBox TBXisDone;
        private Krypton.Toolkit.KryptonTextBox TBXisPayd;
        private Krypton.Toolkit.KryptonRichTextBox TBXnotes;
        private Krypton.Toolkit.KryptonTextBox TBXnumOfDolevim;
        private Krypton.Toolkit.KryptonTextBox TBXoliveSpecies;
        private Krypton.Toolkit.KryptonTextBox TBXtotalPaynemt;
        private Krypton.Toolkit.KryptonTextBox TBXtotalOlive;
        private Krypton.Toolkit.KryptonTextBox TBXtotalOil;
        private Krypton.Toolkit.KryptonTextBox TBXnumOfOilPacks;
        private Krypton.Toolkit.KryptonTextBox TBXorderPrice;
        private Krypton.Toolkit.KryptonTextBox TBXcostomerName;
        private Krypton.Toolkit.KryptonDateTimePicker kDTP;
        private Krypton.Toolkit.KryptonButton btnAddOrder;
    }
}