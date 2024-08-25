using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARKOD
{
    public partial class fNakitKart : Form
    {
        public fNakitKart()
        {
            InitializeComponent();
        }

        private void tbarkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void fNakitKart_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tNakit_KeyDown(object sender, KeyEventArgs e)
        {
            if (tNakit.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Hesapla();

                }

            }

        }

        private void Hesapla()
        {
            bDıgerUrun f = (bDıgerUrun)Application.OpenForms["Form1"];// Kontrol et hata olabilir.
            double nakit = islemler.DoubleYap(tNakit.Text);
            double geneltoplam = islemler.DoubleYap(f.t1234.Text);
            double kart = geneltoplam - nakit;
            f.lNakit.Text = nakit.ToString("C2");
            f.lKart.Text = kart.ToString("C2");
            f.SatisYap("Kart-Nakit");
            this.Hide();
        }
        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = tNakit.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    tNakit.Text += b.Text;
                }

            }
            else if (b.Text == "<")
            {
                if (tNakit.Text.Length > 0)
                {
                    tNakit.Text = tNakit.Text.Substring(0, tNakit.Text.Length - 1);
                }
            }
            else
            {
                tNakit.Text += b.Text;
            }

        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            if(tNakit.Text != ""){
                Hesapla();
            }

        }

        private void tNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)==false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }
    }
}

