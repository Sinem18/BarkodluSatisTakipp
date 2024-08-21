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
    public partial class HizliButonUrunEkleme : Form
    {
        public HizliButonUrunEkleme()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        BarkodDBEntities db = new BarkodDBEntities();
        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if(tUrunAra.Text!=" ")
            {
                string urunad = tUrunAra.Text;
                var urunler = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();

            }

        }

        private void lButonıd_Click(object sender, EventArgs e)
        {

        }

        private void dgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUrunler.Rows.Count > 0)
            {
                string barkod = gridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunAd = gridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                double fiyat = Convert.ToDouble(gridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());
                int id = Convert.ToInt16(lButonıd.Text);
                var guncellenecek = db.HizliUrun.Find(id);
                guncellenecek.Barkod = barkod;
                guncellenecek.UrunAd = urunAd;
                guncellenecek.Fiyat = fiyat;
                db.SaveChanges();
                MessageBox.Show("Buton tanımlanmıştır.");
            }
        }

        private void HizliButonUrunEkleme_Load(object sender, EventArgs e)
        {

        }
    }
}
