using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_4
{
    

    public partial class Form1 : Form
    {
        char islem;
        bool ekranTemizlenecekMi;
        int ilksayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if(ekranTemizlenecekMi)
            {
                textBox1.Text = "";
                ekranTemizlenecekMi = false;


            }


            Button btn = (Button)sender;
            textBox1.Text += btn.Text;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekranTemizlenecekMi = true;
            ilksayi = Convert.ToInt32(textBox1.Text);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekranTemizlenecekMi = true;
            ilksayi = Convert.ToInt32(textBox1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekranTemizlenecekMi = true;
            ilksayi = Convert.ToInt32(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekranTemizlenecekMi = true;
            ilksayi = Convert.ToInt32(textBox1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(textBox1.Text);
            int sonuc;

            switch(islem)
            {
                case '+':
                    sonuc = ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = ilksayi - ikincisayi;
                    break;
                case '*':
                    sonuc = ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = ilksayi / ikincisayi;
                    break;

                default:
                    sonuc = 0;
                    break;



            }

            textBox1.Text = Convert.ToString(sonuc);


        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
