namespace W10WFCardDealer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            card1 = new PictureBox();
            btnDeal = new Button();
            card2 = new PictureBox();
            card3 = new PictureBox();
            card4 = new PictureBox();
            card5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card5).BeginInit();
            SuspendLayout();
            // 
            // card1
            // 
            card1.Image = Properties.Resources._10_of_hearts;
            card1.Location = new Point(12, 12);
            card1.Name = "card1";
            card1.Size = new Size(170, 247);
            card1.SizeMode = PictureBoxSizeMode.Zoom;
            card1.TabIndex = 0;
            card1.TabStop = false;
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(364, 265);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(170, 247);
            btnDeal.TabIndex = 1;
            btnDeal.Text = "카드 분배";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += OnDeal;
            // 
            // card2
            // 
            card2.Image = Properties.Resources._10_of_hearts;
            card2.Location = new Point(188, 12);
            card2.Name = "card2";
            card2.Size = new Size(170, 247);
            card2.SizeMode = PictureBoxSizeMode.Zoom;
            card2.TabIndex = 0;
            card2.TabStop = false;
            // 
            // card3
            // 
            card3.Image = Properties.Resources._10_of_hearts;
            card3.Location = new Point(364, 12);
            card3.Name = "card3";
            card3.Size = new Size(170, 247);
            card3.SizeMode = PictureBoxSizeMode.Zoom;
            card3.TabIndex = 0;
            card3.TabStop = false;
            // 
            // card4
            // 
            card4.Image = Properties.Resources._10_of_hearts;
            card4.Location = new Point(12, 265);
            card4.Name = "card4";
            card4.Size = new Size(170, 247);
            card4.SizeMode = PictureBoxSizeMode.Zoom;
            card4.TabIndex = 0;
            card4.TabStop = false;
            // 
            // card5
            // 
            card5.Image = Properties.Resources._10_of_hearts;
            card5.Location = new Point(188, 265);
            card5.Name = "card5";
            card5.Size = new Size(170, 247);
            card5.SizeMode = PictureBoxSizeMode.Zoom;
            card5.TabIndex = 0;
            card5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 521);
            Controls.Add(btnDeal);
            Controls.Add(card3);
            Controls.Add(card5);
            Controls.Add(card2);
            Controls.Add(card4);
            Controls.Add(card1);
            Name = "Form1";
            Text = "카드 딜러";
            ((System.ComponentModel.ISupportInitialize)card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)card3).EndInit();
            ((System.ComponentModel.ISupportInitialize)card4).EndInit();
            ((System.ComponentModel.ISupportInitialize)card5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox card1;
        private Button btnDeal;
        private PictureBox card2;
        private PictureBox card3;
        private PictureBox card4;
        private PictureBox card5;
    }
}