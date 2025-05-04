using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Aplikasi_Sederhana
{
    public partial class Form4 : Form
    {
        WindowsMediaPlayer player;
        public Form4()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();

        }

        private void putar()
        {
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.URL = @"C:\Users\Owner\Videos\Captures\Ava_Max_ - _Sweet_But_Psycho_•_Suicide_Squad_Edition(360p).mp4";
            axWindowsMediaPlayer1.SendToBack();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            putar();
        }
    bool buttonclk = false;
        private void button1_Click(object sender, EventArgs e)
        {
            player.URL = @"C:\Users\Owner\Music\y2mate.com - Bruno Mars  It Will Rain Official Music Video.mp3";
            player.controls.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.URL = @"C:\Users\Owner\Videos\Captures\Ava_Max_-_Sweet_But_Psycho_•_Suicide_Squad_Edition(360p).mp4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonclk = true;
            if (buttonclk)
            {
                putar();
            }
        }
    }
}
