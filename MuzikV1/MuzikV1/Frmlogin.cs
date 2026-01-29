using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzikV1
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = "admin";
            string sifre = "12345";

            if (txtKullaniciAdi.Text == kullaniciAdi && txtSifre.Text == sifre)
            {
                Form1 frmAnaSayfa = new Form1();
                frmAnaSayfa.Show();
                this.Hide();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }
        

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "admin";
            txtSifre.Text = "12345";
        }
    }
}
