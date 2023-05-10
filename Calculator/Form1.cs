using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public char islem;
        bool ekran_temizleme;
        int ilk_sayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if(ekran_temizleme == true)
            {
                label1.Text = "";
                ekran_temizleme = false;
            }
            if(label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "1"; 
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (ekran_temizleme == true)
            {
                label1.Text = "";
                ekran_temizleme = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (ekran_temizleme == true)
            {
                label1.Text = "";
                ekran_temizleme = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (ekran_temizleme == true)
            {
                label1.Text = "";
                ekran_temizleme = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (ekran_temizleme == true)
            {
                label1.Text = "";
                ekran_temizleme = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (ekran_temizleme == true)
            {
                label1.Text = "";
                ekran_temizleme = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (ekran_temizleme == true)
            {
                label1.Text = "";
                ekran_temizleme = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (ekran_temizleme == true)
            {
                label1.Text = "";
                ekran_temizleme = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (ekran_temizleme == true)
            {
                label1.Text = "";
                ekran_temizleme = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "0";
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            int sonuc;
            int ikincisayi = Convert.ToInt32(label1.Text);

            switch (islem)
            {
                case '+':
                    sonuc = ilk_sayi + ikincisayi;
                    break;
                case '-':
                    sonuc = ilk_sayi - ikincisayi;
                    break;
                case '/':
                    sonuc = ilk_sayi / ikincisayi;
                    break;
                case '*':
                    sonuc = ilk_sayi * ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            label1.Text = Convert.ToString(sonuc);

        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void topla_Click(object sender, EventArgs e)
        {
            ekran_temizleme = true;
            ilk_sayi = Convert.ToInt32(label1.Text);
            islem = '+';
        }

        private void fark_Click(object sender, EventArgs e)
        {
            ekran_temizleme = true;
            ilk_sayi = Convert.ToInt32(label1.Text);
            islem = '-';
        }

        private void carp_Click(object sender, EventArgs e)
        {
            ekran_temizleme = true;
            ilk_sayi = Convert.ToInt32(label1.Text);
            islem = '*';
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            ekran_temizleme = true;
            ilk_sayi = Convert.ToInt32(label1.Text);
            islem = '/';

        }
    }
}
