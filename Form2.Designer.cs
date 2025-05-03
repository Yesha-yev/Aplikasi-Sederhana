namespace Aplikasi_Sederhana
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(54, 69);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(143, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cek Kondisi Psikologis\r\n";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(54, 111);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(106, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Jurnal Perasaan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(54, 154);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(72, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Relaksasi";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(54, 199);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(105, 19);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Edukasi & Artikel";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(54, 245);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(134, 19);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "Konsultasi / Bantuan";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(64, 0, 0);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.ForeColor = SystemColors.HighlightText;
            groupBox1.Location = new Point(106, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 333);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Halo, bagaimana perasaanmu hari ini?\nSilakan pilih salah satu menu di bawah ini:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private GroupBox groupBox1;
    }
}