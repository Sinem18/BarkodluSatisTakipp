using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARKOD
{
    internal class Nesnelerim
    {
    }
    public class lStandart : System.Windows.Forms.Label
    {
        public lStandart()
        {
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Text = "lStandart";
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "lStandart";



        }
    }
    public class bStandart: Button
    {
        public bStandart()
        {
            this.BackColor = System.Drawing.Color.DeepPink;
            this.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Image = global::BARKOD.Properties.Resources.tl_48;
            this.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = "bNakit";
            this.Size = new System.Drawing.Size(109, 141);
            this.TabIndex = 5;
            this.Text = "NAKİT\r\n(F1)";
            this.UseVisualStyleBackColor = false;
            
        }
    }

    public class tStandart : TextBox
    {
        public tStandart()
        {
            this.Size = new System.Drawing.Size(250, 26);
            this.BackColor = System.Drawing.Color.White;
            this.Font =  new System.Drawing.Font("Microsoft Sans Serif",12F);

        }
    }

    public class tNumeric : TextBox
    {
        public tNumeric()
        {
            this.Size = new System.Drawing.Size(115, 26);
            this.BackColor = System.Drawing.Color.White;
            this.Font =  new System.Drawing.Font("Microsoft Sans Serif",12F);
        }
    }

}