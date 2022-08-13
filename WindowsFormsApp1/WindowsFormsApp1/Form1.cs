using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        char _islem;
        bool _ekrantemiz;
        int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemiz) ekranLabel.Text = "";
            _ekrantemiz = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";


        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemiz) ekranLabel.Text = "";
            _ekrantemiz = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemiz) ekranLabel.Text = "";
            _ekrantemiz = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemiz) ekranLabel.Text = "";
            _ekrantemiz = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemiz) ekranLabel.Text = "";
            _ekrantemiz = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemiz) ekranLabel.Text = "";
            _ekrantemiz = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemiz) ekranLabel.Text = "";
            _ekrantemiz = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemiz) ekranLabel.Text = "";
            _ekrantemiz = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemiz) ekranLabel.Text = "";
            _ekrantemiz = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekrantemiz) ekranLabel.Text = "";
            _ekrantemiz = false;
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void artiButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemiz = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemiz = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpiButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemiz = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void boluButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemiz = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void esitButton_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;


                default: sonuc = 0; break;
            }
           
            ekranLabel.Text=Convert.ToString(sonuc);
     
            if (sonuc == 25)
            {
                ekranLabel.Text = "Dadaşlara Selam!!";
            }
        }

        private void silmeButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ekranLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
