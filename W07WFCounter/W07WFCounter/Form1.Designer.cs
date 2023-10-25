namespace W07WFCounter
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
            label1 = new Label();
            btnAdd = new Button();
            btnSub = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Info;
            label1.Font = new Font("맑은 고딕", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(444, 236);
            label1.TabIndex = 0;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 248);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 60);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "증가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += onAdd;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(360, 248);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(96, 60);
            btnSub.TabIndex = 2;
            btnSub.Text = "감소";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += onSub;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 320);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "카운터";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnSub;
    }
}