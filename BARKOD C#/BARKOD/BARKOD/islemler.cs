using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARKOD
{
    internal class islemler
    {
        public static double DoubleYap(String deger)
        {
            double sonuc;
            double.TryParse(deger, NumberStyles.Currency, CultureInfo.CurrentUICulture.NumberFormat, out sonuc);
            return sonuc;

        }
        public static void StokAzalt(string barkod,double miktar)
        {
            if (barkod != "1111111111116")
            {
                using (var db = new BarkodDBEntities())
                {
                    var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                    urunbilgi.Miktar -= miktar;
                    db.SaveChanges();
                }
            }
        }
        public static void StokArtır(string barkod, double miktar)
        {
            if (barkod != "1111111111116")
            {
                using (var db = new BarkodDBEntities())
                {
                    var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == barkod);
                    urunbilgi.Miktar += miktar;
                    db.SaveChanges();
                }
            }
        }

        public static void GridDuzenle(DataGridView dgv)
        {
            if(dgv.Columns.Count > 0)
            {
                for(int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch(dgv.Columns[i].HeaderText)
                    {
                        case "Id":
                        dgv.Columns[i].HeaderText = "Numara";
                        break;
                        case "UrunId ":
                            dgv.Columns[i].HeaderText = "Ürün Numarası";
                            break;
                        case "Aciklama":
                            dgv.Columns[i].HeaderText = "Açıklama";
                            break;
                        case "UrunGrup":
                            dgv.Columns[i].HeaderText = "Ürün Grup";
                            break;
                        case "AlisFiyat":
                            dgv.Columns[i].HeaderText = "Alış Fıyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "SatisFiyat":
                            dgv.Columns[i].HeaderText = "Satış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "KDVOrani":
                            dgv.Columns[i].HeaderText = "KDV Oranı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case " Birim":
                            dgv.Columns[i].DefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case " Miktar":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case " OdemeSekli":
                            dgv.Columns[i].HeaderText = "Ödeme Şekli";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        case "Kart":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "Nakit":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "Gelir":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "Gider":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;


                    }
                }
            }
        }

        public static void StokHareket(string barkod,string urunad,string birim,string urungrup,double miktar,string kullanici)
        {
            using (var db = new BarkodDBEntities())
            {
                StokHareket sh = new StokHareket();
                sh.Barkod = barkod;
                sh.UrunAd=urunad;
                sh.Birim = birim;
                sh.UrunGrup=urungrup;
                sh.Miktar=miktar;
                sh.Kullanici=kullanici;
                sh.Tarih=DateTime.Now;
                db.StokHareket.Add(sh);
                db.SaveChanges();

            }
        }
    }
}
