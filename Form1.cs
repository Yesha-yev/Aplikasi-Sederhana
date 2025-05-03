namespace Aplikasi_Sederhana
{
    public partial class TampilanDekstop : Form
    {
        private string Admin = "Fia";
        private string Password = "12345";
        public TampilanDekstop()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Log_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

            if (textBox1.Text == Admin && textBox2.Text == Password)
            {
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
