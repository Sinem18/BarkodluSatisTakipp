namespace BARKOD
{
    partial class StokIzleme
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTarihler = new System.Windows.Forms.Panel();
            this.lIslemTuru = new BARKOD.lStandart();
            this.lFiltrelemeTuru = new BARKOD.lStandart();
            this.lUrunGrubu = new BARKOD.lStandart();
            this.lBaslangıcTarih = new BARKOD.lStandart();
            this.lBitişTarihi = new BARKOD.lStandart();
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.dtBaslangucTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtBitişTarihi = new System.Windows.Forms.DateTimePicker();
            this.rdTumu = new System.Windows.Forms.RadioButton();
            this.rdUrunGrubunaGore = new System.Windows.Forms.RadioButton();
            this.bArama = new BARKOD.bStandart();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gridListe = new BARKOD.gridOzel();
            this.lUrunAra = new BARKOD.lStandart();
            this.tUrunAra = new BARKOD.tStandart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTarihler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainer1.Panel1.Controls.Add(this.bArama);
            this.splitContainer1.Panel1.Controls.Add(this.panelTarihler);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1134, 699);
            this.splitContainer1.SplitterDistance = 357;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbIslemTuru);
            this.panel1.Controls.Add(this.lIslemTuru);
            this.panel1.Location = new System.Drawing.Point(21, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 105);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdUrunGrubunaGore);
            this.panel2.Controls.Add(this.rdTumu);
            this.panel2.Controls.Add(this.lFiltrelemeTuru);
            this.panel2.Location = new System.Drawing.Point(21, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 156);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbUrunGrubu);
            this.panel3.Controls.Add(this.lUrunGrubu);
            this.panel3.Location = new System.Drawing.Point(27, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(326, 90);
            this.panel3.TabIndex = 2;
            // 
            // panelTarihler
            // 
            this.panelTarihler.Controls.Add(this.dtBitişTarihi);
            this.panelTarihler.Controls.Add(this.dtBaslangucTarihi);
            this.panelTarihler.Controls.Add(this.lBitişTarihi);
            this.panelTarihler.Controls.Add(this.lBaslangıcTarih);
            this.panelTarihler.Location = new System.Drawing.Point(27, 429);
            this.panelTarihler.Name = "panelTarihler";
            this.panelTarihler.Size = new System.Drawing.Size(324, 153);
            this.panelTarihler.TabIndex = 3;
            // 
            // lIslemTuru
            // 
            this.lIslemTuru.AutoSize = true;
            this.lIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lIslemTuru.ForeColor = System.Drawing.Color.Crimson;
            this.lIslemTuru.Location = new System.Drawing.Point(26, 10);
            this.lIslemTuru.Name = "lIslemTuru";
            this.lIslemTuru.Size = new System.Drawing.Size(137, 25);
            this.lIslemTuru.TabIndex = 0;
            this.lIslemTuru.Text = "İŞLEM TÜRÜ:";
            // 
            // lFiltrelemeTuru
            // 
            this.lFiltrelemeTuru.AutoSize = true;
            this.lFiltrelemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lFiltrelemeTuru.ForeColor = System.Drawing.Color.Crimson;
            this.lFiltrelemeTuru.Location = new System.Drawing.Point(27, 22);
            this.lFiltrelemeTuru.Name = "lFiltrelemeTuru";
            this.lFiltrelemeTuru.Size = new System.Drawing.Size(198, 25);
            this.lFiltrelemeTuru.TabIndex = 0;
            this.lFiltrelemeTuru.Text = "FİLTRELEME TÜRÜ:";
            // 
            // lUrunGrubu
            // 
            this.lUrunGrubu.AutoSize = true;
            this.lUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lUrunGrubu.ForeColor = System.Drawing.Color.Crimson;
            this.lUrunGrubu.Location = new System.Drawing.Point(20, 18);
            this.lUrunGrubu.Name = "lUrunGrubu";
            this.lUrunGrubu.Size = new System.Drawing.Size(147, 25);
            this.lUrunGrubu.TabIndex = 0;
            this.lUrunGrubu.Text = "ÜRÜN GRUBU:";
            // 
            // lBaslangıcTarih
            // 
            this.lBaslangıcTarih.AutoSize = true;
            this.lBaslangıcTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lBaslangıcTarih.ForeColor = System.Drawing.Color.Crimson;
            this.lBaslangıcTarih.Location = new System.Drawing.Point(17, 20);
            this.lBaslangıcTarih.Name = "lBaslangıcTarih";
            this.lBaslangıcTarih.Size = new System.Drawing.Size(202, 25);
            this.lBaslangıcTarih.TabIndex = 0;
            this.lBaslangıcTarih.Text = "BAŞLANGIÇ TARİHİ:";
            this.lBaslangıcTarih.Click += new System.EventHandler(this.lStandart4_Click);
            // 
            // lBitişTarihi
            // 
            this.lBitişTarihi.AutoSize = true;
            this.lBitişTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lBitişTarihi.ForeColor = System.Drawing.Color.Crimson;
            this.lBitişTarihi.Location = new System.Drawing.Point(18, 92);
            this.lBitişTarihi.Name = "lBitişTarihi";
            this.lBitişTarihi.Size = new System.Drawing.Size(137, 25);
            this.lBitişTarihi.TabIndex = 1;
            this.lBitişTarihi.Text = "BİTİŞ TARİHİ:";
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu ",
            "Stok Giriş Ekleme"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(28, 51);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(281, 24);
            this.cmbIslemTuru.TabIndex = 1;
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(25, 46);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(278, 24);
            this.cmbUrunGrubu.TabIndex = 1;
            // 
            // dtBaslangucTarihi
            // 
            this.dtBaslangucTarihi.Location = new System.Drawing.Point(22, 48);
            this.dtBaslangucTarihi.Name = "dtBaslangucTarihi";
            this.dtBaslangucTarihi.Size = new System.Drawing.Size(281, 22);
            this.dtBaslangucTarihi.TabIndex = 2;
            // 
            // dtBitişTarihi
            // 
            this.dtBitişTarihi.Location = new System.Drawing.Point(22, 120);
            this.dtBitişTarihi.Name = "dtBitişTarihi";
            this.dtBitişTarihi.Size = new System.Drawing.Size(281, 22);
            this.dtBitişTarihi.TabIndex = 3;
            // 
            // rdTumu
            // 
            this.rdTumu.AutoSize = true;
            this.rdTumu.Location = new System.Drawing.Point(31, 60);
            this.rdTumu.Name = "rdTumu";
            this.rdTumu.Size = new System.Drawing.Size(68, 20);
            this.rdTumu.TabIndex = 1;
            this.rdTumu.TabStop = true;
            this.rdTumu.Text = "TÜMÜ";
            this.rdTumu.UseVisualStyleBackColor = true;
            // 
            // rdUrunGrubunaGore
            // 
            this.rdUrunGrubunaGore.AutoSize = true;
            this.rdUrunGrubunaGore.Location = new System.Drawing.Point(31, 86);
            this.rdUrunGrubunaGore.Name = "rdUrunGrubunaGore";
            this.rdUrunGrubunaGore.Size = new System.Drawing.Size(181, 20);
            this.rdUrunGrubunaGore.TabIndex = 2;
            this.rdUrunGrubunaGore.TabStop = true;
            this.rdUrunGrubunaGore.Text = "ÜRÜN GRUBUNA GÖRE";
            this.rdUrunGrubunaGore.UseVisualStyleBackColor = true;
            // 
            // bArama
            // 
            this.bArama.BackColor = System.Drawing.Color.DeepPink;
            this.bArama.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bArama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bArama.Image = global::BARKOD.Properties.Resources.ara3232;
            this.bArama.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bArama.Location = new System.Drawing.Point(249, 593);
            this.bArama.Name = "bArama";
            this.bArama.Size = new System.Drawing.Size(102, 94);
            this.bArama.TabIndex = 5;
            this.bArama.Text = "ARA";
            this.bArama.UseVisualStyleBackColor = false;
            this.bArama.Click += new System.EventHandler(this.bArama_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer2.Panel1.Controls.Add(this.lUrunAra);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridListe);
            this.splitContainer2.Size = new System.Drawing.Size(773, 699);
            this.splitContainer2.SplitterDistance = 108;
            this.splitContainer2.TabIndex = 0;
            // 
            // gridListe
            // 
            this.gridListe.AllowUserToAddRows = false;
            this.gridListe.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListe.EnableHeadersVisualStyles = false;
            this.gridListe.Location = new System.Drawing.Point(0, 0);
            this.gridListe.Name = "gridListe";
            this.gridListe.RowHeadersVisible = false;
            this.gridListe.RowHeadersWidth = 51;
            this.gridListe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridListe.RowTemplate.Height = 30;
            this.gridListe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridListe.Size = new System.Drawing.Size(773, 587);
            this.gridListe.TabIndex = 1;
            // 
            // lUrunAra
            // 
            this.lUrunAra.AutoSize = true;
            this.lUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lUrunAra.ForeColor = System.Drawing.Color.DarkCyan;
            this.lUrunAra.Location = new System.Drawing.Point(27, 18);
            this.lUrunAra.Name = "lUrunAra";
            this.lUrunAra.Size = new System.Drawing.Size(90, 25);
            this.lUrunAra.TabIndex = 0;
            this.lUrunAra.Text = "Ürün Ara";
            // 
            // tUrunAra
            // 
            this.tUrunAra.BackColor = System.Drawing.Color.White;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAra.Location = new System.Drawing.Point(32, 61);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(221, 30);
            this.tUrunAra.TabIndex = 1;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // StokIzleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 699);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StokIzleme";
            this.Text = "Stok İzleme";
            this.Load += new System.EventHandler(this.StokIzleme_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelTarihler.ResumeLayout(false);
            this.panelTarihler.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private bStandart bArama;
        private System.Windows.Forms.Panel panelTarihler;
        private System.Windows.Forms.DateTimePicker dtBitişTarihi;
        private System.Windows.Forms.DateTimePicker dtBaslangucTarihi;
        private lStandart lBitişTarihi;
        private lStandart lBaslangıcTarih;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private lStandart lUrunGrubu;
        private System.Windows.Forms.RadioButton rdUrunGrubunaGore;
        private System.Windows.Forms.RadioButton rdTumu;
        private lStandart lFiltrelemeTuru;
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private lStandart lIslemTuru;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private tStandart tUrunAra;
        private lStandart lUrunAra;
        private gridOzel gridListe;
    }
}