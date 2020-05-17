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
    public partial class YoneticiSayfasi : Form
    {
        public YoneticiSayfasi()
        {
            InitializeComponent();
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
            YoneticiSayfasi ys = new YoneticiSayfasi();
            ys.Show();
            this.Hide();
        }
        private void teknikerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeknikServisAdmin tsa = new TeknikServisAdmin();
            tsa.Show();
            this.Hide();
        }
        private void teknikerSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriHizmetleriAdmin mha = new MusteriHizmetleriAdmin();
            mha.Show();
            this.Hide();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;
        private void button1_Click(object sender, EventArgs e)
        {
            griddoldur();
            griddoldur2();
        }
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
        void griddoldur2()
        {
            con = new SqlConnection("server=DESKTOP-E2KP3SH\\MSSQLSERVER01; Initial Catalog=TeknikServis;Integrated Security=SSPI");
            da = new SqlDataAdapter("Select *From BitenArizalar", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "BitenArizalar");
            dataGridView1.DataSource = ds.Tables["BitenArizalar"];
            con.Close();
        }
    }
}
