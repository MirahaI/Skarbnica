namespace Skarbnica
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnlDeck = new System.Windows.Forms.Panel();
            this.lSuite = new System.Windows.Forms.Label();
            this.bDiamond = new System.Windows.Forms.Button();
            this.bClub = new System.Windows.Forms.Button();
            this.bHeart = new System.Windows.Forms.Button();
            this.bSpade = new System.Windows.Forms.Button();
            this.lFigure = new System.Windows.Forms.Label();
            this.bSix = new System.Windows.Forms.Button();
            this.bSeven = new System.Windows.Forms.Button();
            this.bEight = new System.Windows.Forms.Button();
            this.bNine = new System.Windows.Forms.Button();
            this.bTen = new System.Windows.Forms.Button();
            this.bJack = new System.Windows.Forms.Button();
            this.bQueen = new System.Windows.Forms.Button();
            this.bKing = new System.Windows.Forms.Button();
            this.bAce = new System.Windows.Forms.Button();
            this.lNumber = new System.Windows.Forms.Label();
            this.bOne = new System.Windows.Forms.Button();
            this.bTwo = new System.Windows.Forms.Button();
            this.bThree = new System.Windows.Forms.Button();
            this.bFour = new System.Windows.Forms.Button();
            this.lp1 = new System.Windows.Forms.Label();
            this.lp2 = new System.Windows.Forms.Label();
            this.lp3 = new System.Windows.Forms.Label();
            this.lp4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl3
            // 
            this.pnl3.Location = new System.Drawing.Point(12, 12);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(332, 100);
            this.pnl3.TabIndex = 0;
            this.pnl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(12, 338);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(332, 100);
            this.pnl1.TabIndex = 1;
            // 
            // pnl4
            // 
            this.pnl4.Location = new System.Drawing.Point(456, 12);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(332, 100);
            this.pnl4.TabIndex = 2;
            // 
            // pnl2
            // 
            this.pnl2.Location = new System.Drawing.Point(456, 338);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(332, 100);
            this.pnl2.TabIndex = 3;
            // 
            // pnlDeck
            // 
            this.pnlDeck.Location = new System.Drawing.Point(12, 175);
            this.pnlDeck.Name = "pnlDeck";
            this.pnlDeck.Size = new System.Drawing.Size(98, 100);
            this.pnlDeck.TabIndex = 4;
            // 
            // lSuite
            // 
            this.lSuite.AutoSize = true;
            this.lSuite.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSuite.Location = new System.Drawing.Point(322, 116);
            this.lSuite.Name = "lSuite";
            this.lSuite.Size = new System.Drawing.Size(63, 28);
            this.lSuite.TabIndex = 5;
            this.lSuite.Text = "Suite";
            // 
            // bDiamond
            // 
            this.bDiamond.Location = new System.Drawing.Point(191, 147);
            this.bDiamond.Name = "bDiamond";
            this.bDiamond.Size = new System.Drawing.Size(75, 23);
            this.bDiamond.TabIndex = 6;
            this.bDiamond.Text = "♦";
            this.bDiamond.UseVisualStyleBackColor = true;
            // 
            // bClub
            // 
            this.bClub.Location = new System.Drawing.Point(272, 147);
            this.bClub.Name = "bClub";
            this.bClub.Size = new System.Drawing.Size(75, 23);
            this.bClub.TabIndex = 7;
            this.bClub.Text = "♣";
            this.bClub.UseVisualStyleBackColor = true;
            this.bClub.Click += new System.EventHandler(this.button2_Click);
            // 
            // bHeart
            // 
            this.bHeart.Location = new System.Drawing.Point(353, 147);
            this.bHeart.Name = "bHeart";
            this.bHeart.Size = new System.Drawing.Size(75, 23);
            this.bHeart.TabIndex = 8;
            this.bHeart.Text = "♥";
            this.bHeart.UseVisualStyleBackColor = true;
            // 
            // bSpade
            // 
            this.bSpade.Location = new System.Drawing.Point(434, 147);
            this.bSpade.Name = "bSpade";
            this.bSpade.Size = new System.Drawing.Size(75, 23);
            this.bSpade.TabIndex = 9;
            this.bSpade.Text = "♠";
            this.bSpade.UseVisualStyleBackColor = true;
            // 
            // lFigure
            // 
            this.lFigure.AutoSize = true;
            this.lFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFigure.Location = new System.Drawing.Point(369, 175);
            this.lFigure.Name = "lFigure";
            this.lFigure.Size = new System.Drawing.Size(73, 25);
            this.lFigure.TabIndex = 10;
            this.lFigure.Text = "Figure";
            // 
            // bSix
            // 
            this.bSix.Location = new System.Drawing.Point(191, 203);
            this.bSix.Name = "bSix";
            this.bSix.Size = new System.Drawing.Size(75, 23);
            this.bSix.TabIndex = 11;
            this.bSix.Text = "Six ";
            this.bSix.UseVisualStyleBackColor = true;
            // 
            // bSeven
            // 
            this.bSeven.Location = new System.Drawing.Point(272, 204);
            this.bSeven.Name = "bSeven";
            this.bSeven.Size = new System.Drawing.Size(75, 23);
            this.bSeven.TabIndex = 12;
            this.bSeven.Text = "Seven";
            this.bSeven.UseVisualStyleBackColor = true;
            // 
            // bEight
            // 
            this.bEight.Location = new System.Drawing.Point(353, 203);
            this.bEight.Name = "bEight";
            this.bEight.Size = new System.Drawing.Size(75, 23);
            this.bEight.TabIndex = 13;
            this.bEight.Text = "Eight";
            this.bEight.UseVisualStyleBackColor = true;
            // 
            // bNine
            // 
            this.bNine.Location = new System.Drawing.Point(434, 203);
            this.bNine.Name = "bNine";
            this.bNine.Size = new System.Drawing.Size(75, 23);
            this.bNine.TabIndex = 14;
            this.bNine.Text = "Nine";
            this.bNine.UseVisualStyleBackColor = true;
            // 
            // bTen
            // 
            this.bTen.Location = new System.Drawing.Point(515, 203);
            this.bTen.Name = "bTen";
            this.bTen.Size = new System.Drawing.Size(75, 23);
            this.bTen.TabIndex = 15;
            this.bTen.Text = "Ten";
            this.bTen.UseVisualStyleBackColor = true;
            // 
            // bJack
            // 
            this.bJack.Location = new System.Drawing.Point(596, 203);
            this.bJack.Name = "bJack";
            this.bJack.Size = new System.Drawing.Size(75, 23);
            this.bJack.TabIndex = 16;
            this.bJack.Text = "Jack";
            this.bJack.UseVisualStyleBackColor = true;
            // 
            // bQueen
            // 
            this.bQueen.Location = new System.Drawing.Point(677, 203);
            this.bQueen.Name = "bQueen";
            this.bQueen.Size = new System.Drawing.Size(75, 23);
            this.bQueen.TabIndex = 17;
            this.bQueen.Text = "Queen";
            this.bQueen.UseVisualStyleBackColor = true;
            // 
            // bKing
            // 
            this.bKing.Location = new System.Drawing.Point(191, 232);
            this.bKing.Name = "bKing";
            this.bKing.Size = new System.Drawing.Size(75, 23);
            this.bKing.TabIndex = 18;
            this.bKing.Text = "King";
            this.bKing.UseVisualStyleBackColor = true;
            // 
            // bAce
            // 
            this.bAce.Location = new System.Drawing.Point(272, 232);
            this.bAce.Name = "bAce";
            this.bAce.Size = new System.Drawing.Size(75, 23);
            this.bAce.TabIndex = 19;
            this.bAce.Text = "Ace";
            this.bAce.UseVisualStyleBackColor = true;
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNumber.Location = new System.Drawing.Point(322, 264);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(87, 25);
            this.lNumber.TabIndex = 20;
            this.lNumber.Text = "Number";
            // 
            // bOne
            // 
            this.bOne.Location = new System.Drawing.Point(191, 292);
            this.bOne.Name = "bOne";
            this.bOne.Size = new System.Drawing.Size(75, 23);
            this.bOne.TabIndex = 21;
            this.bOne.Text = "One";
            this.bOne.UseVisualStyleBackColor = true;
            // 
            // bTwo
            // 
            this.bTwo.Location = new System.Drawing.Point(272, 292);
            this.bTwo.Name = "bTwo";
            this.bTwo.Size = new System.Drawing.Size(75, 23);
            this.bTwo.TabIndex = 22;
            this.bTwo.Text = "Two";
            this.bTwo.UseVisualStyleBackColor = true;
            // 
            // bThree
            // 
            this.bThree.Location = new System.Drawing.Point(353, 292);
            this.bThree.Name = "bThree";
            this.bThree.Size = new System.Drawing.Size(75, 23);
            this.bThree.TabIndex = 23;
            this.bThree.Text = "Three";
            this.bThree.UseVisualStyleBackColor = true;
            // 
            // bFour
            // 
            this.bFour.Location = new System.Drawing.Point(434, 292);
            this.bFour.Name = "bFour";
            this.bFour.Size = new System.Drawing.Size(75, 23);
            this.bFour.TabIndex = 24;
            this.bFour.Text = "Four";
            this.bFour.UseVisualStyleBackColor = true;
            // 
            // lp1
            // 
            this.lp1.AutoSize = true;
            this.lp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lp1.Location = new System.Drawing.Point(12, 311);
            this.lp1.Name = "lp1";
            this.lp1.Size = new System.Drawing.Size(20, 24);
            this.lp1.TabIndex = 25;
            this.lp1.Text = "0";
            // 
            // lp2
            // 
            this.lp2.AutoSize = true;
            this.lp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lp2.Location = new System.Drawing.Point(768, 311);
            this.lp2.Name = "lp2";
            this.lp2.Size = new System.Drawing.Size(20, 24);
            this.lp2.TabIndex = 26;
            this.lp2.Text = "0";
            // 
            // lp3
            // 
            this.lp3.AutoSize = true;
            this.lp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lp3.Location = new System.Drawing.Point(768, 115);
            this.lp3.Name = "lp3";
            this.lp3.Size = new System.Drawing.Size(20, 24);
            this.lp3.TabIndex = 27;
            this.lp3.Text = "0";
            // 
            // lp4
            // 
            this.lp4.AutoSize = true;
            this.lp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lp4.Location = new System.Drawing.Point(15, 115);
            this.lp4.Name = "lp4";
            this.lp4.Size = new System.Drawing.Size(20, 24);
            this.lp4.TabIndex = 28;
            this.lp4.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lp4);
            this.Controls.Add(this.lp3);
            this.Controls.Add(this.lp2);
            this.Controls.Add(this.lp1);
            this.Controls.Add(this.bFour);
            this.Controls.Add(this.bThree);
            this.Controls.Add(this.bTwo);
            this.Controls.Add(this.bOne);
            this.Controls.Add(this.lNumber);
            this.Controls.Add(this.bAce);
            this.Controls.Add(this.bKing);
            this.Controls.Add(this.bQueen);
            this.Controls.Add(this.bJack);
            this.Controls.Add(this.bTen);
            this.Controls.Add(this.bNine);
            this.Controls.Add(this.bEight);
            this.Controls.Add(this.bSeven);
            this.Controls.Add(this.bSix);
            this.Controls.Add(this.lFigure);
            this.Controls.Add(this.bSpade);
            this.Controls.Add(this.bHeart);
            this.Controls.Add(this.bClub);
            this.Controls.Add(this.bDiamond);
            this.Controls.Add(this.lSuite);
            this.Controls.Add(this.pnlDeck);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.pnl3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnlDeck;
        private System.Windows.Forms.Label lSuite;
        private System.Windows.Forms.Button bDiamond;
        private System.Windows.Forms.Button bClub;
        private System.Windows.Forms.Button bHeart;
        private System.Windows.Forms.Button bSpade;
        private System.Windows.Forms.Label lFigure;
        private System.Windows.Forms.Button bSix;
        private System.Windows.Forms.Button bSeven;
        private System.Windows.Forms.Button bEight;
        private System.Windows.Forms.Button bNine;
        private System.Windows.Forms.Button bTen;
        private System.Windows.Forms.Button bJack;
        private System.Windows.Forms.Button bQueen;
        private System.Windows.Forms.Button bKing;
        private System.Windows.Forms.Button bAce;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Button bOne;
        private System.Windows.Forms.Button bTwo;
        private System.Windows.Forms.Button bThree;
        private System.Windows.Forms.Button bFour;
        private System.Windows.Forms.Label lp1;
        private System.Windows.Forms.Label lp2;
        private System.Windows.Forms.Label lp3;
        private System.Windows.Forms.Label lp4;
    }
}

