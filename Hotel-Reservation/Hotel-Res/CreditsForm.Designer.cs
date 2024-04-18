namespace Hotel_Res
{
    partial class CreditsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsForm));
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(12, 9);
            button2.Name = "button2";
            button2.Size = new Size(68, 57);
            button2.TabIndex = 16;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Copperplate Gothic Light", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(204, 30);
            label5.Name = "label5";
            label5.Size = new Size(391, 52);
            label5.TabIndex = 20;
            label5.Text = "Дипломен Проект";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 105);
            label1.Name = "label1";
            label1.Size = new Size(588, 52);
            label1.TabIndex = 21;
            label1.Text = "Юлиян Велиславов Наумов";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Hotel_Res.Properties.Resources.commits;
            pictureBox1.Location = new Point(284, 347);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 91);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Hotel_Res.Properties.Resources.greenwall;
            pictureBox3.Location = new Point(340, 209);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(112, 109);
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // CreditsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 234, 245);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Name = "CreditsForm";
            Text = "CreditsForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Button button2;
        private Label label5;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}