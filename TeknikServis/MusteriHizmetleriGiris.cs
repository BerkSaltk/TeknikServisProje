using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServis
{
    public partial class MusteriHizmetleriGiris : Form
    {
        public MusteriHizmetleriGiris()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtkadi.Text;
            string pass = txtsifre.Text;
            con = new SqlConnection("server=DESKTOP-E2KP3SH\\MSSQLSERVER01; Initial Catalog=TeknikServis;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Kullanicilar where kullaniciAdi='" + txtkadi.Text + "' AND parola='" + txtsifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string yetki;
                yetki = dr["yetki"].ToString();
                if (yetki == "3")
                {
                    MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                    KullaniciArizaBildirme KAB = new KullaniciArizaBildirme();
                    KAB.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifreniziz hatalı lütfen kontrol ediniz.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }
        private void btngeridon_Click(object sender, EventArgs e)
        {
            AnaForm anafrm = new AnaForm();
            anafrm.Show();
            this.Hide();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifrefrm = new SifremiUnuttum();
            sifrefrm.Show();
            this.Hide();
        }
        private void txtkadi_Validating(object sender, CancelEventArgs e)
        {
            if (txtkadi.Text.Trim() == "")
                errorProvider1.SetError(txtkadi, "Bu alanı boş geçemezsiniz.");
            else
                errorProvider1.SetError(txtkadi, "");
        }
        private void txtsifre_Validating(object sender, CancelEventArgs e)
        {
            if (txtsifre.Text.Trim() == "")
                errorProvider1.SetError(txtsifre, "Bu alanı boş geçemezsiniz.");
            else
                errorProvider1.SetError(txtsifre, "");
        }
    }
}
