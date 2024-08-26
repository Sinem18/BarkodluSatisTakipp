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
    public class bStandart : Button
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);

        }
    }

    public class tNumeric : TextBox
    {
        public tNumeric()
        {
            this.Size = new System.Drawing.Size(115, 26);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "tNumeric";
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Click += TNumeric_Click;
            this.KeyPress += TNumeric_KeyPress;

        }

        private void TNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            //throw new NotImplementedException();
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;


            }
        }

        private void TNumeric_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            this.SelectAll();
        }
    }
    public class gridOzel : DataGridView
    {
        public gridOzel()
        {
            this.AllowUserToAddRows = false;
            this.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dock = System.Windows.Forms.DockStyle.None;
            this.EnableHeadersVisualStyles = false;
            this.Location = new System.Drawing.Point(3, 132);
            this.Name = "dgrid";
            this.RowHeadersVisible = false;
            this.RowHeadersWidth = 51;
            this.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.RowTemplate.Height = 30;
            this.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Size = new System.Drawing.Size(577, 465);
            this.TabIndex = 0;

        }

    }
}