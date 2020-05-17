using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            tarih();
        }
        void tarih()
        {
            int ay = DateTime.Now.Month;
            int yil = DateTime.Now.Year;
            int gun = DateTime.Now.Day;
            lbltarih.Text = "Tarih: " + gun + "/" + (ay) + "/" + yil;
        }

        private void btnteknikservisgiris_Click(object sender, EventArgs e)
        {
            TeknikServisGiris tsgfrm = new TeknikServisGiris();
            tsgfrm.Show();
            this.Hide();
        }
        private void btnyoneticigiris_Click(object sender, EventArgs e)
        {
            YoneticiGiris ygfrm = new YoneticiGiris();
            ygfrm.Show();
            this.Hide();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void btnpersonel_Click(object sender, EventArgs e)
        {
            MusteriHizmetleriGiris mhg = new MusteriHizmetleriGiris();
            mhg.Show();
            this.Hide();
        }
    }
}
