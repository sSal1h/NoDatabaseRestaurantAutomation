using System;
using System.Drawing;
using System.Windows.Forms;

namespace B202501061HüsnüSalihKüçük
{
    public partial class Form2 : Form
    {
        public static byte mNo = 0;
        public static string[,] sip = new string[10, 100];
        public static byte[,] sipA = new byte[10, 100];
        public static byte[,] sipF = new byte[10, 100];
        public static byte[,] sipN =new byte[10,1];

        public Form2()
        {
            InitializeComponent();
        }

        public void masaAc(byte mId)
        {
            Form3 f3 = new Form3();
            mNo = mId;
            f3.Text = "Masa " + mId;
            f3.Owner = this;
            f3.ShowDialog();
        }

        public void mdb(Byte mN)
        {
            if (sipN[mN, 0] == 0)
            {
                switch (mN)
                {
                    case 1: button1.BackColor = Color.FromArgb(128, 255, 128); break;
                    case 2: button2.BackColor = Color.FromArgb(128, 255, 128); break;
                    case 3: button3.BackColor = Color.FromArgb(128, 255, 128); break;
                    case 4: button4.BackColor = Color.FromArgb(128, 255, 128); break;
                    case 5: button5.BackColor = Color.FromArgb(128, 255, 128); break;
                    case 6: button6.BackColor = Color.FromArgb(128, 255, 128); break;
                    case 7: button7.BackColor = Color.FromArgb(128, 255, 128); break;
                    case 8: button8.BackColor = Color.FromArgb(128, 255, 128); break;
                    case 9: button9.BackColor = Color.FromArgb(128, 255, 128); break;
                }
            }
            else if (sipN[mN, 0] != 0)
            {
                switch (mN)
                {
                    case 1: button1.BackColor = Color.Red; break;
                    case 2: button2.BackColor = Color.Red; break;
                    case 3: button3.BackColor = Color.Red; break;
                    case 4: button4.BackColor = Color.Red; break;
                    case 5: button5.BackColor = Color.Red; break;
                    case 6: button6.BackColor = Color.Red; break;
                    case 7: button7.BackColor = Color.Red; break;
                    case 8: button8.BackColor = Color.Red; break;
                    case 9: button9.BackColor = Color.Red; break;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            masaAc(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            masaAc(2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            masaAc(3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            masaAc(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            masaAc(5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            masaAc(6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            masaAc(7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            masaAc(8);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            masaAc(9);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Uygulamayı kapatmak istiyor musunuz? \n Tüm sipariş bilgileri kaybolacak.", "Küçük Restoran", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
