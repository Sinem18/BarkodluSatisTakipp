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
    }
}
