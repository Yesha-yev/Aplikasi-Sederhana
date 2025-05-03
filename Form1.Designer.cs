namespace Aplikasi_Sederhana
{
    partial class TampilanDekstop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TampilanDekstop));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Welcoming = new Label();
            Log = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(397, 180);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 0, 0);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(397, 262);
            label2.Margin = new Padding(10, 0, 10, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Maroon;
            textBox1.Location = new Point(397, 220);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Maroon;
            textBox2.Location = new Point(397, 306);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Welcoming
            // 
            Welcoming.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Welcoming.AutoSize = true;
            Welcoming.BackColor = Color.Transparent;
            Welcoming.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Welcoming.ForeColor = Color.FromArgb(64, 0, 0);
            Welcoming.Location = new Point(358, 56);
            Welcoming.Name = "Welcoming";
            Welcoming.Size = new Size(242, 45);
            Welcoming.TabIndex = 4;
            Welcoming.Text = "Welcome Babe";
            // 
            // Log
            // 
            Log.BackColor = Color.FromArgb(64, 0, 0);
            Log.ForeColor = Color.White;
            Log.Location = new Point(555, 352);
            Log.Name = "Log";
            Log.Size = new Size(75, 23);
            Log.TabIndex = 5;
            Log.Text = "Login";
            Log.UseVisualStyleBackColor = false;
            Log.Click += Log_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(397, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // TampilanDekstop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(976, 554);
            Controls.Add(pictureBox1);
            Controls.Add(Log);
            Controls.Add(Welcoming);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TampilanDekstop";
            Text = "Desktop";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Welcoming;
        private Button Log;
        private PictureBox pictureBox1;
    }
}
