namespace ODEV_1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.MusteriAra = new System.Windows.Forms.GroupBox();
            this.btnAramaYap = new System.Windows.Forms.Button();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.MTsec = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCagriBaslat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNotlarr = new System.Windows.Forms.TextBox();
            this.btnCagriBitir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKontrolKelime = new System.Windows.Forms.TextBox();
            this.btnKelimeAra = new System.Windows.Forms.Button();
            this.lblCagri = new System.Windows.Forms.Label();
            this.lblKontrol = new System.Windows.Forms.Label();
            this.txtBulunanKelime = new System.Windows.Forms.TextBox();
            this.lbAramalar = new System.Windows.Forms.ListBox();
            this.lbCagrilar = new System.Windows.Forms.ListBox();
            this.lbBulunanKelimeler = new System.Windows.Forms.ListBox();
            this.MusteriAra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MusteriAra
            // 
            this.MusteriAra.Controls.Add(this.btnAramaYap);
            this.MusteriAra.Controls.Add(this.txtMusteriID);
            this.MusteriAra.Location = new System.Drawing.Point(45, 53);
            this.MusteriAra.Name = "MusteriAra";
            this.MusteriAra.Size = new System.Drawing.Size(178, 105);
            this.MusteriAra.TabIndex = 0;
            this.MusteriAra.TabStop = false;
            this.MusteriAra.Text = "MusteriAra";
            // 
            // btnAramaYap
            // 
            this.btnAramaYap.Location = new System.Drawing.Point(23, 71);
            this.btnAramaYap.Name = "btnAramaYap";
            this.btnAramaYap.Size = new System.Drawing.Size(105, 23);
            this.btnAramaYap.TabIndex = 1;
            this.btnAramaYap.Text = "Arama Yap";
            this.btnAramaYap.UseVisualStyleBackColor = true;
            this.btnAramaYap.Click += new System.EventHandler(this.btnAramaYap_Click);
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(23, 35);
            this.txtMusteriID.Multiline = true;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(105, 22);
            this.txtMusteriID.TabIndex = 2;
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.Location = new System.Drawing.Point(229, 39);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(89, 16);
            this.lblArama.TabIndex = 2;
            this.lblArama.Text = "ARAMALAR";
            // 
            // MTsec
            // 
            this.MTsec.FormattingEnabled = true;
            this.MTsec.Items.AddRange(new object[] {
            "BireyselMT",
            "KurumsalMT"});
            this.MTsec.Location = new System.Drawing.Point(23, 31);
            this.MTsec.Name = "MTsec";
            this.MTsec.Size = new System.Drawing.Size(105, 24);
            this.MTsec.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCagriBaslat);
            this.groupBox1.Controls.Add(this.MTsec);
            this.groupBox1.Location = new System.Drawing.Point(45, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Musteri Temsilcisi Sec";
            // 
            // btnCagriBaslat
            // 
            this.btnCagriBaslat.Location = new System.Drawing.Point(23, 61);
            this.btnCagriBaslat.Name = "btnCagriBaslat";
            this.btnCagriBaslat.Size = new System.Drawing.Size(105, 23);
            this.btnCagriBaslat.TabIndex = 1;
            this.btnCagriBaslat.Text = "Cagri Baslat";
            this.btnCagriBaslat.UseVisualStyleBackColor = true;
            this.btnCagriBaslat.Click += new System.EventHandler(this.btnCagriBaslat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNotlarr);
            this.groupBox2.Controls.Add(this.btnCagriBitir);
            this.groupBox2.Location = new System.Drawing.Point(45, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 167);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cagri Notlari Topla";
            // 
            // txtNotlarr
            // 
            this.txtNotlarr.Location = new System.Drawing.Point(23, 33);
            this.txtNotlarr.Multiline = true;
            this.txtNotlarr.Name = "txtNotlarr";
            this.txtNotlarr.Size = new System.Drawing.Size(228, 90);
            this.txtNotlarr.TabIndex = 5;
            // 
            // btnCagriBitir
            // 
            this.btnCagriBitir.Location = new System.Drawing.Point(23, 129);
            this.btnCagriBitir.Name = "btnCagriBitir";
            this.btnCagriBitir.Size = new System.Drawing.Size(105, 23);
            this.btnCagriBitir.TabIndex = 1;
            this.btnCagriBitir.Text = "Cagri Bitir";
            this.btnCagriBitir.UseVisualStyleBackColor = true;
            this.btnCagriBitir.Click += new System.EventHandler(this.btnCagriBitir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKontrolKelime);
            this.groupBox3.Controls.Add(this.btnKelimeAra);
            this.groupBox3.Location = new System.Drawing.Point(368, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kelime Araması";
            // 
            // txtKontrolKelime
            // 
            this.txtKontrolKelime.Location = new System.Drawing.Point(23, 33);
            this.txtKontrolKelime.Name = "txtKontrolKelime";
            this.txtKontrolKelime.Size = new System.Drawing.Size(100, 22);
            this.txtKontrolKelime.TabIndex = 2;
            // 
            // btnKelimeAra
            // 
            this.btnKelimeAra.Location = new System.Drawing.Point(23, 61);
            this.btnKelimeAra.Name = "btnKelimeAra";
            this.btnKelimeAra.Size = new System.Drawing.Size(105, 23);
            this.btnKelimeAra.TabIndex = 1;
            this.btnKelimeAra.Text = "Ara";
            this.btnKelimeAra.UseVisualStyleBackColor = true;
            this.btnKelimeAra.Click += new System.EventHandler(this.btnKelimeAra_Click);
            // 
            // lblCagri
            // 
            this.lblCagri.AutoSize = true;
            this.lblCagri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCagri.Location = new System.Drawing.Point(229, 172);
            this.lblCagri.Name = "lblCagri";
            this.lblCagri.Size = new System.Drawing.Size(82, 16);
            this.lblCagri.TabIndex = 6;
            this.lblCagri.Text = "CAGRILAR";
            this.lblCagri.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKontrol
            // 
            this.lblKontrol.AutoSize = true;
            this.lblKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKontrol.Location = new System.Drawing.Point(552, 365);
            this.lblKontrol.Name = "lblKontrol";
            this.lblKontrol.Size = new System.Drawing.Size(148, 16);
            this.lblKontrol.TabIndex = 8;
            this.lblKontrol.Text = "SÖZCÜK TARAMASI";
            // 
            // txtBulunanKelime
            // 
            this.txtBulunanKelime.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBulunanKelime.Enabled = false;
            this.txtBulunanKelime.Location = new System.Drawing.Point(552, 384);
            this.txtBulunanKelime.Multiline = true;
            this.txtBulunanKelime.Name = "txtBulunanKelime";
            this.txtBulunanKelime.Size = new System.Drawing.Size(277, 94);
            this.txtBulunanKelime.TabIndex = 7;
            // 
            // lbAramalar
            // 
            this.lbAramalar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbAramalar.FormattingEnabled = true;
            this.lbAramalar.ItemHeight = 16;
            this.lbAramalar.Location = new System.Drawing.Point(232, 58);
            this.lbAramalar.Name = "lbAramalar";
            this.lbAramalar.Size = new System.Drawing.Size(277, 100);
            this.lbAramalar.TabIndex = 9;
            // 
            // lbCagrilar
            // 
            this.lbCagrilar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbCagrilar.FormattingEnabled = true;
            this.lbCagrilar.ItemHeight = 16;
            this.lbCagrilar.Location = new System.Drawing.Point(232, 191);
            this.lbCagrilar.Name = "lbCagrilar";
            this.lbCagrilar.Size = new System.Drawing.Size(277, 100);
            this.lbCagrilar.TabIndex = 10;
            // 
            // lbBulunanKelimeler
            // 
            this.lbBulunanKelimeler.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbBulunanKelimeler.FormattingEnabled = true;
            this.lbBulunanKelimeler.ItemHeight = 16;
            this.lbBulunanKelimeler.Location = new System.Drawing.Point(868, 216);
            this.lbBulunanKelimeler.Name = "lbBulunanKelimeler";
            this.lbBulunanKelimeler.Size = new System.Drawing.Size(277, 100);
            this.lbBulunanKelimeler.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 543);
            this.Controls.Add(this.lbBulunanKelimeler);
            this.Controls.Add(this.lbCagrilar);
            this.Controls.Add(this.lbAramalar);
            this.Controls.Add(this.lblKontrol);
            this.Controls.Add(this.txtBulunanKelime);
            this.Controls.Add(this.lblCagri);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.MusteriAra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MusteriAra.ResumeLayout(false);
            this.MusteriAra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MusteriAra;
        private System.Windows.Forms.Button btnAramaYap;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.ComboBox MTsec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCagriBaslat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNotlarr;
        private System.Windows.Forms.Button btnCagriBitir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKelimeAra;
        private System.Windows.Forms.Label lblCagri;
        private System.Windows.Forms.TextBox txtKontrolKelime;
        private System.Windows.Forms.Label lblKontrol;
        private System.Windows.Forms.TextBox txtBulunanKelime;
        private System.Windows.Forms.ListBox lbAramalar;
        private System.Windows.Forms.ListBox lbCagrilar;
        private System.Windows.Forms.ListBox lbBulunanKelimeler;
    }
}

