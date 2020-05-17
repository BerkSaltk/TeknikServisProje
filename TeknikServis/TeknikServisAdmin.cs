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
    public partial class TeknikServisAdmin : Form
    {
        public TeknikServisAdmin()
        {
            InitializeComponent();
        }

        static string conString = "Server=DESKTOP-E2KP3SH\\MSSQLSERVER01; Initial Catalog=TeknikServis;Integrated Security=SSPI";
        SqlConnection baglanti = new SqlConnection(conString);
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeknikServisAdmin kab = new TeknikServisAdmin();
            kab.Show();
            this.Hide();
        }

        private void teknikerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriHizmetleriAdmin kab = new MusteriHizmetleriAdmin();
            kab.Show();
            this.Hide();
        }   

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oturumdan çıkış yapıldı.");
            AnaForm anafrm = new AnaForm();
            anafrm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayit = "insert into Kullanicilar(tcNo,ad,soyad,yetki,kullaniciAdi,parola,eMail) values (@tcNo,@ad,@soyad,@yetki,@kullaniciAdi,@parola,@eMail)";
                string kayit2 = "insert into Teknikerler(tcNo,ad,soyad,yetki,kullaniciAdi,parola,eMail) values (@tcNo,@ad,@soyad,@yetki,@kullaniciAdi,@parola,@eMail)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                SqlCommand komut2 = new SqlCommand(kayit2, baglanti);

                komut.Parameters.AddWithValue("@tcNo", txttc.Text);
                komut.Parameters.AddWithValue("@ad", txtad.Text);
                komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                komut.Parameters.AddWithValue("@yetki", txtyetki.Text);
                komut.Parameters.AddWithValue("@kullaniciAdi", txtkadi.Text);
                komut.Parameters.AddWithValue("@parola", txtpaorla.Text);
                komut.Parameters.AddWithValue("@eMail", txtemail.Text);

                komut.ExecuteNonQuery();

                komut2.Parameters.AddWithValue("@tcNo", txttc.Text);
                komut2.Parameters.AddWithValue("@ad", txtad.Text);
                komut2.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                komut2.Parameters.AddWithValue("@yetki", txtyetki.Text);
                komut2.Parameters.AddWithValue("@kullaniciAdi", txtkadi.Text);
                komut2.Parameters.AddWithValue("@parola", txtpaorla.Text);
                komut2.Parameters.AddWithValue("@eMail", txtemail.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tekniker Kayıt İşlemi Gerçekleşti.");
                txttc.Clear();
                txtad.Clear();
                txtsoyad.Clear();
                txtyetki.Clear();
                txtkadi.Clear();
                txtpaorla.Clear();
                txtemail.Clear();
                txtyetki.Enabled = true;


            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Silme İşlemi Yapılsın mı ?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("delete from Teknikerler where id=@aid", baglanti);
                    cmd.Parameters.AddWithValue("@aid", dataGridView1.CurrentRow.Cells[0].Value);

                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Silindi");
                    baglanti.Close();
                }
                catch (Exception hata)
                {

                    MessageBox.Show(hata.ToString());
                }
            }
        }

        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from Teknikerler";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayitGetir();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "update Teknikerler set tcNo=@tcNo,ad=@ad,soyad=@soyad,yetki=@yetki,kullaniciAdi=@kullaniciAdi,parola=@parola,eMail=@eMail where tcNo=@tcNo";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@tcNo", txttc.Text);
            komut.Parameters.AddWithValue("@ad", txtad.Text);
            komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
            komut.Parameters.AddWithValue("@yetki", txtyetki.Text);
            komut.Parameters.AddWithValue("@kullaniciAdi", txtkadi.Text);
            komut.Parameters.AddWithValue("@parola", txtpaorla.Text);
            komut.Parameters.AddWithValue("@eMail", txtemail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Tekniker Bilgileri Güncellendi.");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //0 dan başlamadık çünkü id almamak için
            txttc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtyetki.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtkadi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtpaorla.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

