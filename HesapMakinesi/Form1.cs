using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Sayilar

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        #region işlemler
        double sayi, sonuc, deger2;
        int islem;
        private void toplaBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi = Convert.ToDouble(textBox1.Text);
                textBox1.ResetText();
                islem = 1;
            }
            else
            {
                MessageBox.Show("lüften bir sayı giriniz");
            }

        }
        private void cikarBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi = Convert.ToDouble(textBox1.Text);
                textBox1.ResetText();
                islem = 2;
            }
            else
            {
                MessageBox.Show("lüften bir sayı giriniz");
            }

        }
        private void carpBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi = Convert.ToDouble(textBox1.Text);
                textBox1.ResetText();
                islem = 3;
            }
            else
            {
                MessageBox.Show("lüften bir sayı giriniz");
            }

        }
        private void bolBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi = Convert.ToDouble(textBox1.Text);
                textBox1.ResetText();
                islem = 4;
            }
            else
            {
                MessageBox.Show("lüften bir sayı giriniz");
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
             if (textBox1.Text != "")
            {
                sayi = Convert.ToDouble(textBox1.Text);
                textBox1.ResetText();
                islem = 5;
            }
            else
            {
                MessageBox.Show("lüften bir sayı giriniz");
            }
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            sayi = 0;
            deger2 = 0;
            sonuc = 0;
            textBox1.Text = "";
        }

        private void sonucBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double deger2 = Convert.ToDouble(textBox1.Text);
                if (islem == 1)
                {
                    sonuc = sayi + deger2;
                }
                else if (islem == 2)
                {
                    sonuc = sayi - deger2;
                }
                else if (islem == 3)
                {
                    sonuc = sayi * deger2;
                }
                else if (islem == 4)
                {
                    sonuc = sayi / deger2;
                }
                else if (islem == 5)
                {
                    sonuc = sayi % deger2;
                }

                textBox1.ResetText();
                textBox1.Text = sonuc.ToString();
            }
            else
            {
                MessageBox.Show("Henüz İşlem İçin sayı Girmediniz");

            }
        }
    }
}
