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
    public partial class TeknikServisPortal : Form
    {
        static string conString = "Server=DESKTOP-E2KP3SH\\MSSQLSERVER01; Initial Catalog=TeknikServis;Integrated Security=SSPI";
        SqlConnection baglanti = new SqlConnection(conString);

        public TeknikServisPortal()
        {
            InitializeComponent();
        }
        private void bitenkayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from BitenArizalar";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
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

        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;

        void griddoldur()
        {
            con = new SqlConnection("server=DESKTOP-E2KP3SH\\MSSQLSERVER01; Initial Catalog=TeknikServis;Integrated Security=SSPI");
            da = new SqlDataAdapter("Select *From Arizalar", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Arizalar");
            dataGridView2.DataSource = ds.Tables["Arizalar"];
            con.Close();
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                string MusteriAd = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string MusteriSoyadAd = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string MusteriTel = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string MusteriAdres = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string SeriNo = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string Marka = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string Model = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                string Tutar = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                string ArizaSebebi = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                baglanti.Open();
                string kayit = "insert into BitenArizalar(MusteriAdi,MusteriSoyadi,MusteriTel,MmusteriAdres,SeriNo,Marka,Model,Tutar,ArizaSebebi) " +
                    "values (@MusteriAdi,@MusteriSoyadi,@MusteriTel,@MusteriAdres,@SeriNo,@Marka,@Model,@Tutar,@ArizaSebebi)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@MusteriAdi", MusteriAd);
                komut.Parameters.AddWithValue("@MusteriSoyadi", MusteriSoyadAd);
                komut.Parameters.AddWithValue("@MusteriTel", MusteriTel);
                komut.Parameters.AddWithValue("@MusteriAdres", MusteriAdres);
                komut.Parameters.AddWithValue("@SeriNo", SeriNo);
                komut.Parameters.AddWithValue("@Marka", Marka);
                komut.Parameters.AddWithValue("@Model", Model);
                komut.Parameters.AddWithValue("@Tutar", Tutar);
                komut.Parameters.AddWithValue("@ArizaSebebi", ArizaSebebi);
                komut.ExecuteNonQuery();
                SqlCommand cmd = new SqlCommand("delete from Arizalar where id=@id", con);
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);

                con.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İşlem Gerçekleşti.");
               
            }
        }

        private void TeknikServisPortal_Load(object sender, EventArgs e)
        {
            griddoldur();
            kayitGetir();
            bitenkayitGetir();

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oturumdan çıkış yapıldı.");
            AnaForm anafrm = new AnaForm();
            anafrm.Show();
            this.Hide();
        }

        private void sayfayıYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeknikServisPortal tsp = new TeknikServisPortal();
            tsp.Show();
            this.Hide();
        }
    }
}
