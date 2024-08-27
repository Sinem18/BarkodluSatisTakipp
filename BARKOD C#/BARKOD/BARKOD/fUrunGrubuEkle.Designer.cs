namespace BARKOD
{
    partial class fUrunGrubuEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lStandart1 = new BARKOD.lStandart();
            this.listUrunGrup = new System.Windows.Forms.ListBox();
            this.tUrunGrupAd = new BARKOD.tStandart();
            this.bStandart1 = new BARKOD.bStandart();
            this.SuspendLayout();
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(12, 37);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(153, 25);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Ürün Grubu Adı:";
            // 
            // listUrunGrup
            // 
            this.listUrunGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUrunGrup.FormattingEnabled = true;
            this.listUrunGrup.ItemHeight = 25;
            this.listUrunGrup.Location = new System.Drawing.Point(18, 124);
            this.listUrunGrup.Name = "listUrunGrup";
            this.listUrunGrup.Size = new System.Drawing.Size(374, 229);
            this.listUrunGrup.TabIndex = 1;
            // 
            // tUrunGrupAd
            // 
            this.tUrunGrupAd.BackColor = System.Drawing.Color.White;
            this.tUrunGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunGrupAd.Location = new System.Drawing.Point(18, 77);
            this.tUrunGrupAd.Name = "tUrunGrupAd";
            this.tUrunGrupAd.Size = new System.Drawing.Size(374, 30);
            this.tUrunGrupAd.TabIndex = 2;
            // 
            // bStandart1
            // 
            this.bStandart1.BackColor = System.Drawing.Color.DeepPink;
            this.bStandart1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bStandart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStandart1.Image = global::BARKOD.Properties.Resources.Ekle20;
            this.bStandart1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bStandart1.Location = new System.Drawing.Point(18, 358);
            this.bStandart1.Name = "bStandart1";
            this.bStandart1.Size = new System.Drawing.Size(374, 76);
            this.bStandart1.TabIndex = 5;
            this.bStandart1.Text = "EKLE";
            this.bStandart1.UseVisualStyleBackColor = false;
            this.bStandart1.Click += new System.EventHandler(this.bStandart1_Click);
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 465);
            this.Controls.Add(this.bStandart1);
            this.Controls.Add(this.tUrunGrupAd);
            this.Controls.Add(this.listUrunGrup);
            this.Controls.Add(this.lStandart1);
            this.Name = "fUrunGrubuEkle";
            this.Text = "Ürün Grubu İşlemleri";
            this.Load += new System.EventHandler(this.fUrunGrubuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lStandart1;
        private System.Windows.Forms.ListBox listUrunGrup;
        private tStandart tUrunGrupAd;
        private bStandart bStandart1;
    }
}