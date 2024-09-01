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
    public partial class fRapor : Form
    {
        public fRapor()
        {
            InitializeComponent();
        }

        private void bStandart1_Click(object sender, EventArgs e)
        {

        }

        private void lStandart2_Click(object sender, EventArgs e)
        {

        }

        private void lStandart14_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bgoster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime baslangic=DateTime.Parse(dtbaslangıc.Value.ToShortDateString());
            DateTime bitis=DateTime.Parse(dtbitis.Value.ToShortDateString());
            bitis=bitis.AddDays(1); // +1 gün ekler. 
            using(var db=new BarkodDBEntities()) 
            {
                if(listFiltrelemeTuru.SelectedIndex==0) // Tümünü Getir.
                {
                    db.IslemOzet.Where(x=>x.Tarih>=baslangic &&  x.Tarih<=bitis).OrderByDescending(x=>x.Tarih).Load();
                    var islemozet=db.IslemOzet.Local.ToBindingList();
                    dgridListe.DataSource = islemozet;
                    // Satış İşlemleri
                    tSatisNakit.Text = Convert.ToString(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Nakit)).ToString();
                    tSatisKart.Text = Convert.ToString(islemozet.Where(x => x.Iade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Kart)).ToString();
                    // İade Durumunda
                    tiadeNakit.Text=Convert.ToDouble(islemozet.Where(x=>x.Iade==true).Sum(x=>x.Nakit)).ToString() ;
                    tiadeKart.Text = Convert.ToDouble(islemozet.Where(x => x.Iade == true).Sum(x => x.Kart)).ToString();
                    //Gelir İşlemleri 
                    tGelirNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString();
                    tGelirKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Kart)).ToString();
                    // Gider İşlemleri
                    tGiderNAkit.Text= Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString();
                    tGiderKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Kart)).ToString();

                    db.Satis.Where(x => x.Tarih >= baslangic && x.Tarih < bitis).Load();
                    var satistablosu = db.Satis.Local.ToBindingList();
                    double kdvtutarsatis = islemler.DoubleYap(satistablosu.Where(x => x.Iade == false).Sum(x => x.kdvtutari).ToString());
                    double kdvtutariiade = islemler.DoubleYap(satistablosu.Where(x => x.Iade == true).Sum(x => x.kdvtutari).ToString());
                    tKDVToplam.Text=(kdvtutarsatis-kdvtutariiade).ToString("C2");



                }
                else if (listFiltrelemeTuru.SelectedIndex == 1)// Satışlar
                {
                    db.IslemOzet.Where(x=>x.Tarih>=baslangic && x.Tarih <= bitis && x.Iade==false && x.Gelir==false && x.Gider==false ).Load();
                   var islemozet=db.IslemOzet.Local.ToBindingList();
                    dgridListe.DataSource=islemozet;

                }
                else if (listFiltrelemeTuru.SelectedIndex == 2) // İade 
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Iade == true).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    dgridListe.DataSource = islemozet;

                }
                else if (listFiltrelemeTuru.SelectedIndex == 3) // Gelirler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == true).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    
                }
                else if (listFiltrelemeTuru.SelectedIndex == 4) // Giderler
                {
                    db.IslemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis &&  x.Gider == true).Load();
                    var islemozet = db.IslemOzet.Local.ToBindingList();
                    

                }
            }


            islemler.GridDuzenle(dgridListe);
            Cursor.Current = Cursors.Default;
        }

        private void fRapor_Load(object sender, EventArgs e)
        {
            listFiltrelemeTuru.SelectedIndex = 0;
            tKartKomisyon.Text = islemler.KartKomisyon().ToString();
        }

        private void dgridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex==2 || e.ColumnIndex==6 || e.ColumnIndex == 7)
            {
                if(e.Value is bool)
                {
                    bool value= (bool)e.Value;
                    e.Value = (value) ? "Evet" : "Hayır"; 
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
