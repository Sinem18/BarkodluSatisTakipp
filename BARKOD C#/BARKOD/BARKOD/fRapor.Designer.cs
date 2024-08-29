namespace BARKOD
{
    partial class fRapor
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
            this.lFiltreleme = new BARKOD.lStandart();
            this.listFiltrelemeTuru = new System.Windows.Forms.ListBox();
            this.panelTarihler = new System.Windows.Forms.Panel();
            this.dtbitis = new System.Windows.Forms.DateTimePicker();
            this.dtbaslangıc = new System.Windows.Forms.DateTimePicker();
            this.lBitişTarihi = new BARKOD.lStandart();
            this.lBaslangıcTarih = new BARKOD.lStandart();
            this.bgoster = new BARKOD.bStandart();
            this.bGelirEkle = new BARKOD.bStandart();
            this.lSatisToplam = new BARKOD.lStandart();
            this.lStandart3 = new BARKOD.lStandart();
            this.lStandart4 = new BARKOD.lStandart();
            this.lIadeToplam = new BARKOD.lStandart();
            this.lStandart6 = new BARKOD.lStandart();
            this.lStandart7 = new BARKOD.lStandart();
            this.lGelir = new BARKOD.lStandart();
            this.lStandart9 = new BARKOD.lStandart();
            this.lStandart10 = new BARKOD.lStandart();
            this.lGider = new BARKOD.lStandart();
            this.lStandart12 = new BARKOD.lStandart();
            this.lStandart13 = new BARKOD.lStandart();
            this.lKdvTop = new BARKOD.lStandart();
            this.lKarTkomi = new BARKOD.lStandart();
            this.bGiderEkle = new BARKOD.bStandart();
            this.tGelirNakit = new BARKOD.tNumeric();
            this.tGelirKart = new BARKOD.tNumeric();
            this.tGiderNAkit = new BARKOD.tNumeric();
            this.tGiderKart = new BARKOD.tNumeric();
            this.tiadeNakit = new BARKOD.tNumeric();
            this.tiadeKart = new BARKOD.tNumeric();
            this.tSatisNakit = new BARKOD.tNumeric();
            this.tSatisKart = new BARKOD.tNumeric();
            this.tKartKomisyon = new BARKOD.tNumeric();
            this.tKDVToplam = new BARKOD.tNumeric();
            this.dgridListe = new BARKOD.gridOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelTarihler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.tSatisKart);
            this.splitContainer1.Panel1.Controls.Add(this.tiadeKart);
            this.splitContainer1.Panel1.Controls.Add(this.tGiderKart);
            this.splitContainer1.Panel1.Controls.Add(this.tGelirKart);
            this.splitContainer1.Panel1.Controls.Add(this.tiadeNakit);
            this.splitContainer1.Panel1.Controls.Add(this.tSatisNakit);
            this.splitContainer1.Panel1.Controls.Add(this.tKDVToplam);
            this.splitContainer1.Panel1.Controls.Add(this.tKartKomisyon);
            this.splitContainer1.Panel1.Controls.Add(this.tGiderNAkit);
            this.splitContainer1.Panel1.Controls.Add(this.tGelirNakit);
            this.splitContainer1.Panel1.Controls.Add(this.bGiderEkle);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart13);
            this.splitContainer1.Panel1.Controls.Add(this.lKarTkomi);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart10);
            this.splitContainer1.Panel1.Controls.Add(this.lKdvTop);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart7);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart4);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart12);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart9);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart6);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart3);
            this.splitContainer1.Panel1.Controls.Add(this.lGider);
            this.splitContainer1.Panel1.Controls.Add(this.lGelir);
            this.splitContainer1.Panel1.Controls.Add(this.lIadeToplam);
            this.splitContainer1.Panel1.Controls.Add(this.lSatisToplam);
            this.splitContainer1.Panel1.Controls.Add(this.bgoster);
            this.splitContainer1.Panel1.Controls.Add(this.bGelirEkle);
            this.splitContainer1.Panel1.Controls.Add(this.panelTarihler);
            this.splitContainer1.Panel1.Controls.Add(this.listFiltrelemeTuru);
            this.splitContainer1.Panel1.Controls.Add(this.lFiltreleme);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.dgridListe);
            this.splitContainer1.Size = new System.Drawing.Size(1220, 644);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 0;
            // 
            // lFiltreleme
            // 
            this.lFiltreleme.AutoSize = true;
            this.lFiltreleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lFiltreleme.ForeColor = System.Drawing.Color.DarkCyan;
            this.lFiltreleme.Location = new System.Drawing.Point(33, 39);
            this.lFiltreleme.Name = "lFiltreleme";
            this.lFiltreleme.Size = new System.Drawing.Size(142, 25);
            this.lFiltreleme.TabIndex = 0;
            this.lFiltreleme.Text = "Filtreleme Türü";
            // 
            // listFiltrelemeTuru
            // 
            this.listFiltrelemeTuru.FormattingEnabled = true;
            this.listFiltrelemeTuru.ItemHeight = 16;
            this.listFiltrelemeTuru.Items.AddRange(new object[] {
            "Tümü ",
            "Satışlar",
            "İade",
            "Gelir(Satış Hariç)",
            "Gider(İade Hariç)"});
            this.listFiltrelemeTuru.Location = new System.Drawing.Point(38, 83);
            this.listFiltrelemeTuru.Name = "listFiltrelemeTuru";
            this.listFiltrelemeTuru.Size = new System.Drawing.Size(137, 148);
            this.listFiltrelemeTuru.TabIndex = 1;
            // 
            // panelTarihler
            // 
            this.panelTarihler.Controls.Add(this.dtbitis);
            this.panelTarihler.Controls.Add(this.dtbaslangıc);
            this.panelTarihler.Controls.Add(this.lBitişTarihi);
            this.panelTarihler.Controls.Add(this.lBaslangıcTarih);
            this.panelTarihler.Location = new System.Drawing.Point(181, 87);
            this.panelTarihler.Name = "panelTarihler";
            this.panelTarihler.Size = new System.Drawing.Size(314, 144);
            this.panelTarihler.TabIndex = 4;
            // 
            // dtbitis
            // 
            this.dtbitis.Location = new System.Drawing.Point(22, 111);
            this.dtbitis.Name = "dtbitis";
            this.dtbitis.Size = new System.Drawing.Size(281, 22);
            this.dtbitis.TabIndex = 3;
            // 
            // dtbaslangıc
            // 
            this.dtbaslangıc.Location = new System.Drawing.Point(22, 48);
            this.dtbaslangıc.Name = "dtbaslangıc";
            this.dtbaslangıc.Size = new System.Drawing.Size(281, 22);
            this.dtbaslangıc.TabIndex = 2;
            // 
            // lBitişTarihi
            // 
            this.lBitişTarihi.AutoSize = true;
            this.lBitişTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lBitişTarihi.ForeColor = System.Drawing.Color.Crimson;
            this.lBitişTarihi.Location = new System.Drawing.Point(17, 83);
            this.lBitişTarihi.Name = "lBitişTarihi";
            this.lBitişTarihi.Size = new System.Drawing.Size(137, 25);
            this.lBitişTarihi.TabIndex = 1;
            this.lBitişTarihi.Text = "BİTİŞ TARİHİ:";
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
            // 
            // bgoster
            // 
            this.bgoster.BackColor = System.Drawing.Color.DeepPink;
            this.bgoster.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink;
            this.bgoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgoster.Image = global::BARKOD.Properties.Resources.Ara32;
            this.bgoster.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bgoster.Location = new System.Drawing.Point(501, 136);
            this.bgoster.Name = "bgoster";
            this.bgoster.Size = new System.Drawing.Size(103, 84);
            this.bgoster.TabIndex = 5;
            this.bgoster.Text = "GÖSTER";
            this.bgoster.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bgoster.UseVisualStyleBackColor = false;
            this.bgoster.Click += new System.EventHandler(this.bgoster_Click);
            // 
            // bGelirEkle
            // 
            this.bGelirEkle.BackColor = System.Drawing.Color.HotPink;
            this.bGelirEkle.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.bGelirEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGelirEkle.Image = global::BARKOD.Properties.Resources.Ekle32;
            this.bGelirEkle.Location = new System.Drawing.Point(1085, 127);
            this.bGelirEkle.Name = "bGelirEkle";
            this.bGelirEkle.Size = new System.Drawing.Size(97, 70);
            this.bGelirEkle.TabIndex = 5;
            this.bGelirEkle.UseVisualStyleBackColor = false;
            this.bGelirEkle.Click += new System.EventHandler(this.bStandart1_Click);
            // 
            // lSatisToplam
            // 
            this.lSatisToplam.AutoSize = true;
            this.lSatisToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSatisToplam.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSatisToplam.Location = new System.Drawing.Point(622, 107);
            this.lSatisToplam.Name = "lSatisToplam";
            this.lSatisToplam.Size = new System.Drawing.Size(127, 25);
            this.lSatisToplam.TabIndex = 6;
            this.lSatisToplam.Text = "Satış Toplam";
            this.lSatisToplam.Click += new System.EventHandler(this.lStandart2_Click);
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(622, 136);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(56, 25);
            this.lStandart3.TabIndex = 7;
            this.lStandart3.Text = "Nakit";
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(622, 170);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(48, 25);
            this.lStandart4.TabIndex = 8;
            this.lStandart4.Text = "Kart";
            // 
            // lIadeToplam
            // 
            this.lIadeToplam.AutoSize = true;
            this.lIadeToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lIadeToplam.ForeColor = System.Drawing.Color.DarkCyan;
            this.lIadeToplam.Location = new System.Drawing.Point(777, 99);
            this.lIadeToplam.Name = "lIadeToplam";
            this.lIadeToplam.Size = new System.Drawing.Size(121, 25);
            this.lIadeToplam.TabIndex = 6;
            this.lIadeToplam.Text = "İade Toplam";
            this.lIadeToplam.Click += new System.EventHandler(this.lStandart2_Click);
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(777, 135);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(56, 25);
            this.lStandart6.TabIndex = 7;
            this.lStandart6.Text = "Nakit";
            // 
            // lStandart7
            // 
            this.lStandart7.AutoSize = true;
            this.lStandart7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart7.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart7.Location = new System.Drawing.Point(777, 169);
            this.lStandart7.Name = "lStandart7";
            this.lStandart7.Size = new System.Drawing.Size(48, 25);
            this.lStandart7.TabIndex = 8;
            this.lStandart7.Text = "Kart";
            // 
            // lGelir
            // 
            this.lGelir.AutoSize = true;
            this.lGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lGelir.ForeColor = System.Drawing.Color.DarkCyan;
            this.lGelir.Location = new System.Drawing.Point(979, 99);
            this.lGelir.Name = "lGelir";
            this.lGelir.Size = new System.Drawing.Size(52, 25);
            this.lGelir.TabIndex = 6;
            this.lGelir.Text = "Gelir";
            this.lGelir.Click += new System.EventHandler(this.lStandart2_Click);
            // 
            // lStandart9
            // 
            this.lStandart9.AutoSize = true;
            this.lStandart9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart9.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart9.Location = new System.Drawing.Point(930, 135);
            this.lStandart9.Name = "lStandart9";
            this.lStandart9.Size = new System.Drawing.Size(56, 25);
            this.lStandart9.TabIndex = 7;
            this.lStandart9.Text = "Nakit";
            // 
            // lStandart10
            // 
            this.lStandart10.AutoSize = true;
            this.lStandart10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart10.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart10.Location = new System.Drawing.Point(930, 169);
            this.lStandart10.Name = "lStandart10";
            this.lStandart10.Size = new System.Drawing.Size(48, 25);
            this.lStandart10.TabIndex = 8;
            this.lStandart10.Text = "Kart";
            // 
            // lGider
            // 
            this.lGider.AutoSize = true;
            this.lGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lGider.ForeColor = System.Drawing.Color.DarkCyan;
            this.lGider.Location = new System.Drawing.Point(989, 249);
            this.lGider.Name = "lGider";
            this.lGider.Size = new System.Drawing.Size(59, 25);
            this.lGider.TabIndex = 6;
            this.lGider.Text = "Gider";
            this.lGider.Click += new System.EventHandler(this.lStandart2_Click);
            // 
            // lStandart12
            // 
            this.lStandart12.AutoSize = true;
            this.lStandart12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart12.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart12.Location = new System.Drawing.Point(932, 282);
            this.lStandart12.Name = "lStandart12";
            this.lStandart12.Size = new System.Drawing.Size(56, 25);
            this.lStandart12.TabIndex = 7;
            this.lStandart12.Text = "Nakit";
            // 
            // lStandart13
            // 
            this.lStandart13.AutoSize = true;
            this.lStandart13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart13.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart13.Location = new System.Drawing.Point(932, 322);
            this.lStandart13.Name = "lStandart13";
            this.lStandart13.Size = new System.Drawing.Size(48, 25);
            this.lStandart13.TabIndex = 8;
            this.lStandart13.Text = "Kart";
            // 
            // lKdvTop
            // 
            this.lKdvTop.AutoSize = true;
            this.lKdvTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKdvTop.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKdvTop.Location = new System.Drawing.Point(624, 289);
            this.lKdvTop.Name = "lKdvTop";
            this.lKdvTop.Size = new System.Drawing.Size(125, 25);
            this.lKdvTop.TabIndex = 8;
            this.lKdvTop.Text = "KDV Toplam";
            this.lKdvTop.Click += new System.EventHandler(this.lStandart14_Click);
            // 
            // lKarTkomi
            // 
            this.lKarTkomi.AutoSize = true;
            this.lKarTkomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKarTkomi.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKarTkomi.Location = new System.Drawing.Point(777, 289);
            this.lKarTkomi.Name = "lKarTkomi";
            this.lKarTkomi.Size = new System.Drawing.Size(145, 25);
            this.lKarTkomi.TabIndex = 8;
            this.lKarTkomi.Text = "Kart Komisyon ";
            // 
            // bGiderEkle
            // 
            this.bGiderEkle.BackColor = System.Drawing.Color.DarkCyan;
            this.bGiderEkle.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.bGiderEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGiderEkle.Image = global::BARKOD.Properties.Resources.Ekle32;
            this.bGiderEkle.Location = new System.Drawing.Point(1085, 279);
            this.bGiderEkle.Name = "bGiderEkle";
            this.bGiderEkle.Size = new System.Drawing.Size(97, 70);
            this.bGiderEkle.TabIndex = 11;
            this.bGiderEkle.UseVisualStyleBackColor = false;
            // 
            // tGelirNakit
            // 
            this.tGelirNakit.BackColor = System.Drawing.Color.White;
            this.tGelirNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tGelirNakit.Location = new System.Drawing.Point(984, 127);
            this.tGelirNakit.Name = "tGelirNakit";
            this.tGelirNakit.Size = new System.Drawing.Size(78, 30);
            this.tGelirNakit.TabIndex = 12;
            this.tGelirNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tGelirKart
            // 
            this.tGelirKart.BackColor = System.Drawing.Color.White;
            this.tGelirKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tGelirKart.Location = new System.Drawing.Point(984, 163);
            this.tGelirKart.Name = "tGelirKart";
            this.tGelirKart.Size = new System.Drawing.Size(78, 30);
            this.tGelirKart.TabIndex = 12;
            this.tGelirKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tGiderNAkit
            // 
            this.tGiderNAkit.BackColor = System.Drawing.Color.White;
            this.tGiderNAkit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tGiderNAkit.Location = new System.Drawing.Point(994, 277);
            this.tGiderNAkit.Name = "tGiderNAkit";
            this.tGiderNAkit.Size = new System.Drawing.Size(78, 30);
            this.tGiderNAkit.TabIndex = 12;
            this.tGiderNAkit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tGiderKart
            // 
            this.tGiderKart.BackColor = System.Drawing.Color.White;
            this.tGiderKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tGiderKart.Location = new System.Drawing.Point(994, 313);
            this.tGiderKart.Name = "tGiderKart";
            this.tGiderKart.Size = new System.Drawing.Size(78, 30);
            this.tGiderKart.TabIndex = 12;
            this.tGiderKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tiadeNakit
            // 
            this.tiadeNakit.BackColor = System.Drawing.Color.White;
            this.tiadeNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tiadeNakit.Location = new System.Drawing.Point(839, 131);
            this.tiadeNakit.Name = "tiadeNakit";
            this.tiadeNakit.Size = new System.Drawing.Size(78, 30);
            this.tiadeNakit.TabIndex = 12;
            this.tiadeNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tiadeKart
            // 
            this.tiadeKart.BackColor = System.Drawing.Color.White;
            this.tiadeKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tiadeKart.Location = new System.Drawing.Point(839, 165);
            this.tiadeKart.Name = "tiadeKart";
            this.tiadeKart.Size = new System.Drawing.Size(78, 30);
            this.tiadeKart.TabIndex = 12;
            this.tiadeKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tSatisNakit
            // 
            this.tSatisNakit.BackColor = System.Drawing.Color.White;
            this.tSatisNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tSatisNakit.Location = new System.Drawing.Point(676, 131);
            this.tSatisNakit.Name = "tSatisNakit";
            this.tSatisNakit.Size = new System.Drawing.Size(85, 30);
            this.tSatisNakit.TabIndex = 12;
            this.tSatisNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tSatisKart
            // 
            this.tSatisKart.BackColor = System.Drawing.Color.White;
            this.tSatisKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tSatisKart.Location = new System.Drawing.Point(676, 167);
            this.tSatisKart.Name = "tSatisKart";
            this.tSatisKart.Size = new System.Drawing.Size(85, 30);
            this.tSatisKart.TabIndex = 12;
            this.tSatisKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tKartKomisyon
            // 
            this.tKartKomisyon.BackColor = System.Drawing.Color.White;
            this.tKartKomisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKartKomisyon.Location = new System.Drawing.Point(782, 317);
            this.tKartKomisyon.Name = "tKartKomisyon";
            this.tKartKomisyon.Size = new System.Drawing.Size(103, 30);
            this.tKartKomisyon.TabIndex = 12;
            this.tKartKomisyon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tKDVToplam
            // 
            this.tKDVToplam.BackColor = System.Drawing.Color.White;
            this.tKDVToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKDVToplam.Location = new System.Drawing.Point(629, 317);
            this.tKDVToplam.Name = "tKDVToplam";
            this.tKDVToplam.Size = new System.Drawing.Size(96, 30);
            this.tKDVToplam.TabIndex = 12;
            this.tKDVToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgridListe
            // 
            this.dgridListe.AllowUserToAddRows = false;
            this.dgridListe.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgridListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridListe.EnableHeadersVisualStyles = false;
            this.dgridListe.Location = new System.Drawing.Point(0, 0);
            this.dgridListe.Name = "dgridListe";
            this.dgridListe.RowHeadersVisible = false;
            this.dgridListe.RowHeadersWidth = 51;
            this.dgridListe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.dgridListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgridListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgridListe.RowTemplate.Height = 30;
            this.dgridListe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgridListe.Size = new System.Drawing.Size(1220, 250);
            this.dgridListe.TabIndex = 2;
            // 
            // fRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1220, 644);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fRapor";
            this.Text = "Raporlama Sayfası";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelTarihler.ResumeLayout(false);
            this.panelTarihler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listFiltrelemeTuru;
        private lStandart lFiltreleme;
        private System.Windows.Forms.Panel panelTarihler;
        private System.Windows.Forms.DateTimePicker dtbitis;
        private System.Windows.Forms.DateTimePicker dtbaslangıc;
        private lStandart lBitişTarihi;
        private lStandart lBaslangıcTarih;
        private bStandart bGelirEkle;
        private bStandart bgoster;
        private lStandart lStandart4;
        private lStandart lStandart3;
        private lStandart lSatisToplam;
        private lStandart lStandart13;
        private lStandart lKarTkomi;
        private lStandart lStandart10;
        private lStandart lKdvTop;
        private lStandart lStandart7;
        private lStandart lStandart12;
        private lStandart lStandart9;
        private lStandart lStandart6;
        private lStandart lGider;
        private lStandart lGelir;
        private lStandart lIadeToplam;
        private bStandart bGiderEkle;
        private tNumeric tSatisKart;
        private tNumeric tiadeKart;
        private tNumeric tGiderKart;
        private tNumeric tGelirKart;
        private tNumeric tiadeNakit;
        private tNumeric tSatisNakit;
        private tNumeric tGiderNAkit;
        private tNumeric tGelirNakit;
        private tNumeric tKDVToplam;
        private tNumeric tKartKomisyon;
        private gridOzel dgridListe;
    }
}