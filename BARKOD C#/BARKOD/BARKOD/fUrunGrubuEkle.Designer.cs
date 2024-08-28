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
            this.bSil = new BARKOD.bStandart();
            this.bEKlee = new BARKOD.bStandart();
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
            // bSil
            // 
            this.bSil.BackColor = System.Drawing.Color.Orchid;
            this.bSil.FlatAppearance.BorderColor = System.Drawing.Color.Orchid;
            this.bSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.Image = global::BARKOD.Properties.Resources.clear4848;
            this.bSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bSil.Location = new System.Drawing.Point(18, 357);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(178, 78);
            this.bSil.TabIndex = 5;
            this.bSil.Text = "Sil";
            this.bSil.UseVisualStyleBackColor = false;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bEKlee
            // 
            this.bEKlee.BackColor = System.Drawing.Color.DeepPink;
            this.bEKlee.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bEKlee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEKlee.Image = global::BARKOD.Properties.Resources.Ekle20;
            this.bEKlee.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bEKlee.Location = new System.Drawing.Point(202, 359);
            this.bEKlee.Name = "bEKlee";
            this.bEKlee.Size = new System.Drawing.Size(190, 76);
            this.bEKlee.TabIndex = 5;
            this.bEKlee.Text = "EKLE";
            this.bEKlee.UseVisualStyleBackColor = false;
            this.bEKlee.Click += new System.EventHandler(this.bStandart1_Click);
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 465);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEKlee);
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
        private bStandart bEKlee;
        private bStandart bSil;
    }
}