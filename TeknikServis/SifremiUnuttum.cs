using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace TeknikServis
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        private readonly SqlConnection con = new SqlConnection("server=DESKTOP-E2KP3SH\\MSSQLSERVER01;database=TeknikServis;trusted_connection=true");

        public bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("mailadres@gmail.com");
           
            ePosta.To.Add(txtMail.Text);
            ;

            ePosta.Subject = konu;
          
            ePosta.Body = icerik;
          
            SmtpClient smtp = new SmtpClient();
          
            smtp.Credentials = new System.Net.NetworkCredential("mailadres@gmail.com", "sifre");
           
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string parola;
           
            if (con.State == ConnectionState.Closed) 
            {
                con.Open(); 
            }

            SqlCommand com = new SqlCommand("Select * from Kullanicilar where kullaniciAdi='" + txtkAdi.Text.ToString() +
                "'and eMail='" + txtMail.Text.ToString() + "'", con);
            
            SqlDataReader oku = com.ExecuteReader();
            if (oku.Read())
            {
      

                parola = oku["parola"].ToString();
                          
                MessageBox.Show("Girmiş Oldunuz Bilgiler Uyuşuyor Şifreniz Mail adresinize yollanıyor");
                Gonder("Unutmuş Olduğunuz Şifreniz Ektedir", parola);
              
                con.Close();
            }
            else
            {
                MessageBox.Show("Bilgileriniz Uyuşmadı");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaForm afrm = new AnaForm();
            afrm.Show();
            this.Hide();
        }
    }
}
