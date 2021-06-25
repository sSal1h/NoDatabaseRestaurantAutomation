using System;
using System.Drawing;
using System.Windows.Forms;

namespace B202501061HüsnüSalihKüçük
{
    public partial class Form3 : Form
    {
        private int tFiyat = 0;
        private byte iptalSs = 0;

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            if (Form2.sipN[Form2.mNo, 0] == 0)
            {
                button2.Enabled = false;
                button8.Enabled = false;
            }

            panel1.Location = new Point(800, 12);
            panel1.Visible = false;

            panel2.Location = new Point(12, 650);
            panel2.Visible = false;

            label1.SendToBack();
            listBox1.SendToBack();
            flowLayoutPanel1.SendToBack();

            if (Form2.sipN[Form2.mNo, 0] != 0)
            {
                for (int i = 0; i < Form2.sipN[Form2.mNo, 0]; i++)
                {
                    listBox1.Items.Add(Form2.sipA[Form2.mNo, i] + " | " + Form2.sipF[Form2.mNo, i] + " | " + Form2.sip[Form2.mNo, i]);
                }

                tFiyat = 0;
                for (int i = 0; i <= Form2.sipN[Form2.mNo, 0]; i++)
                {
                    tFiyat += (Form2.sipF[Form2.mNo, i] * Form2.sipA[Form2.mNo, i]);
                }
                label3.Text = tFiyat + " TL";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(12, 12);
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(12, 12);
            panel2.Visible = true;

            label1.BringToFront();
            listBox1.BringToFront();
            flowLayoutPanel1.BringToFront();

            label6.Visible = false;
            label7.Visible = false;
            numericUpDown5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(800, 12);
            panel1.Visible = false;

            tFiyat = 0;
            for (int i = 0; i <= Form2.sipN[Form2.mNo, 0]; i++)
            {
                tFiyat += (Form2.sipF[Form2.mNo, i]* Form2.sipA[Form2.mNo, i]);
            }
                label3.Text = tFiyat + " TL";

            if (Form2.sipN[Form2.mNo, 0] > 0)
            {
                button2.Enabled = true;
                button8.Enabled = true;
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form2.sipA[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = Convert.ToByte(numericUpDown1.Value);
            Form2.sip[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = comboBox1.SelectedItem.ToString();
            Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 8;
            listBox1.Items.Add(Form2.sipA[Form2.mNo, Form2.sipN[Form2.mNo, 0]] + " | " + Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] + " | " + Form2.sip[Form2.mNo, Form2.sipN[Form2.mNo, 0]]);
            numericUpDown1.Value = 1;
            comboBox1.Text = "Çorba";
            Form2.sipN[Form2.mNo,0]++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2.sipA[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = Convert.ToByte(numericUpDown2.Value);
            Form2.sip[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = comboBox2.SelectedItem.ToString();

            switch (comboBox2.SelectedIndex)
            {
                case 0: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 45; break;
                case 1: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 22; break;
                case 2: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 50; break;
                case 3: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 28; break;
                case 4: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 26; break;
                case 5: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 28; break;
            }
            listBox1.Items.Add(Form2.sipA[Form2.mNo, Form2.sipN[Form2.mNo, 0]] + " | " + Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] + " | " + Form2.sip[Form2.mNo, Form2.sipN[Form2.mNo, 0]]);
            numericUpDown2.Value = 1;
            comboBox2.Text = "Ana Yemek";
            Form2.sipN[Form2.mNo, 0]++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2.sipA[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = Convert.ToByte(numericUpDown3.Value);
            Form2.sip[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = comboBox3.SelectedItem.ToString();
            switch (comboBox3.SelectedIndex)
            {
                case 0: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 28; break;
                case 1: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 27; break;
                case 2: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 27; break;
                case 3: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 15; break;
                case 4: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 15; break;
            }
            listBox1.Items.Add(Form2.sipA[Form2.mNo, Form2.sipN[Form2.mNo, 0]] + " | " + Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] + " | " + Form2.sip[Form2.mNo, Form2.sipN[Form2.mNo, 0]]);
            numericUpDown3.Value = 1;
            comboBox3.Text = "Tatlı";
            Form2.sipN[Form2.mNo, 0]++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2.sipA[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = Convert.ToByte(numericUpDown4.Value);
            Form2.sip[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = comboBox4.SelectedItem.ToString();
            switch (comboBox4.SelectedIndex)
            {
                case 0: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 1; break;
                case 1: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 2; break;
                case 2: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 5; break;
                case 3: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 5; break;
                case 4: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 5; break;
                case 5: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 3; break;
                case 6: Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] = 2; break;
            }
            listBox1.Items.Add(Form2.sipA[Form2.mNo, Form2.sipN[Form2.mNo, 0]] + " | " + Form2.sipF[Form2.mNo, Form2.sipN[Form2.mNo, 0]] + " | " + Form2.sip[Form2.mNo, Form2.sipN[Form2.mNo, 0]]);
            numericUpDown4.Value = 1;
            comboBox4.Text = "İçecek";
            Form2.sipN[Form2.mNo, 0]++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tFiyat -= (Form2.sipF[Form2.mNo, (listBox1.SelectedIndex + iptalSs)] * Form2.sipA[Form2.mNo, (listBox1.SelectedIndex + iptalSs)]);
            Form2.sip[Form2.mNo, (listBox1.SelectedIndex + iptalSs)] = "";
            Form2.sipA[Form2.mNo, (listBox1.SelectedIndex + iptalSs)] = 0;
            Form2.sipF[Form2.mNo, (listBox1.SelectedIndex + iptalSs)] = 0;
            label3.Text = tFiyat + " TL";
            iptalSs++;
            listBox1.Items.RemoveAt(listBox1.SelectedIndex); 
            Form2.sipN[Form2.mNo, 0]--;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            listBox1.Items.Clear();
            (this.Owner as Form2).mdb(Form2.mNo);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(12, 650);
            panel2.Visible = false;

            label1.SendToBack();
            listBox1.SendToBack();
            flowLayoutPanel1.SendToBack();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            if (Form2.sipN[Form2.mNo, 0] == 0)
            {
                button2.Enabled = false;
                button8.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label7.Text = "Para üstü : " + (numericUpDown5.Value - tFiyat) + " TL";
            tFiyat = 0;

            for (int i = 0; i <= Form2.sipN[Form2.mNo, 0]; i++)
            {
                Form2.sip[Form2.mNo, i] = "";
                Form2.sipA[Form2.mNo, i] = 0;
                Form2.sipF[Form2.mNo, i] = 0;
            }
            Form2.sipN[Form2.mNo, 0] = 0;
            listBox1.Items.Clear();
            label3.Text = tFiyat + " TL";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            label7.Visible = true;
            numericUpDown5.Visible = true;
            button9.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            numericUpDown5.Visible = false;
            button9.Enabled = true;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = "Para üstü : " + (numericUpDown5.Value - tFiyat) + " TL";
        }
    }
}
