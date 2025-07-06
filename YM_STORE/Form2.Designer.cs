namespace YMN_STORE
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            passwordTextBox = new TextBox();
            cPasswordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            panel2 = new Panel();
            errorMessage = new Label();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(559, 277);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(229, 43);
            passwordTextBox.TabIndex = 0;
            passwordTextBox.TextChanged += textBox1_TextChanged;
            // 
            // cPasswordTextBox
            // 
            cPasswordTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cPasswordTextBox.Location = new Point(559, 334);
            cPasswordTextBox.Name = "cPasswordTextBox";
            cPasswordTextBox.Size = new Size(229, 43);
            cPasswordTextBox.TabIndex = 1;
            cPasswordTextBox.TextChanged += textBox2_TextChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(559, 214);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(229, 43);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 216);
            label1.Name = "label1";
            label1.Size = new Size(182, 41);
            label1.TabIndex = 6;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(239, 277);
            label2.Name = "label2";
            label2.Size = new Size(177, 41);
            label2.TabIndex = 7;
            label2.Text = "password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(221, 334);
            label3.Name = "label3";
            label3.Size = new Size(315, 41);
            label3.TabIndex = 8;
            label3.Text = "confirm password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 72);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Pink;
            label5.Location = new Point(142, 92);
            label5.Name = "label5";
            label5.Size = new Size(677, 93);
            label5.TabIndex = 10;
            label5.Text = "Create account";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Pink;
            button1.Location = new Point(430, 442);
            button1.Name = "button1";
            button1.Size = new Size(239, 57);
            button1.TabIndex = 11;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(376, 355);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(-1, 531);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 64);
            panel2.TabIndex = 16;
            // 
            // errorMessage
            // 
            errorMessage.AutoSize = true;
            errorMessage.BackColor = Color.White;
            errorMessage.ForeColor = Color.Red;
            errorMessage.Location = new Point(432, 406);
            errorMessage.Name = "errorMessage";
            errorMessage.Size = new Size(0, 20);
            errorMessage.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(825, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 186);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Matura MT Script Capitals", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.HotPink;
            label7.Location = new Point(211, 22);
            label7.Name = "label7";
            label7.Size = new Size(544, 50);
            label7.TabIndex = 19;
            label7.Text = "MY  MUSIC STORE  ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(960, 550);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(errorMessage);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameTextBox);
            Controls.Add(cPasswordTextBox);
            Controls.Add(passwordTextBox);
            ForeColor = Color.PaleVioletRed;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passwordTextBox;
        private TextBox cPasswordTextBox;
        private TextBox usernameTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private Panel panel2;
        private Label errorMessage;
        private PictureBox pictureBox2;
        private Label label7;
    }
}