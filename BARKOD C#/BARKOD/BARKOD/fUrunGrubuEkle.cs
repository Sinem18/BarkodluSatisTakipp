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
    public partial class fUrunGrubuEkle : Form
    {
        public fUrunGrubuEkle()
        {
            InitializeComponent();
        }

        BarkodDBEntities db=new BarkodDBEntities();
        private void fUrunGrubuEkle_Load(object sender, EventArgs e)
        {

            GrupDoldur();

        }

        private void bStandart1_Click(object sender, EventArgs e)
        {
            if (tUrunGrupAd.Text != "")
            {
                UrunGrup ug=new UrunGrup();
                ug.UrunGrupAd = tUrunGrupAd.Text;
                db.UrunGrup.Add(ug);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Clear(); 
                MessageBox.Show("Ürün Grubu Eklenmiştir");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                if(f!= null)
                {
                    f.GrupDoldur();
                }



            }
            else
            {
                MessageBox.Show("Ürün Bilgisi Ekleyiniz:");
            }
        }
        private void GrupDoldur()
        {
            listUrunGrup.DisplayMember = "UrunGrupAd";
            listUrunGrup.ValueMember = "Id";
            listUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            int gurpid=Convert.ToInt32(listUrunGrup.SelectedValue.ToString());
            string grupad = listUrunGrup.Text;
            DialogResult onay = MessageBox.Show(grupad + "Grubu Silmek İstiyor Musunuz?","Silme İşlemi",MessageBoxButtons.YesNo);// Yes No Butonlarının bulunduğu bir mesaj kutusu oluşturur. 
            if(onay == DialogResult.Yes)
            {
                var grup=db.UrunGrup.FirstOrDefault(a=>a.Id==gurpid);
                db.UrunGrup.Remove(grup);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Focus();
                MessageBox.Show(grup + " Ürün Grubu Silindi");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                f.GrupDoldur();
            }
        }
    }
}
