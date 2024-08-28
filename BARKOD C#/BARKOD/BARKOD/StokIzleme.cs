using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARKOD
{
    public partial class StokIzleme : Form
    {
        public StokIzleme()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lStandart4_Click(object sender, EventArgs e)
        {

        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void bArama_Click(object sender, EventArgs e)
        {
            gridListe.DataSource = null;
            using(var db= new BarkodDBEntities())
                if (cmbIslemTuru.Text != "")
                {string urungrubu=cmbUrunGrubu.Text;
                    if (cmbIslemTuru.SelectedIndex == 0)
                    {
                        if (rdTumu.Checked)
                        {
                            db.Urun.OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource=db.Urun.Local.ToBindingList();
                        }
                        else if (rdUrunGrubunaGore.Checked)
                        {
                            db.Urun.Where(x => x.UrunGrup == urungrubu).OrderBy(x=>x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();

                        }
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        DateTime baslangıc=DateTime.Parse(dtBaslangucTarihi.Value.ToShortDateString());
                        DateTime bitis=DateTime.Parse(dtBitişTarihi.Value.ToShortDateString());// dtbaslangıc olabilir !!!
                    }
                }
        }
        BarkodDBEntities dbx = new BarkodDBEntities();
        private void StokIzleme_Load(object sender, EventArgs e)
        {
            cmbUrunGrubu.DisplayMember = "UrunGrupAd";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource=dbx.UrunGrup.ToList();
        }
    }
}
