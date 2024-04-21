namespace Hotel_Res
{
    partial class CleanRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleanRoomForm));
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 23.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(153, 117);
            label1.Name = "label1";
            label1.Size = new Size(507, 36);
            label1.TabIndex = 0;
            label1.Text = "Номер на стая за изчистване:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.Font = new Font("Microsoft Sans Serif", 19.69F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(153, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(506, 37);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(68, 57);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(275, 295);
            button1.Name = "button1";
            button1.Size = new Size(253, 68);
            button1.TabIndex = 18;
            button1.Text = "Маркирай като изчистена";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(300, 411);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(207, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // CleanRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 234, 245);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CleanRoomForm";
            Text = "CleanRoomForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox4;
    }
}