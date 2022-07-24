using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool ekrantemizleneckmi;
        private int ilksayi;
        private int ikincisayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
        
            int sonuc=0;
            switch(_islem)
            {
                case'+':
                        sonuc=ilksayi+ikincisayi;
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
            }
            Ekranlabel.Text = Convert.ToString(sonuc);
        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (ekrantemizleneckmi == true)
            {
                Ekranlabel.Text = "";
                ekrantemizleneckmi = false;
            }
                if (Ekranlabel.Text =="0")
            {
                Ekranlabel.Text = "";

            }
            Ekranlabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (ekrantemizleneckmi == true)
            {
                Ekranlabel.Text = "";
                ekrantemizleneckmi = false;
            }
            if (Ekranlabel.Text == "0")
            {
                Ekranlabel.Text = "";

            }
            Ekranlabel.Text += "2";
        }

        private void rakam3buton_Click(object sender, EventArgs e)
        {
            if (ekrantemizleneckmi == true)
            {
                Ekranlabel.Text = "";
                ekrantemizleneckmi = false;
            }
            if (Ekranlabel.Text == "0")
            {
                Ekranlabel.Text = "";

            }
            Ekranlabel.Text += "3";
        }

        private void rakam4buton_Click(object sender, EventArgs e)
        {
            if (ekrantemizleneckmi == true)
            {
                Ekranlabel.Text = "";
                ekrantemizleneckmi = false;
            }
            if (Ekranlabel.Text == "0")
            {
                Ekranlabel.Text = "";

            }
            Ekranlabel.Text += "4";
        }

        private void rakam5buton_Click(object sender, EventArgs e)
        {
            if (ekrantemizleneckmi == true)
            {
                Ekranlabel.Text = "";
                ekrantemizleneckmi = false;
            }
            if (Ekranlabel.Text == "0")
            {
                Ekranlabel.Text = "";

            }
            Ekranlabel.Text += "5";
        }

        private void rakam6buton_Click(object sender, EventArgs e)
        {
            if (ekrantemizleneckmi == true)
            {
                Ekranlabel.Text = "";
                ekrantemizleneckmi = false;
            }
            if (Ekranlabel.Text == "0")
            {
                Ekranlabel.Text = "";

            }
            Ekranlabel.Text += "6";
        }

        private void rakam7buton_Click(object sender, EventArgs e)
        {
            if (ekrantemizleneckmi == true)
            {
                Ekranlabel.Text = "";
                ekrantemizleneckmi = false;
            }
            if (Ekranlabel.Text == "0")
            {
                Ekranlabel.Text = "";

            }
            Ekranlabel.Text += "7";
        }

        private void rakam8buton_Click(object sender, EventArgs e)
        {
            if (ekrantemizleneckmi == true)
            {
                Ekranlabel.Text = "";
                ekrantemizleneckmi = false;
            }
            if (Ekranlabel.Text == "0")
            {
                Ekranlabel.Text = "";

            }
            Ekranlabel.Text += "8";
        }

        private void rakam9buton_Click(object sender, EventArgs e)
        {
            if (ekrantemizleneckmi == true)
            {
                Ekranlabel.Text = "";
                ekrantemizleneckmi = false;
            }
            if (Ekranlabel.Text == "0")
            {
                Ekranlabel.Text = "";

            }
            Ekranlabel.Text += "9";
        }

        private void rakam0buton_Click(object sender, EventArgs e)
        {
            if (ekrantemizleneckmi == true)
            {
                Ekranlabel.Text = "";
                ekrantemizleneckmi = false;
            }
            if (Ekranlabel.Text == "0")
            {
                Ekranlabel.Text = "";

            }
            Ekranlabel.Text += "0";
        }

        private void toplamabutonu_Click(object sender, EventArgs e)
        {
            _islem = '+';
            ekrantemizleneckmi = true;
            ilksayi =Convert.ToInt32(Ekranlabel.Text);
            ikincisayi = Convert.ToInt32(Ekranlabel.Text);
        }

        private void çıkarmabutonu_Click(object sender, EventArgs e)
        {
            _islem = '-';
            ekrantemizleneckmi = true;
            ilksayi = Convert.ToInt32(Ekranlabel.Text);
            ikincisayi = Convert.ToInt32(Ekranlabel.Text);
        }

        private void çarpmabutonu_Click(object sender, EventArgs e)
        {
            _islem = '*';
            ekrantemizleneckmi = true;
            ilksayi = Convert.ToInt32(Ekranlabel.Text);
            ikincisayi = Convert.ToInt32(Ekranlabel.Text);
        }

        private void bölmebutonu_Click(object sender, EventArgs e)
        {
            _islem = '/';
            ekrantemizleneckmi = true;
            ilksayi = Convert.ToInt32(Ekranlabel.Text);
            ikincisayi = Convert.ToInt32(Ekranlabel.Text);
        }

        private void silmebutonu_Click(object sender, EventArgs e)
        {
            Ekranlabel.Text = "0";
        }
    }
}
    
    
    
    
    
    
    
