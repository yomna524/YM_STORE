namespace YM_STORE
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            cashcheckbox = new CheckBox();
            checkBox2 = new CheckBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Matura MT Script Capitals", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LavenderBlush;
            label2.Location = new Point(334, 23);
            label2.Name = "label2";
            label2.Size = new Size(544, 50);
            label2.TabIndex = 1;
            label2.Text = "MY  MUSIC STORE  ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-15, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 91);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bookman Old Style", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Pink;
            label5.Location = new Point(413, 106);
            label5.Name = "label5";
            label5.Size = new Size(339, 70);
            label5.TabIndex = 11;
            label5.Text = "check out";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Engravers MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(41, 212);
            label1.Name = "label1";
            label1.Size = new Size(177, 21);
            label1.TabIndex = 12;
            label1.Text = "your total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.White;
            label3.Location = new Point(237, 212);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 13;
            label3.Text = "0";
            // 
            // cashcheckbox
            // 
            cashcheckbox.AutoSize = true;
            cashcheckbox.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cashcheckbox.ForeColor = Color.LavenderBlush;
            cashcheckbox.Location = new Point(53, 278);
            cashcheckbox.Name = "cashcheckbox";
            cashcheckbox.Size = new Size(107, 28);
            cashcheckbox.TabIndex = 14;
            cashcheckbox.Text = "cash";
            cashcheckbox.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = SystemColors.ControlLight;
            checkBox2.Location = new Point(53, 330);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(532, 28);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "deliver to your saved address";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(918, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Engravers MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Pink;
            button1.Location = new Point(488, 454);
            button1.Name = "button1";
            button1.Size = new Size(188, 37);
            button1.TabIndex = 18;
            button1.Text = "confirm ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(66, 462);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1164, 528);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox2);
            Controls.Add(cashcheckbox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private Label label5;
        private Label label1;
        private Label label3;
        private CheckBox cashcheckbox;
        private CheckBox checkBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}