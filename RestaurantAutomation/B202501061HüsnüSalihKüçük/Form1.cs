using System;
using System.Windows.Forms;

namespace B202501061HüsnüSalihKüçük
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();

        string kAdi = "sSal1h", sifre = "s2841";

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==kAdi && textBox2.Text == sifre)
            {
                this.Hide();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı");
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Clear();

            if (textBox2.TextLength == 0)
            {
                textBox2.Text = "Şifre";
                textBox2.PasswordChar = '\0';
                label2.Visible = false;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox2.Clear();
            textBox2.PasswordChar = '*';

            if (textBox1.TextLength == 0)
            {
                textBox1.Text = "Kullanıcı Adı";
                label1.Visible = false;
            }
        }
    }
}
