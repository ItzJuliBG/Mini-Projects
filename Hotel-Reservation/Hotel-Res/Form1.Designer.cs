namespace Hotel_Reservations
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(290, 104);
            button1.Name = "button1";
            button1.Size = new Size(226, 104);
            button1.TabIndex = 0;
            button1.Text = "Всички стаи";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(649, 52);
            label1.TabIndex = 1;
            label1.Text = "Хотел \"Continental\" *****";
            // 
            // button2
            // 
            button2.BackColor = Color.LavenderBlush;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Georgia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 202);
            button2.Name = "button2";
            button2.Size = new Size(212, 87);
            button2.TabIndex = 2;
            button2.Text = "Търсене на стая";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LavenderBlush;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Georgia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(576, 188);
            button4.Name = "button4";
            button4.Size = new Size(212, 50);
            button4.TabIndex = 4;
            button4.Text = "Изчисти стая";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LavenderBlush;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(290, 270);
            button3.Name = "button3";
            button3.Size = new Size(226, 104);
            button3.TabIndex = 5;
            button3.Text = "Направи резервация";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LavenderBlush;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(622, 397);
            button5.Name = "button5";
            button5.Size = new Size(166, 41);
            button5.TabIndex = 6;
            button5.Text = "Credits";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LavenderBlush;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Georgia", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(12, 397);
            button7.Name = "button7";
            button7.Size = new Size(117, 41);
            button7.TabIndex = 8;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LavenderBlush;
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Georgia", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(576, 244);
            button8.Name = "button8";
            button8.Size = new Size(212, 50);
            button8.TabIndex = 10;
            button8.Text = "Освободи стая";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(300, 411);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 234, 245);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox1;
    }
}