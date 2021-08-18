using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayisalLotoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Belirle_Click(object sender, EventArgs e)
        {
            System.Random rnd = new System.Random();
            int randomsayi1, randomsayi2, randomsayi3, randomsayi4, randomsayi5, randomsayi6;

            randomsayi1 = rnd.Next(1,50);
            randomsayi2 = rnd.Next(1, 50);
            randomsayi3 = rnd.Next(1, 50);
            randomsayi4 = rnd.Next(1, 50);
            randomsayi5 = rnd.Next(1, 50);
            randomsayi6 = rnd.Next(1, 50);

            Sayi1.Text = randomsayi1.ToString();
            Sayi2.Text = randomsayi2.ToString();
            Sayi3.Text = randomsayi3.ToString();
            Sayi4.Text = randomsayi4.ToString();
            Sayi5.Text = randomsayi5.ToString();
            Sayi6.Text = randomsayi6.ToString();

            if (Sayi1.Text != textBox1.Text)
            {
                this.BackColor = Color.Red;
            }
            if (Sayi2.Text != textBox2.Text)
            {
                this.BackColor = Color.Red;
            }
            if (Sayi3.Text != textBox3.Text)
            {
                this.BackColor = Color.Red;
            }
            if (Sayi4.Text != textBox4.Text)
            {
                this.BackColor = Color.Red;
            }
            if (Sayi5.Text != textBox5.Text)
            {
                this.BackColor = Color.Red;
            }
            if (Sayi6.Text != textBox6.Text)
            {
                this.BackColor = Color.Red;
                MessageBox.Show("Loto Tutmadı");
            }
            else
            {
                this.BackColor = Color.Green;
            }




        }
    }
}
