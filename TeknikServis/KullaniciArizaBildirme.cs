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
    public partial class KullaniciArizaBildirme : Form
    {
        public KullaniciArizaBildirme()
        {
            InitializeComponent();

        }
        
        static string conString = "Server=DESKTOP-E2KP3SH\\MSSQLSERVER01; Initial Catalog=TeknikServis;Integrated Security=SSPI";
        SqlConnection baglanti = new SqlConnection(conString);

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                
                string kayit = "insert into Arizalar(MusteriAdi,MusteriSoyadi,MusteriTel,MusteriAdres,SeriNo,Marka,Model,Tutar,ArizaSebebi) values (@MusteriAdi,@MusteriSoyadi,@MusteriTel,@MusteriAdres,@SeriNo,@Marka,@Model,@Tutar,@ArizaSebebi)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@MusteriAdi", txtad.Text);
                komut.Parameters.AddWithValue("@MusteriSoyadi", txtsoyad.Text);
                komut.Parameters.AddWithValue("@MusteriTel", txttelefon.Text);
                komut.Parameters.AddWithValue("@MusteriAdres", txtadres.Text);
                komut.Parameters.AddWithValue("@SeriNo", txtserino.Text);
                komut.Parameters.AddWithValue("@Marka", txtmarka.Text);
                komut.Parameters.AddWithValue("@Model", txtmodel.Text);
                komut.Parameters.AddWithValue("@Tutar", txttutar.Text);
                komut.Parameters.AddWithValue("@ArizaSebebi", rtxtarizasebebi.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Arıza Kayıt İşlemi Gerçekleşti.");
                txtad.Clear();
                txtsoyad.Clear();
                txttelefon.Clear();
                txtadres.Clear();
                txtserino.Clear();
                txtmarka.Clear();
                txtmodel.Clear();
                txttutar.Clear();
                rtxtarizasebebi.Clear();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }

       

        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from Arizalar";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Silme İşlemi Yapılsın mı ?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("delete from Arizalar where id=@aid", baglanti);
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

        private void btnListele_Click(object sender, EventArgs e)
        {
            kayitGetir();
        
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "update Arizalar set MusteriAdi=@Musteriadi,MusteriSoyadi=@MusteriSoyadi,MusteriTel=@MusteriTel,MusteriAdres=@MusteriAdres,SeriNo=@SeriNo,Marka=@Marka,Model=@Model,Tutar=@Tutar,ArizaSebebi=@ArizaSebebi where MusteriAdi=@MusteriAdi";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@MusteriAdi", txtad.Text);
            komut.Parameters.AddWithValue("@MusteriSoyadi", txtsoyad.Text);
            komut.Parameters.AddWithValue("@MusteriTel", txttelefon.Text);
            komut.Parameters.AddWithValue("@MusteriAdres", txtadres.Text);
            komut.Parameters.AddWithValue("@SeriNo", txtserino.Text);
            komut.Parameters.AddWithValue("@Marka", txtmarka.Text);
            komut.Parameters.AddWithValue("@Model", txtmodel.Text);
            komut.Parameters.AddWithValue("@Tutar", txttutar.Text);
            komut.Parameters.AddWithValue("@ArizaSebebi", rtxtarizasebebi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ariza Bilgileri Güncellendi.");


        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //0 dan başlamadık çünkü id almamak için
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtserino.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtmodel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txttutar.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            rtxtarizasebebi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oturumdan çıkış yapıldı.");
            AnaForm anafrm = new AnaForm();
            anafrm.Show();
            this.Hide();
        }

        

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciArizaBildirme kab = new KullaniciArizaBildirme();
            kab.Show();
            this.Hide();

        }
        private void hesapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
