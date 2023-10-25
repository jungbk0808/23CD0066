namespace W09WFImage
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
            pictureBox1 = new PictureBox();
            btnImageChange = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.moon;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(563, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnImageChange
            // 
            btnImageChange.FlatStyle = FlatStyle.System;
            btnImageChange.Location = new Point(12, 292);
            btnImageChange.Name = "btnImageChange";
            btnImageChange.Size = new Size(563, 62);
            btnImageChange.TabIndex = 1;
            btnImageChange.Text = "눌러보세요";
            btnImageChange.UseVisualStyleBackColor = true;
            btnImageChange.Click += btnImageChange_Click;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 366);
            Controls.Add(btnImageChange);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Image";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnImageChange;
    }
}