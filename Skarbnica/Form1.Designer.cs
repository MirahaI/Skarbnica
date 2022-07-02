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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnlDeck = new System.Windows.Forms.Panel();
            this.lSuite = new System.Windows.Forms.Label();
            this.lFigure = new System.Windows.Forms.Label();
            this.bSeven = new System.Windows.Forms.Button();
            this.bEight = new System.Windows.Forms.Button();
            this.bNine = new System.Windows.Forms.Button();
            this.bTen = new System.Windows.Forms.Button();
            this.bJack = new System.Windows.Forms.Button();
            this.bQueen = new System.Windows.Forms.Button();
            this.bKing = new System.Windows.Forms.Button();
            this.bAce = new System.Windows.Forms.Button();
            this.lp1 = new System.Windows.Forms.Label();
            this.lp2 = new System.Windows.Forms.Label();
            this.lp3 = new System.Windows.Forms.Label();
            this.lp4 = new System.Windows.Forms.Label();
            this.pnlFigure = new System.Windows.Forms.Panel();
            this.bSix = new System.Windows.Forms.Button();
            this.ForFigure = new System.Windows.Forms.Button();
            this.pnlSuite = new System.Windows.Forms.Panel();
            this.bAsk = new System.Windows.Forms.Button();
            this.checkSpade = new System.Windows.Forms.CheckBox();
            this.checkHeart = new System.Windows.Forms.CheckBox();
            this.checkClub = new System.Windows.Forms.CheckBox();
            this.checkDiamond = new System.Windows.Forms.CheckBox();
            this.pnlNumber = new System.Windows.Forms.Panel();
            this.ForNumber = new System.Windows.Forms.Button();
            this.bthree = new System.Windows.Forms.Button();
            this.btwo = new System.Windows.Forms.Button();
            this.bone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lres = new System.Windows.Forms.Label();
            this.pnlFigure.SuspendLayout();
            this.pnlSuite.SuspendLayout();
            this.pnlNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(12, 12);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(332, 100);
            this.pnl1.TabIndex = 0;
            // 
            // pnl4
            // 
            this.pnl4.Location = new System.Drawing.Point(12, 338);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(332, 100);
            this.pnl4.TabIndex = 1;
            // 
            // pnl2
            // 
            this.pnl2.Location = new System.Drawing.Point(456, 12);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(332, 100);
            this.pnl2.TabIndex = 2;
            // 
            // pnl3
            // 
            this.pnl3.Location = new System.Drawing.Point(456, 338);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(332, 100);
            this.pnl3.TabIndex = 3;
            // 
            // pnlDeck
            // 
            this.pnlDeck.Location = new System.Drawing.Point(16, 173);
            this.pnlDeck.Name = "pnlDeck";
            this.pnlDeck.Size = new System.Drawing.Size(203, 135);
            this.pnlDeck.TabIndex = 4;
            // 
            // lSuite
            // 
            this.lSuite.AutoSize = true;
            this.lSuite.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSuite.Location = new System.Drawing.Point(3, 10);
            this.lSuite.Name = "lSuite";
            this.lSuite.Size = new System.Drawing.Size(63, 28);
            this.lSuite.TabIndex = 5;
            this.lSuite.Text = "Suite";
            // 
            // lFigure
            // 
            this.lFigure.AutoSize = true;
            this.lFigure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFigure.Location = new System.Drawing.Point(52, 6);
            this.lFigure.Name = "lFigure";
            this.lFigure.Size = new System.Drawing.Size(73, 25);
            this.lFigure.TabIndex = 10;
            this.lFigure.Text = "Figure";
            // 
            // bSeven
            // 
            this.bSeven.Location = new System.Drawing.Point(84, 34);
            this.bSeven.Name = "bSeven";
            this.bSeven.Size = new System.Drawing.Size(75, 23);
            this.bSeven.TabIndex = 12;
            this.bSeven.Text = "Seven";
            this.bSeven.UseVisualStyleBackColor = true;
            this.bSeven.Click += new System.EventHandler(this.ForFigure_Click);
            // 
            // bEight
            // 
            this.bEight.Location = new System.Drawing.Point(3, 63);
            this.bEight.Name = "bEight";
            this.bEight.Size = new System.Drawing.Size(75, 23);
            this.bEight.TabIndex = 13;
            this.bEight.Text = "Eight";
            this.bEight.UseVisualStyleBackColor = true;
            this.bEight.Click += new System.EventHandler(this.ForFigure_Click);
            // 
            // bNine
            // 
            this.bNine.Location = new System.Drawing.Point(84, 63);
            this.bNine.Name = "bNine";
            this.bNine.Size = new System.Drawing.Size(75, 23);
            this.bNine.TabIndex = 14;
            this.bNine.Text = "Nine";
            this.bNine.UseVisualStyleBackColor = true;
            this.bNine.Click += new System.EventHandler(this.ForFigure_Click);
            // 
            // bTen
            // 
            this.bTen.Location = new System.Drawing.Point(3, 92);
            this.bTen.Name = "bTen";
            this.bTen.Size = new System.Drawing.Size(75, 23);
            this.bTen.TabIndex = 15;
            this.bTen.Text = "Ten";
            this.bTen.UseVisualStyleBackColor = true;
            this.bTen.Click += new System.EventHandler(this.ForFigure_Click);
            // 
            // bJack
            // 
            this.bJack.Location = new System.Drawing.Point(84, 92);
            this.bJack.Name = "bJack";
            this.bJack.Size = new System.Drawing.Size(75, 23);
            this.bJack.TabIndex = 16;
            this.bJack.Text = "Jack";
            this.bJack.UseVisualStyleBackColor = true;
            this.bJack.Click += new System.EventHandler(this.ForFigure_Click);
            // 
            // bQueen
            // 
            this.bQueen.Location = new System.Drawing.Point(3, 121);
            this.bQueen.Name = "bQueen";
            this.bQueen.Size = new System.Drawing.Size(75, 23);
            this.bQueen.TabIndex = 17;
            this.bQueen.Text = "Queen";
            this.bQueen.UseVisualStyleBackColor = true;
            this.bQueen.Click += new System.EventHandler(this.ForFigure_Click);
            // 
            // bKing
            // 
            this.bKing.Location = new System.Drawing.Point(84, 121);
            this.bKing.Name = "bKing";
            this.bKing.Size = new System.Drawing.Size(75, 23);
            this.bKing.TabIndex = 18;
            this.bKing.Text = "King";
            this.bKing.UseVisualStyleBackColor = true;
            this.bKing.Click += new System.EventHandler(this.ForFigure_Click);
            // 
            // bAce
            // 
            this.bAce.Location = new System.Drawing.Point(50, 150);
            this.bAce.Name = "bAce";
            this.bAce.Size = new System.Drawing.Size(75, 23);
            this.bAce.TabIndex = 19;
            this.bAce.Text = "Ace";
            this.bAce.UseVisualStyleBackColor = true;
            this.bAce.Click += new System.EventHandler(this.ForFigure_Click);
            // 
            // lp1
            // 
            this.lp1.AutoSize = true;
            this.lp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lp1.Location = new System.Drawing.Point(12, 118);
            this.lp1.Name = "lp1";
            this.lp1.Size = new System.Drawing.Size(20, 24);
            this.lp1.TabIndex = 25;
            this.lp1.Text = "0";
            // 
            // lp2
            // 
            this.lp2.AutoSize = true;
            this.lp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lp2.Location = new System.Drawing.Point(768, 116);
            this.lp2.Name = "lp2";
            this.lp2.Size = new System.Drawing.Size(20, 24);
            this.lp2.TabIndex = 26;
            this.lp2.Text = "0";
            // 
            // lp3
            // 
            this.lp3.AutoSize = true;
            this.lp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lp3.Location = new System.Drawing.Point(768, 311);
            this.lp3.Name = "lp3";
            this.lp3.Size = new System.Drawing.Size(20, 24);
            this.lp3.TabIndex = 27;
            this.lp3.Text = "0";
            // 
            // lp4
            // 
            this.lp4.AutoSize = true;
            this.lp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lp4.Location = new System.Drawing.Point(12, 311);
            this.lp4.Name = "lp4";
            this.lp4.Size = new System.Drawing.Size(20, 24);
            this.lp4.TabIndex = 28;
            this.lp4.Text = "0";
            // 
            // pnlFigure
            // 
            this.pnlFigure.Controls.Add(this.bSix);
            this.pnlFigure.Controls.Add(this.ForFigure);
            this.pnlFigure.Controls.Add(this.lFigure);
            this.pnlFigure.Controls.Add(this.bSeven);
            this.pnlFigure.Controls.Add(this.bEight);
            this.pnlFigure.Controls.Add(this.bNine);
            this.pnlFigure.Controls.Add(this.bAce);
            this.pnlFigure.Controls.Add(this.bTen);
            this.pnlFigure.Controls.Add(this.bKing);
            this.pnlFigure.Controls.Add(this.bJack);
            this.pnlFigure.Controls.Add(this.bQueen);
            this.pnlFigure.Location = new System.Drawing.Point(236, 118);
            this.pnlFigure.Name = "pnlFigure";
            this.pnlFigure.Size = new System.Drawing.Size(163, 203);
            this.pnlFigure.TabIndex = 29;
            // 
            // bSix
            // 
            this.bSix.Location = new System.Drawing.Point(3, 34);
            this.bSix.Name = "bSix";
            this.bSix.Size = new System.Drawing.Size(75, 23);
            this.bSix.TabIndex = 34;
            this.bSix.Text = "Six";
            this.bSix.UseVisualStyleBackColor = true;
            this.bSix.Click += new System.EventHandler(this.ForFigure_Click);
            // 
            // ForFigure
            // 
            this.ForFigure.Location = new System.Drawing.Point(3, 3);
            this.ForFigure.Name = "ForFigure";
            this.ForFigure.Size = new System.Drawing.Size(43, 23);
            this.ForFigure.TabIndex = 20;
            this.ForFigure.Text = "fig";
            this.ForFigure.UseVisualStyleBackColor = true;
            this.ForFigure.Visible = false;
            this.ForFigure.Click += new System.EventHandler(this.ForFigure_Click);
            // 
            // pnlSuite
            // 
            this.pnlSuite.Controls.Add(this.bAsk);
            this.pnlSuite.Controls.Add(this.checkSpade);
            this.pnlSuite.Controls.Add(this.checkHeart);
            this.pnlSuite.Controls.Add(this.checkClub);
            this.pnlSuite.Controls.Add(this.checkDiamond);
            this.pnlSuite.Controls.Add(this.lSuite);
            this.pnlSuite.Location = new System.Drawing.Point(405, 224);
            this.pnlSuite.Name = "pnlSuite";
            this.pnlSuite.Size = new System.Drawing.Size(163, 97);
            this.pnlSuite.TabIndex = 31;
            // 
            // bAsk
            // 
            this.bAsk.Location = new System.Drawing.Point(99, 10);
            this.bAsk.Name = "bAsk";
            this.bAsk.Size = new System.Drawing.Size(61, 23);
            this.bAsk.TabIndex = 10;
            this.bAsk.Text = "Ask";
            this.bAsk.UseVisualStyleBackColor = true;
            this.bAsk.Click += new System.EventHandler(this.bAsk_Click);
            // 
            // checkSpade
            // 
            this.checkSpade.AutoSize = true;
            this.checkSpade.Location = new System.Drawing.Point(122, 50);
            this.checkSpade.Name = "checkSpade";
            this.checkSpade.Size = new System.Drawing.Size(38, 17);
            this.checkSpade.TabIndex = 9;
            this.checkSpade.Text = "♠";
            this.checkSpade.UseVisualStyleBackColor = true;
            // 
            // checkHeart
            // 
            this.checkHeart.AutoSize = true;
            this.checkHeart.Location = new System.Drawing.Point(85, 50);
            this.checkHeart.Name = "checkHeart";
            this.checkHeart.Size = new System.Drawing.Size(38, 17);
            this.checkHeart.TabIndex = 8;
            this.checkHeart.Text = "♥";
            this.checkHeart.UseVisualStyleBackColor = true;
            // 
            // checkClub
            // 
            this.checkClub.AutoSize = true;
            this.checkClub.Location = new System.Drawing.Point(48, 50);
            this.checkClub.Name = "checkClub";
            this.checkClub.Size = new System.Drawing.Size(38, 17);
            this.checkClub.TabIndex = 7;
            this.checkClub.Text = "♣";
            this.checkClub.UseVisualStyleBackColor = true;
            // 
            // checkDiamond
            // 
            this.checkDiamond.AutoSize = true;
            this.checkDiamond.Location = new System.Drawing.Point(8, 50);
            this.checkDiamond.Name = "checkDiamond";
            this.checkDiamond.Size = new System.Drawing.Size(37, 17);
            this.checkDiamond.TabIndex = 6;
            this.checkDiamond.Text = "♦";
            this.checkDiamond.UseVisualStyleBackColor = true;
            // 
            // pnlNumber
            // 
            this.pnlNumber.Controls.Add(this.ForNumber);
            this.pnlNumber.Controls.Add(this.bthree);
            this.pnlNumber.Controls.Add(this.btwo);
            this.pnlNumber.Controls.Add(this.bone);
            this.pnlNumber.Controls.Add(this.label1);
            this.pnlNumber.Location = new System.Drawing.Point(405, 118);
            this.pnlNumber.Name = "pnlNumber";
            this.pnlNumber.Size = new System.Drawing.Size(163, 100);
            this.pnlNumber.TabIndex = 32;
            // 
            // ForNumber
            // 
            this.ForNumber.Location = new System.Drawing.Point(1, 1);
            this.ForNumber.Name = "ForNumber";
            this.ForNumber.Size = new System.Drawing.Size(44, 23);
            this.ForNumber.TabIndex = 24;
            this.ForNumber.Text = "num";
            this.ForNumber.UseVisualStyleBackColor = true;
            this.ForNumber.Visible = false;
            this.ForNumber.Click += new System.EventHandler(this.ForNumber_Click);
            // 
            // bthree
            // 
            this.bthree.Location = new System.Drawing.Point(48, 71);
            this.bthree.Name = "bthree";
            this.bthree.Size = new System.Drawing.Size(75, 23);
            this.bthree.TabIndex = 22;
            this.bthree.Text = "Three";
            this.bthree.UseVisualStyleBackColor = true;
            this.bthree.Click += new System.EventHandler(this.ForNumber_Click);
            // 
            // btwo
            // 
            this.btwo.Location = new System.Drawing.Point(85, 43);
            this.btwo.Name = "btwo";
            this.btwo.Size = new System.Drawing.Size(75, 23);
            this.btwo.TabIndex = 21;
            this.btwo.Text = "Two";
            this.btwo.UseVisualStyleBackColor = true;
            this.btwo.Click += new System.EventHandler(this.ForNumber_Click);
            // 
            // bone
            // 
            this.bone.Location = new System.Drawing.Point(3, 42);
            this.bone.Name = "bone";
            this.bone.Size = new System.Drawing.Size(75, 23);
            this.bone.TabIndex = 20;
            this.bone.Text = "One";
            this.bone.UseVisualStyleBackColor = true;
            this.bone.Click += new System.EventHandler(this.ForNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Number";
            // 
            // lres
            // 
            this.lres.AllowDrop = true;
            this.lres.AutoSize = true;
            this.lres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lres.Location = new System.Drawing.Point(574, 155);
            this.lres.Name = "lres";
            this.lres.Size = new System.Drawing.Size(98, 20);
            this.lres.TabIndex = 33;
            this.lres.Text = "Result Info";
            this.lres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.lres);
            this.Controls.Add(this.pnlNumber);
            this.Controls.Add(this.pnlSuite);
            this.Controls.Add(this.pnlFigure);
            this.Controls.Add(this.lp4);
            this.Controls.Add(this.lp3);
            this.Controls.Add(this.lp2);
            this.Controls.Add(this.lp1);
            this.Controls.Add(this.pnlDeck);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl4);
            this.Controls.Add(this.pnl1);
            this.Name = "Form1";
            this.Text = "`";
            this.pnlFigure.ResumeLayout(false);
            this.pnlFigure.PerformLayout();
            this.pnlSuite.ResumeLayout(false);
            this.pnlSuite.PerformLayout();
            this.pnlNumber.ResumeLayout(false);
            this.pnlNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnlDeck;
        private System.Windows.Forms.Label lSuite;
        private System.Windows.Forms.Label lFigure;
        private System.Windows.Forms.Button bSeven;
        private System.Windows.Forms.Button bEight;
        private System.Windows.Forms.Button bNine;
        private System.Windows.Forms.Button bTen;
        private System.Windows.Forms.Button bJack;
        private System.Windows.Forms.Button bQueen;
        private System.Windows.Forms.Button bKing;
        private System.Windows.Forms.Button bAce;
        private System.Windows.Forms.Label lp1;
        private System.Windows.Forms.Label lp2;
        private System.Windows.Forms.Label lp3;
        private System.Windows.Forms.Label lp4;
        private System.Windows.Forms.Panel pnlFigure;
        private System.Windows.Forms.Panel pnlSuite;
        private System.Windows.Forms.Button bAsk;
        private System.Windows.Forms.Panel pnlNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bthree;
        private System.Windows.Forms.Button btwo;
        private System.Windows.Forms.Button bone;
        private System.Windows.Forms.Label lres;
        private System.Windows.Forms.Button ForFigure;
        private System.Windows.Forms.Button ForNumber;
        private System.Windows.Forms.Button bSix;
        private System.Windows.Forms.CheckBox checkSpade;
        private System.Windows.Forms.CheckBox checkHeart;
        private System.Windows.Forms.CheckBox checkClub;
        private System.Windows.Forms.CheckBox checkDiamond;
    }
}

