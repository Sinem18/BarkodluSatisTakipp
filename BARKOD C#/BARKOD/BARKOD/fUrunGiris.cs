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
    public partial class fUrunGiris : Form
    {
        public fUrunGiris()
        {
            InitializeComponent();
        }

        private void lStandart1_Click(object sender, EventArgs e)
        {

        }

        BarkodDBEntities db=new BarkodDBEntities();
        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string barkod = tBarkod.Text.Trim();
                if (db.Urun.Any(a => a.Barkod == barkod))
                {
                    var urun=db.Urun.Where(a=>a.Barkod==barkod).SingleOrDefault();
                    tUrunAdi.Text = urun.Barkod;
                    tAciklama.Text = urun.Aciklama;
                    cmbUrunGrup.Text = urun.UrunGrup;
                    tAlisFiyat.Text = urun.AlisFiyat.ToString();
                    tSatisFiyat.Text = urun.SatisFiyat.ToString();
                    tMiktar.Text= urun.Miktar.ToString();
                    tKdv.Text=urun.KDVTutari.ToString();

                }
                else
                {
                    MessageBox.Show("Ürün kayıtlı Değil,Kaydedebilirsiniz.");
                }
            }

        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if(tBarkod.Text!=""&& tUrunAdi.Text!=""&& tAciklama.Text!=""&& cmbUrunGrup.Text!="" && tAlisFiyat.Text!="" && tSatisFiyat.Text!="" &&tMiktar.Text!="" && tKdv.Text!="")
            {
                if (db.Urun.Any(a=>a.Barkod==tBarkod.Text))
                {
                    var güncelle=db.Urun.Where(a=>a.Barkod==tBarkod.Text).SingleOrDefault();
                    güncelle.Barkod = tBarkod.Text;
                    güncelle.UrunAd = tUrunAdi.Text;
                    güncelle.Aciklama = tAciklama.Text;
                    güncelle.UrunGrup = cmbUrunGrup.Text;
                    güncelle.AlisFiyat = Convert.ToDouble(tAlisFiyat.Text);
                    güncelle.SatisFiyat = Convert.ToDouble(tSatisFiyat.Text);
                    güncelle.KDVOrani = /*Convert.ToInt32(tKdv.Text)*/ 0; // Düzeltme yap !!!
                    güncelle.KDVTutari = /*Math.Round(islemler.DoubleYap(tSatisFiyat.Text) * tKdv.Text / 100,2)*/ "0"; // düzelt hatalı işlem.
                    güncelle.Miktar += Convert.ToDouble(tMiktar.Text);
                    güncelle.Birim = "Adet";
                    güncelle.Tarih = DateTime.Now;
                    güncelle.Kullanici = lKullanici.Text;
                    db.SaveChanges();
                    MessageBox.Show("Ürün Güncellenmiştir.");
                    gridUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                }
                else {
                    Urun urun = new Urun();
                    urun.Barkod = tBarkod.Text;
                    urun.UrunAd = tUrunAdi.Text;
                    urun.Aciklama = tAciklama.Text;
                    urun.UrunGrup = cmbUrunGrup.Text;
                    urun.AlisFiyat = Convert.ToDouble(tAlisFiyat.Text);
                    urun.SatisFiyat = Convert.ToDouble(tSatisFiyat.Text);
                    urun.KDVOrani = Convert.ToInt32(tKdv.Text);
                    urun.KDVTutari = /*Math.Round(islemler.DoubleYap(tSatisFiyat.Text) * tKdv.Text / 100,2)*/ "0"; // düzelt hatalı işlem.
                    urun.Miktar = Convert.ToDouble(tMiktar.Text);
                    urun.Birim = "Adet";
                    urun.Tarih = DateTime.Now;
                    urun.Kullanici = lKullanici.Text;
                    db.Urun.Add(urun);
                    db.SaveChanges();
                    if (tBarkod.Text.Length == 8)
                    {
                        var ozelbarkod = db.Barkod.First();
                        ozelbarkod.BarkodNo += 1;
                        db.SaveChanges();

                    }
                    TemizlE();

                    gridUrunler.DataSource = db.Urun.OrderByDescending(a => a.UrunId).Take(10).ToList();
                    islemler.GridDuzenle(gridUrunler);

                }
                islemler.StokHareket(tBarkod.Text, tUrunAdi.Text, "Adet", cmbUrunGrup.Text,Convert.ToDouble(tMiktar.Text), lKullanici.Text);


            }
            else
            {
                MessageBox.Show("Bilgi Girişlerinizi Kontrol Ediniz.");
                tBarkod.Focus();
            }
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            string urunAd=tUrunAra.Text;
            gridUrunler.DataSource=db.Urun.Where(a=>a.UrunAd.Contains(urunAd)).ToList();
            islemler.GridDuzenle(gridUrunler);
        }

        private void bİptal_Click(object sender, EventArgs e)
        {
            TemizlE();
        }
        private void TemizlE()
        {
            tBarkod.Clear();
            tUrunAdi.Clear();
            tAciklama.Clear();
           // cmbUrunGrup.Clear(); // Hata olabilir 
            tAlisFiyat.Text = "0";
            tSatisFiyat.Text = "0";
            tMiktar.Text = "0";
            tKdv.Text = "8";
            tBarkod.Focus();
        }

        private void fUrunGiris_Load(object sender, EventArgs e)
        {
            tUrunSayisi.Text = db.Urun.Count().ToString();
            GrupDoldur();
        }

        public void GrupDoldur()
        {
            cmbUrunGrup.DisplayMember = "UrunGrupAd";
            cmbUrunGrup.ValueMember = "Id";
            cmbUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bUrunGrubu_Click(object sender, EventArgs e)
        {
            fUrunGrubuEkle f=new fUrunGrubuEkle();
            f.ShowDialog();
        }

        private void bBarkodOlustur_Click(object sender, EventArgs e)
        {
            var barkodno = db.Barkod.First();
            int karakter = barkodno.BarkodNo.ToString().Length;
            string sifirlar = string.Empty;
            for(int i = 0; i < 8 - karakter; i++)
            {
                sifirlar = sifirlar + "0";
            }
            string olusanbarkod = sifirlar + barkodno.BarkodNo.ToString();
            tBarkod.Text = olusanbarkod;
            tUrunAdi.Focus();

        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
