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
    public partial class bDıgerUrun : Form
    {
        public bDıgerUrun()
        {
            InitializeComponent();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HizliButondoldur();
            b5.Text = 5.ToString("C2");
            b10.Text = 10.ToString("C2");
            b20.Text = 20.ToString("C2");
            b50.Text = 50.ToString("C2");
            b100.Text = 100.ToString("C2");
            b200.Text = 200.ToString("C2");
        }
        private void HizliButondoldur()
        {
            var hizliurun = db.HizliUrun.ToList();
            foreach(var item in hizliurun)
            {
                Button bh = this.Controls.Find("bH" + item.Id, true).FirstOrDefault() as Button;
                if (bh != null)
                {
                    double fiyat = islemler.DoubleYap(item.Fiyat.ToString());
                    bh.Text = item.UrunAd + "\n " + fiyat.ToString("C2");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                dgrid.Rows.Remove(dgrid.CurrentRow);
                dgrid.ClearSelection();
                GenelToplam();
                tbarkod.Focus();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HizliButonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int butonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));
            if (b.Text.ToString().StartsWith("b"))
            {
                HizliButonUrunEkleme f = new HizliButonUrunEkleme();
                f.lButonıd.Text = butonid.ToString();
                f.ShowDialog();

            }
            else
            {
               
                var urunbarkod = db.HizliUrun.Where(a => a.Id == butonid).Select(a => a.Barkod).FirstOrDefault();
                var urun = db.Urun.Where(a => a.Barkod == urunbarkod).FirstOrDefault();
                UrunGetirListele(urun, urunbarkod, Convert.ToDouble(tMiktar.Text));
                GenelToplam();
            }
        }
        BarkodDBEntities db = new BarkodDBEntities();
        private void tbarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                string barkod = tbarkod.Text.Trim();
                if (barkod.Length <= 2)
                {
                    tMiktar.Text = barkod;
                    tbarkod.Clear();
                    tbarkod.Focus();
                }
                else
                {
                   


                        
                        if (db.Urun.Any(a => a.Barkod == barkod))
                        {
                            var urun = db.Urun.Where(a => a.Barkod == barkod).FirstOrDefault();
                        UrunGetirListele(urun, barkod, Convert.ToDouble(tMiktar.Text));
                        


                    }
                    else
                    {
                        int onek = Convert.ToInt32(barkod.Substring(0, 2));
                        if (db.Terazi.Any(a => a.TeraziOnEk == onek))
                        {
                            string teraziurunno = barkod.Substring(2, 5);
                            if (db.Urun.Any(a => a.Barkod == teraziurunno))
                            {
                                var urunterazi = db.Urun.Where(a => a.Barkod == teraziurunno).FirstOrDefault();
                                double miktarkg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;
                                UrunGetirListele(urunterazi, teraziurunno, miktarkg);
                            }
                            else
                            {
                                Console.Beep(900, 2000);
                                MessageBox.Show("Kg ekleme Sayfası");
                            }
                           

                        }
                        else
                        {
                            Console.Beep(900, 2000);
                            MessageBox.Show("Normal ürünekleme sayfası :");

                        }
                    }

                    }
                dgrid.ClearSelection();
                GenelToplam();
                tbarkod.Focus();
                
            
                }
            }

        private void GenelToplam()
        {
            if (dgrid.Rows.Count > 0)
            {
                double toplam = 0;
                for(int i = 0; i < dgrid.Rows.Count; i++)
                {
                    toplam = Convert.ToDouble(dgrid.Rows[i].Cells["Toplam"].Value);
                }
                t1234.Text = toplam.ToString("C2");
                tMiktar.Text = "1";
                tbarkod.Clear();
                tbarkod.Focus();
            }
        }
        private void UrunGetirListele(Urun urun,string barkod,double miktar)
        {
            
            
            int satirsayisi = dgrid.Rows.Count;
          // double? miktar = Convert.ToDouble(tMiktar.Text);
            bool eklenmismi = false;
            if (satirsayisi > 0)
            {
                for (int i = 0; i < satirsayisi; i++)
                {
                    var data = dgrid.Rows[i].Cells["Barkod"].Value;
                    if (dgrid.Rows[i].Cells["Barkod"].Value != null && dgrid.Rows[i].Cells["Barkod"].Value == barkod)
                    {
                        if (double.TryParse(dgrid.Rows[i].Cells["Miktar"].Value?.ToString(), out double mevcutMiktar) &&
                    double.TryParse(dgrid.Rows[i].Cells["Fiyat"].Value?.ToString(), out double fiyat))
                        {
                            // Miktar Güncellemesi 
                            dgrid.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(dgrid.Rows[i].Cells["Miktar"].Value);
                            //Fiyat Güncellemesi .
                            dgrid.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(dgrid.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(dgrid.Rows[i].Cells["Fiyat"].Value), 2);
                            eklenmismi = true;
                            break;
                        }

                    }
                }
            }
            if (!eklenmismi)
            {
                int yeniSatir= dgrid.Rows.Add();
                dgrid.Rows[yeniSatir].Cells["Barkod"].Value = barkod ?? "Boş Barkod";

                dgrid.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                dgrid.Rows[satirsayisi].Cells["urunadi"].Value = urun.UrunAd ?? "Bilinmeyen urun";
                dgrid.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup ?? "Bilinmeyen Grup";
                dgrid.Rows[satirsayisi].Cells["Fiyat"].Value = urun.SatisFiyat != null ? urun.SatisFiyat : 0;
                dgrid.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim ?? "Birim Yok";
                dgrid.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                dgrid.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round((double)miktar * (double)urun.SatisFiyat , 2);
                dgrid.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat != null ? urun.AlisFiyat : 0;
                dgrid.Rows[satirsayisi].Cells["KDVTutari"].Value = urun.KDVTutari ;


            }
        }

        private void tbarkod_TextChanged(object sender, EventArgs e)
        {

        }

        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text== ",")
            {
                int virgul = tNumarator.Text.Count(x => x ==',');
                if (virgul <1)
                {
                    tNumarator.Text += b.Text;
                }

            }
            else if (b.Text == "<")
            {
                if (tNumarator.Text.Length > 0)
                {
                    tNumarator.Text = tNumarator.Text.Substring(0, tNumarator.Text.Length - 1);
                }
            }
            else
            {
                tNumarator.Text += b.Text;
            }

        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                int satirsayisi = dgrid.Rows.Count;
                dgrid.Rows.Add();
                dgrid.Rows[satirsayisi].Cells["Barkod"].Value = "1111111111116";
                dgrid.Rows[satirsayisi].Cells["urunadi"].Value = "Barkodsuz Urun";
                dgrid.Rows[satirsayisi].Cells["UrunGrup"].Value = "Barkodsuz Urun";
                dgrid.Rows[satirsayisi].Cells["Birim"].Value = "Adet";
                dgrid.Rows[satirsayisi].Cells["Miktar"].Value = 1;
                dgrid.Rows[satirsayisi].Cells["Fiyat"].Value = Convert.ToDouble(tNumarator.Text);
                dgrid.Rows[satirsayisi].Cells["KDVTutari"].Value = 0;
                dgrid.Rows[satirsayisi].Cells["Toplam"].Value = Convert.ToDouble(tNumarator.Text);
                tNumarator.Text = "";
                GenelToplam();
                tbarkod.Focus();


            }
        }

        private void bAdet_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                tMiktar.Text = tNumarator.Text;
                tNumarator.Clear();
                tbarkod.Clear();
                tbarkod.Focus();
            }
        }

        private void bOdenen_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                double sonuc = islemler.DoubleYap(tNumarator.Text) - islemler.DoubleYap(t1234.Text);
                tParaUstuu.Text = sonuc.ToString("C2");
                lOdenen.Text = islemler.DoubleYap(tNumarator.Text).ToString("C2");
                tNumarator.Clear();
                tbarkod.Focus();


            }
        }

        private void lParaÜstü_Click(object sender, EventArgs e)
        {

        }

       private void bBarkod_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                if(db.Urun.Any(a => a.Barkod == tNumarator.Text))
                {
                    var urun = db.Urun.Where(a => a.Barkod == tNumarator.Text).FirstOrDefault();
                   UrunGetirListele(urun, tNumarator.Text, Convert.ToDouble(tMiktar.Text));
                   
                }
                else
                {
                    MessageBox.Show("Ürün Ekleme Sayfasını Aç!");
                }
            }
        }

        private void paraUstuHesapla_Click(object sender, EventArgs e)
        {
            
                Button b = (Button)sender;
                double sonuc = islemler.DoubleYap(b.Text) - islemler.DoubleYap(t1234.Text);
            TextOdenen.Text = islemler.DoubleYap(b.Text).ToString("C2");
            tParaUstuu.Text = sonuc.ToString("C2");


            
        }

        private void biade_Click(object sender, EventArgs e)
        {
            if (bSatisYapiliyor.Checked)
            {
                bSatisYapiliyor.Checked = false;
                bSatisYapiliyor.Text = "Satış Yapılıyor";
            }
            else
            {
                bSatisYapiliyor.Checked = true;
                bSatisYapiliyor.Text = "İade işlemi";
            }
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            Temizlee();
        }

        private void Temizlee()
        {
            tMiktar.Text="1";
            tbarkod.Clear();
            t1234.Text = 0.ToString("C2");
            tParaUstuu.Clear();
            bSatisYapiliyor.Checked = false;
            dgrid.Rows.Clear();
            tNumarator.Text = "0";
            tbarkod.Clear();
            tbarkod.Focus();


        }
        public void SatisYap(string odemesekli)
        {
            int satirsayisi = dgrid.Rows.Count;
            bool satisiade = bSatisYapiliyor.Checked;// Burda hata olabilir.
            double alisfiyattoplam = 0;
            if (satirsayisi > 0)
            {
                int? islemno = db.Islem.First().IslemNo;
                Satis satis = new Satis();
                for(int i = 0; i < satirsayisi; i++)
                {
                    satis.IslemNo = islemno;
                    satis.UrunAd = dgrid.Rows[i].Cells["urunadi"].Value.ToString();
                    satis.UrunGrup = dgrid.Rows[i].Cells["UrunGrup"].Value.ToString();
                    satis.Barkod = dgrid.Rows[i].Cells["Barkod"].Value.ToString();
                    satis.Birim = dgrid.Rows[i].Cells["Birim"].Value.ToString();
                    satis.AlisFiyat = islemler.DoubleYap(dgrid.Rows[i].Cells["AlisFiyat"].Value.ToString());
                    satis.SatisFiyat = islemler.DoubleYap(dgrid.Rows[i].Cells["Fiyat"].Value.ToString());
                    satis.Miktar = islemler.DoubleYap(dgrid.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.kdvtutari = islemler.DoubleYap(dgrid.Rows[i].Cells["KDVTutari"].Value.ToString());
                    satis.Toplam = islemler.DoubleYap(dgrid.Rows[i].Cells["Toplam"].Value.ToString()) * islemler.DoubleYap(dgrid.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.odemeSekli = odemesekli;/* Parametrede ne seçilirse buraya o gelecek.*/
                    satis.Iade = satisiade;
                    satis.Tarih = DateTime.Now;
                    satis.Kullanici = lKullanici.Text;
                    db.Satis.Add(satis);
                    db.SaveChanges();
                    MessageBox.Show("Başarılı");

                    if (!satisiade)
                    {
                        islemler.StokAzalt(dgrid.Rows[i].Cells["Barkod"].Value.ToString(), islemler.DoubleYap(dgrid.Rows[i].Cells["Miktar"].Value.ToString()));
                    }
                    else
                    {
                        islemler.StokArtır(dgrid.Rows[i].Cells["Barkod"].Value.ToString(), islemler.DoubleYap(dgrid.Rows[i].Cells["Miktar"].Value.ToString()));


                    }
                    alisfiyattoplam += islemler.DoubleYap(dgrid.Rows[i].Cells["AlisFiyat"].Value.ToString());

                }
                IslemOzet io = new IslemOzet();
                io.IslemNo = islemno;
                io.Iade = satisiade;
                io.AlisFiyatToplam = alisfiyattoplam;
                io.Gelir = false;
                io.Gider = false;
                if(!satisiade)
                {
                    io.Aciklama = odemesekli + "Satis";
                }
                else
                {
                    io.Aciklama = "İade İşlemi (" + odemesekli + ")";
                    
                }
                io.OdemeSekli = odemesekli;
                io.Kullanici = lKullanici.Text;
                io.Tarih = DateTime.Now;
                switch (odemesekli)
                {
                    case "Nakit":
                        io.Nakit = islemler.DoubleYap(t1234.Text);
                        io.Kart = 0;
                        break;
                    case "Kart":
                        io.Nakit = 0;
                        io.Kart = islemler.DoubleYap(t1234.Text);
                        break;
                    case "Kart-Nakit":
                        io.Nakit = islemler.DoubleYap(lNakit.Text);
                        io.Kart = islemler.DoubleYap(lKart.Text);
                        break;
                }
                db.IslemOzet.Add(io);
                db.SaveChanges();

                var islemnoartir = db.Islem.First();
                islemnoartir.IslemNo += 1;
                db.SaveChanges();
                MessageBox.Show("Yazdırma İşlemi Yap");

            }


        }

        private void bNakit_Click(object sender, EventArgs e)
        {
            SatisYap("Nakit");
        }

        private void bKredikartı_Click(object sender, EventArgs e)
        {
            SatisYap("Kredi Kartı");
        }

        private void bKartNakit_Click(object sender, EventArgs e)
        {
            fNakitKart F = new fNakitKart();
            F.ShowDialog(); 
        }

        private void bSatisYapiliyor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void bDıgerUrun_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            /*if (e.KeyCode == Keys.F1)
            {
                SatisYap("Nakit");

            }*/
        }

        private void bDıgerUrun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SatisYap("Nakit");
            }
            if (e.KeyCode == Keys.F3)
            {
                SatisYap("Kart");
            }
            if (e.KeyCode == Keys.F2)
            {
                fNakitKart F = new fNakitKart();
                F.ShowDialog();
            }
        }

        private void bIslemBeklet_Click(object sender, EventArgs e)
        {
            if(bIslemBeklet.Text=="İŞLEM BEKLET")
            {
                Bekle();
                bIslemBeklet.BackColor = System.Drawing.Color.OrangeRed;
                bIslemBeklet.Text = "İşlem Bekliyor";
                dgrid.Rows.Clear();


            }
            else
            {
                BeklemedenCık();
                bIslemBeklet.BackColor = System.Drawing.Color.DimGray;
                bIslemBeklet.Text = "İşlem Bejkletmeden çıkıyor";
                gridBekle.Rows.Clear();

                
            }
            

        }

        private void Bekle()
        {
            int satir = dgrid.Rows.Count;
            int sutun = dgrid.Columns.Count;
            if (satir>0)
            {
                for(int i = 0; i < satir; i++)
                {
                    gridBekle.Rows.Add();
                    for(int j = 0; j < sutun; j++)
                    {
                        gridBekle.Rows[i].Cells[j].Value = dgrid.Rows[i].Cells[j].Value;


                        
                    }
                }

            }

        }
        private void BeklemedenCık()
        {
            int satir = gridBekle.Rows.Count;
            int sutun = gridBekle.Columns.Count;
            if (satir > 0)
            {
                for (int i = 0; i < satir; i++)
                {
                    dgrid.Rows.Add();
                    for (int j = 0; j < sutun; j++)
                    {
                        dgrid.Rows[i].Cells[j].Value = gridBekle.Rows[i].Cells[j].Value;



                    }
                }

            }
        }
    }
    
    
    }

