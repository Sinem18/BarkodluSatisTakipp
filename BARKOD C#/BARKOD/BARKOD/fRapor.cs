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
                if(listFiltrelemeTuru.SelectedIndex==0)
                {
                    db.IslemOzet.Where(x=>x.Tarih>=baslangic &&  x.Tarih<=bitis).OrderByDescending(x=>x.Tarih).Load();
                    var islemozet=db.IslemOzet.Local.ToBindingList();
                    dgridListe.DataSource = islemozet;

                }
            }



            Cursor.Current = Cursors.Default;
        }
    }
}
