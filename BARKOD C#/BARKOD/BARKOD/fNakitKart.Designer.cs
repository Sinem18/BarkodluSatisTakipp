namespace BARKOD
{
    partial class fNakitKart
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
            this.tNakit = new System.Windows.Forms.TextBox();
            this.lNakitMiktarı = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.bNV = new System.Windows.Forms.Button();
            this.bN0 = new System.Windows.Forms.Button();
            this.bNB = new System.Windows.Forms.Button();
            this.bN9 = new System.Windows.Forms.Button();
            this.bN8 = new System.Windows.Forms.Button();
            this.bN7 = new System.Windows.Forms.Button();
            this.bN6 = new System.Windows.Forms.Button();
            this.bN5 = new System.Windows.Forms.Button();
            this.bN4 = new System.Windows.Forms.Button();
            this.bN3 = new System.Windows.Forms.Button();
            this.bN2 = new System.Windows.Forms.Button();
            this.bN1 = new System.Windows.Forms.Button();
            this.bEnter = new System.Windows.Forms.Button();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tNakit
            // 
            this.tNakit.Location = new System.Drawing.Point(15, 87);
            this.tNakit.Name = "tNakit";
            this.tNakit.Size = new System.Drawing.Size(395, 22);
            this.tNakit.TabIndex = 0;
            this.tNakit.TextChanged += new System.EventHandler(this.tbarkod_TextChanged);
            this.tNakit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tNakit_KeyDown);
            this.tNakit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNakit_KeyPress);
            // 
            // lNakitMiktarı
            // 
            this.lNakitMiktarı.AutoSize = true;
            this.lNakitMiktarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lNakitMiktarı.Location = new System.Drawing.Point(12, 68);
            this.lNakitMiktarı.Name = "lNakitMiktarı";
            this.lNakitMiktarı.Size = new System.Drawing.Size(97, 16);
            this.lNakitMiktarı.TabIndex = 4;
            this.lNakitMiktarı.Text = "Nakit Miktarı:";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel8.Controls.Add(this.bNV, 2, 3);
            this.tableLayoutPanel8.Controls.Add(this.bN0, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.bNB, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.bN9, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.bN8, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.bN7, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.bN6, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.bN5, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.bN4, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.bN3, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.bN2, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.bN1, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(12, 115);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 4;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(398, 345);
            this.tableLayoutPanel8.TabIndex = 5;
            this.tableLayoutPanel8.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel8_Paint);
            // 
            // bNV
            // 
            this.bNV.BackColor = System.Drawing.Color.Plum;
            this.bNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bNV.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bNV.Location = new System.Drawing.Point(267, 261);
            this.bNV.Name = "bNV";
            this.bNV.Size = new System.Drawing.Size(128, 81);
            this.bNV.TabIndex = 11;
            this.bNV.Text = ",";
            this.bNV.UseVisualStyleBackColor = false;
            this.bNV.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bN0
            // 
            this.bN0.BackColor = System.Drawing.Color.Plum;
            this.bN0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bN0.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bN0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bN0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bN0.Location = new System.Drawing.Point(135, 261);
            this.bN0.Name = "bN0";
            this.bN0.Size = new System.Drawing.Size(126, 81);
            this.bN0.TabIndex = 10;
            this.bN0.Text = "0";
            this.bN0.UseVisualStyleBackColor = false;
            this.bN0.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bNB
            // 
            this.bNB.BackColor = System.Drawing.Color.Plum;
            this.bNB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bNB.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bNB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bNB.Location = new System.Drawing.Point(3, 261);
            this.bNB.Name = "bNB";
            this.bNB.Size = new System.Drawing.Size(126, 81);
            this.bNB.TabIndex = 9;
            this.bNB.Text = "<";
            this.bNB.UseVisualStyleBackColor = false;
            this.bNB.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bN9
            // 
            this.bN9.BackColor = System.Drawing.Color.Plum;
            this.bN9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bN9.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bN9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bN9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bN9.Location = new System.Drawing.Point(267, 175);
            this.bN9.Name = "bN9";
            this.bN9.Size = new System.Drawing.Size(128, 80);
            this.bN9.TabIndex = 8;
            this.bN9.Text = "9";
            this.bN9.UseVisualStyleBackColor = false;
            this.bN9.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bN8
            // 
            this.bN8.BackColor = System.Drawing.Color.Plum;
            this.bN8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bN8.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bN8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bN8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bN8.Location = new System.Drawing.Point(135, 175);
            this.bN8.Name = "bN8";
            this.bN8.Size = new System.Drawing.Size(126, 80);
            this.bN8.TabIndex = 7;
            this.bN8.Text = "8";
            this.bN8.UseVisualStyleBackColor = false;
            this.bN8.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bN7
            // 
            this.bN7.BackColor = System.Drawing.Color.Plum;
            this.bN7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bN7.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bN7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bN7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bN7.Location = new System.Drawing.Point(3, 175);
            this.bN7.Name = "bN7";
            this.bN7.Size = new System.Drawing.Size(126, 80);
            this.bN7.TabIndex = 6;
            this.bN7.Text = "7";
            this.bN7.UseVisualStyleBackColor = false;
            this.bN7.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bN6
            // 
            this.bN6.BackColor = System.Drawing.Color.Plum;
            this.bN6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bN6.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bN6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bN6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bN6.Location = new System.Drawing.Point(267, 89);
            this.bN6.Name = "bN6";
            this.bN6.Size = new System.Drawing.Size(128, 80);
            this.bN6.TabIndex = 5;
            this.bN6.Text = "6";
            this.bN6.UseVisualStyleBackColor = false;
            this.bN6.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bN5
            // 
            this.bN5.BackColor = System.Drawing.Color.Plum;
            this.bN5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bN5.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bN5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bN5.Location = new System.Drawing.Point(135, 89);
            this.bN5.Name = "bN5";
            this.bN5.Size = new System.Drawing.Size(126, 80);
            this.bN5.TabIndex = 4;
            this.bN5.Text = "5";
            this.bN5.UseVisualStyleBackColor = false;
            this.bN5.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bN4
            // 
            this.bN4.BackColor = System.Drawing.Color.Plum;
            this.bN4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bN4.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bN4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bN4.Location = new System.Drawing.Point(3, 89);
            this.bN4.Name = "bN4";
            this.bN4.Size = new System.Drawing.Size(126, 80);
            this.bN4.TabIndex = 3;
            this.bN4.Text = "4";
            this.bN4.UseVisualStyleBackColor = false;
            this.bN4.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bN3
            // 
            this.bN3.BackColor = System.Drawing.Color.Plum;
            this.bN3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bN3.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bN3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bN3.Location = new System.Drawing.Point(267, 3);
            this.bN3.Name = "bN3";
            this.bN3.Size = new System.Drawing.Size(128, 80);
            this.bN3.TabIndex = 2;
            this.bN3.Text = "3";
            this.bN3.UseVisualStyleBackColor = false;
            this.bN3.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bN2
            // 
            this.bN2.BackColor = System.Drawing.Color.Plum;
            this.bN2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bN2.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bN2.Location = new System.Drawing.Point(135, 3);
            this.bN2.Name = "bN2";
            this.bN2.Size = new System.Drawing.Size(126, 80);
            this.bN2.TabIndex = 1;
            this.bN2.Text = "2";
            this.bN2.UseVisualStyleBackColor = false;
            this.bN2.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bN1
            // 
            this.bN1.BackColor = System.Drawing.Color.Plum;
            this.bN1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bN1.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.bN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bN1.Location = new System.Drawing.Point(3, 3);
            this.bN1.Name = "bN1";
            this.bN1.Size = new System.Drawing.Size(126, 80);
            this.bN1.TabIndex = 0;
            this.bN1.Text = "1";
            this.bN1.UseVisualStyleBackColor = false;
            this.bN1.Click += new System.EventHandler(this.bNx_Click);
            // 
            // bEnter
            // 
            this.bEnter.BackColor = System.Drawing.Color.DeepPink;
            this.bEnter.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEnter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bEnter.Location = new System.Drawing.Point(413, 87);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(126, 373);
            this.bEnter.TabIndex = 6;
            this.bEnter.Text = "ENTER";
            this.bEnter.UseVisualStyleBackColor = false;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // fNakitKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 465);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.tableLayoutPanel8);
            this.Controls.Add(this.lNakitMiktarı);
            this.Controls.Add(this.tNakit);
            this.Name = "fNakitKart";
            this.Text = "fNakitKart";
            this.Load += new System.EventHandler(this.fNakitKart_Load);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNakit;
        private System.Windows.Forms.Label lNakitMiktarı;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button bNV;
        private System.Windows.Forms.Button bN0;
        private System.Windows.Forms.Button bNB;
        private System.Windows.Forms.Button bN9;
        private System.Windows.Forms.Button bN8;
        private System.Windows.Forms.Button bN7;
        private System.Windows.Forms.Button bN6;
        private System.Windows.Forms.Button bN5;
        private System.Windows.Forms.Button bN4;
        private System.Windows.Forms.Button bN3;
        private System.Windows.Forms.Button bN2;
        private System.Windows.Forms.Button bN1;
        private System.Windows.Forms.Button bEnter;
    }
}