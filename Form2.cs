﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Sederhana
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    bool buttonclick = false;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonclick = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            if (radioButton1.Checked && buttonclick)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }

        }
    }
}
