using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total1;
        double total2;
        bool toplama_tiklandimi = false;
        bool cikarma_tiklandimi = false;
        bool carpma_tiklandimi = false;
        bool bolme_tiklandimi = false;

        private void Sifirla()
        {
            total1 = 0;
            total2 = 0;
            toplama_tiklandimi = false;
            cikarma_tiklandimi = false;
            carpma_tiklandimi = false;
            bolme_tiklandimi = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_sonuc.Text = textBox_sonuc.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_sonuc.Text = textBox_sonuc.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_sonuc.Text = textBox_sonuc.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_sonuc.Text = textBox_sonuc.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_sonuc.Text = textBox_sonuc.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_sonuc.Text = textBox_sonuc.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_sonuc.Text = textBox_sonuc.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_sonuc.Text = textBox_sonuc.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_sonuc.Text = textBox_sonuc.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox_sonuc.Text = textBox_sonuc.Text + "0";
        }

        private void button_arti_Click(object sender, EventArgs e)
        {
            total1 = total1 + Convert.ToDouble(textBox_sonuc.Text);
            textBox_sonuc.Clear();
            toplama_tiklandimi = true;
        }

        private void button_eksi_Click(object sender, EventArgs e)
        {
            total1 = total1 + Convert.ToDouble(textBox_sonuc.Text);
            textBox_sonuc.Clear();
            cikarma_tiklandimi = true;
        }

        private void button_carpi_Click(object sender, EventArgs e)
        {
            total1 = total1 + Convert.ToDouble(textBox_sonuc.Text);
            textBox_sonuc.Clear();
            carpma_tiklandimi = true;
        }

        private void button_bolu_Click(object sender, EventArgs e)
        {
            total1 = total1 + Convert.ToDouble(textBox_sonuc.Text);
            textBox_sonuc.Clear();
            bolme_tiklandimi = true;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Sifirla();
            textBox_sonuc.Clear();
        }

        private void button_esittir_Click(object sender, EventArgs e)
        {
            if (toplama_tiklandimi == true)
            {
                total2 = Convert.ToDouble(textBox_sonuc.Text);
                textBox_sonuc.Clear();
                textBox_sonuc.Text = (total1 + total2).ToString();                
            }

            else if (cikarma_tiklandimi == true)
            {
                total2 = Convert.ToDouble(textBox_sonuc.Text);
                textBox_sonuc.Clear();
                textBox_sonuc.Text = (total1 - total2).ToString();   
            }

            else if (carpma_tiklandimi == true)
            {
                total2 = Convert.ToDouble(textBox_sonuc.Text);
                textBox_sonuc.Clear();
                textBox_sonuc.Text = (total1 * total2).ToString();
            }

            else if (bolme_tiklandimi == true)
            {
                if (total2 == 0)
                {
                    textBox_sonuc.Text = "Sayı 0'a bölünemez !";
                }
                else
                {
                    total2 = Convert.ToDouble(textBox_sonuc.Text);
                    textBox_sonuc.Clear();
                    textBox_sonuc.Text = (total1 / total2).ToString();
                }
            }

            Sifirla();

        }

    }
}
