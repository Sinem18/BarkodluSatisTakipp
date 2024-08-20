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
    public partial class Form1 : Form
    {
        public Form1()
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
            if (b.Name.ToString().StartsWith("-"))
            {
                HizliButonUrunEkleme f = new HizliButonUrunEkleme();
                f.lButonıd.Text = butonid.ToString();
                f.ShowDialog();

            }
            else
            {
               
                var urunbarkod = db.HizliUrun.Where(a => a.Id == butonid).Select(a => a.Barkod).FirstOrDefault();
                var urun = db.Urun.Where(a => a.Barkod == urunbarkod).FirstOrDefault();
                UrunGetirListele(urun, urunbarkod, 1);
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
                       // Miktar Güncellemesi 
                        dgrid.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(dgrid.Rows[i].Cells["Miktar"].Value);
                       //Fiyat Güncellemesi .
                        dgrid.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(dgrid.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(dgrid.Rows[i].Cells["Fiyat"].Value), 2);
                        eklenmismi = true;
                        break;


                    }
                }
            }
            if (!eklenmismi)
            {
                int yeniSatir= dgrid.Rows.Add();
                dgrid.Rows[yeniSatir].Cells["Barkod"].Value = barkod ?? "Boş Barkod";

                dgrid.Rows[satirsayisi].Cells["Barkod"].Value = barkod;
                dgrid.Rows[satirsayisi].Cells["UrunAdi"].Value = urun.UrunAd ?? "Bilinmeyen Ürün";
                dgrid.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup ?? "Bilinmeyen Grup";
                dgrid.Rows[satirsayisi].Cells["Fiyat"].Value = urun.SatisFiyat != null ? urun.SatisFiyat : 0;
                dgrid.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim ?? "Birim Yok";
                dgrid.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                dgrid.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round((double)miktar * (double)urun.SatisFiyat , 2);
                dgrid.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat != null ? urun.AlisFiyat : 0;
                dgrid.Rows[satirsayisi].Cells["KDVTutari"].Value = urun.KDVTutari ;

            }
        }
    }
    }

