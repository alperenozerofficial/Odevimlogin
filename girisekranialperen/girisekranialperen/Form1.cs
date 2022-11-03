using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace girisekranialperen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sistem kayıt = new Sistem();
            kayıt.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string kisi = textBox1.Text;
            string parola = textBox2.Text;
            if (kisi == "alp" && parola == "alp")

            {
                string baslik = "Robot Değil isen Tamam Tuşuna Bas";
                MessageBox.Show(baslik);
                Sistem frm1 = new Sistem();
                frm1.ShowDialog();
            }
            else
                MessageBox.Show("Hatalı Giriş Tekrar Deneyiniz");
            


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string sifre = textBox2.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
