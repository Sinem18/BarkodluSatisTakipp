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
            if (tUrunAra.Text.Length >= 2)
            {
                string urunad = tUrunAra.Text;
                using(var db = new BarkodDBEntities())
                {
                    if(cmbIslemTuru.SelectedIndex == 0)
                    {
                        db.Urun.Where(x => x.UrunAd.Contains(urunad));
                        gridListe.DataSource=db.Urun.Local.ToBindingList();

                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        db.StokHareket.Where(x=>x.UrunAd.Contains((urunad)));
                        gridListe.DataSource = db.Urun.Local.ToBindingList();// Gerekli Verileri Veri Tabanından Çekip Listeleme yapmak için kullanırız. 


                    }
                }
                islemler.GridDuzenle(gridListe);
            }
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
                        else
                        {
                            MessageBox.Show("Lütfen Ürün Grubu Seçiniz");
                        }
                        
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        DateTime baslangıc=DateTime.Parse(dtBaslangucTarihi.Value.ToShortDateString());
                        DateTime bitis=DateTime.Parse(dtBitişTarihi.Value.ToShortDateString());
                        bitis=bitis.AddDays(1);
                        if (rdTumu.Checked)
                        {
                            db.StokHareket.OrderByDescending(x=>x.Tarih).Where(x=>x.Tarih >=baslangıc &&  x.Tarih <= bitis).Load();
                            gridListe.DataSource=db.StokHareket.Local.ToBindingList();
                        }
                        else if (rdUrunGrubunaGore.Checked)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangıc && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Ürünİşlem Türü Seçiniz.");
                        }
                    } 
                }
            islemler.GridDuzenle(gridListe);
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
