namespace YMN_STORE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Matura MT Script Capitals", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.HotPink;
            label1.Location = new Point(299, 40);
            label1.Name = "label1";
            label1.Size = new Size(544, 50);
            label1.TabIndex = 0;
            label1.Text = "MY  MUSIC STORE  ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rage Italic", 25F);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(152, 125);
            label2.Name = "label2";
            label2.Size = new Size(189, 53);
            label2.TabIndex = 1;
            label2.Text = "Get paid to";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Dutch801 XBd BT", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(324, 181);
            label3.Name = "label3";
            label3.Size = new Size(208, 53);
            label3.TabIndex = 2;
            label3.Text = "play your";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Cooper Black", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.HotPink;
            label4.Location = new Point(538, 232);
            label4.Name = "label4";
            label4.Size = new Size(160, 46);
            label4.TabIndex = 3;
            label4.Text = "MUSIC";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonShadow;
            button1.Location = new Point(463, 372);
            button1.Name = "button1";
            button1.Size = new Size(221, 87);
            button1.TabIndex = 4;
            button1.Text = "Join us";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-12, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1062, 624);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(255, 224, 192);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
