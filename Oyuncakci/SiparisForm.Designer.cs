namespace Oyuncakci
{
    partial class SiparisForm
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
            components = new System.ComponentModel.Container();
            cmbMusteri = new ComboBox();
            cmbOyuncak = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtBirimFiyat = new TextBox();
            label3 = new Label();
            nudAdet = new NumericUpDown();
            label4 = new Label();
            btnSepeteEkle = new Button();
            oyuncakBindingSource = new BindingSource(components);
            txtToplamTutar = new TextBox();
            label5 = new Label();
            siparisDetayBindingSource = new BindingSource(components);
            btnSiparisiKaydet = new Button();
            dgvSepet = new DataGridView();
            btnYeniMusteri = new Button();
            btnSepettenCikar = new Button();
            btnOdemeYap = new Button();
            lblStokMiktari = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oyuncakBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)siparisDetayBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSepet).BeginInit();
            SuspendLayout();
            // 
            // cmbMusteri
            // 
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(237, 41);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(260, 23);
            cmbMusteri.TabIndex = 0;
            cmbMusteri.SelectedIndexChanged += cmbMusteri_SelectedIndexChanged;
            // 
            // cmbOyuncak
            // 
            cmbOyuncak.FormattingEnabled = true;
            cmbOyuncak.Location = new Point(237, 78);
            cmbOyuncak.Name = "cmbOyuncak";
            cmbOyuncak.Size = new Size(189, 23);
            cmbOyuncak.TabIndex = 1;
            cmbOyuncak.SelectedIndexChanged += cmbOyuncak_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(70, 44);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 2;
            label1.Text = "Müşteri Seçimi:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(70, 81);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 3;
            label2.Text = "Oyuncak seçimi";
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(238, 113);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(259, 23);
            txtBirimFiyat.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(70, 116);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 5;
            label3.Text = "Seçilen oyuncağın fiyatı";
            // 
            // nudAdet
            // 
            nudAdet.Location = new Point(237, 157);
            nudAdet.Name = "nudAdet";
            nudAdet.Size = new Size(260, 23);
            nudAdet.TabIndex = 6;
            nudAdet.ValueChanged += nudAdet_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(70, 155);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Adet seçimi";
            label4.Click += label4_Click;
            // 
            // btnSepeteEkle
            // 
            btnSepeteEkle.Font = new Font("Segoe UI", 11F);
            btnSepeteEkle.Location = new Point(561, 146);
            btnSepeteEkle.Name = "btnSepeteEkle";
            btnSepeteEkle.Size = new Size(105, 39);
            btnSepeteEkle.TabIndex = 8;
            btnSepeteEkle.Text = "Sepete Ekle";
            btnSepeteEkle.UseVisualStyleBackColor = true;
            btnSepeteEkle.Click += btnSepeteEkle_Click;
            // 
            // oyuncakBindingSource
            // 
            oyuncakBindingSource.DataSource = typeof(Models.Oyuncak);
            // 
            // txtToplamTutar
            // 
            txtToplamTutar.Location = new Point(607, 117);
            txtToplamTutar.Name = "txtToplamTutar";
            txtToplamTutar.Size = new Size(105, 23);
            txtToplamTutar.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(607, 94);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 11;
            label5.Text = "Toplam Tutar";
            label5.Click += label5_Click;
            // 
            // siparisDetayBindingSource
            // 
            siparisDetayBindingSource.DataSource = typeof(Models.SiparisDetay);
            // 
            // btnSiparisiKaydet
            // 
            btnSiparisiKaydet.Font = new Font("Segoe UI", 11F);
            btnSiparisiKaydet.Location = new Point(528, 399);
            btnSiparisiKaydet.Name = "btnSiparisiKaydet";
            btnSiparisiKaydet.Size = new Size(119, 39);
            btnSiparisiKaydet.TabIndex = 13;
            btnSiparisiKaydet.Text = "Siparişi Kaydet";
            btnSiparisiKaydet.UseVisualStyleBackColor = true;
            btnSiparisiKaydet.Click += btnSiparisiKaydet_Click;
            // 
            // dgvSepet
            // 
            dgvSepet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSepet.Location = new Point(70, 229);
            dgvSepet.Name = "dgvSepet";
            dgvSepet.Size = new Size(642, 150);
            dgvSepet.TabIndex = 14;
            // 
            // btnYeniMusteri
            // 
            btnYeniMusteri.Location = new Point(551, 41);
            btnYeniMusteri.Name = "btnYeniMusteri";
            btnYeniMusteri.Size = new Size(161, 23);
            btnYeniMusteri.TabIndex = 15;
            btnYeniMusteri.Text = "Yeni Müşteri Kaydet";
            btnYeniMusteri.UseVisualStyleBackColor = true;
            btnYeniMusteri.Click += btnYeniMusteri_Click;
            // 
            // btnSepettenCikar
            // 
            btnSepettenCikar.Font = new Font("Segoe UI", 11F);
            btnSepettenCikar.Location = new Point(672, 146);
            btnSepettenCikar.Name = "btnSepettenCikar";
            btnSepettenCikar.Size = new Size(105, 39);
            btnSepettenCikar.TabIndex = 16;
            btnSepettenCikar.Text = "Sepetten Sil";
            btnSepettenCikar.UseVisualStyleBackColor = true;
            btnSepettenCikar.Click += btnSepettenCikar_Click;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Font = new Font("Segoe UI", 11F);
            btnOdemeYap.Location = new Point(669, 399);
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(119, 39);
            btnOdemeYap.TabIndex = 17;
            btnOdemeYap.Text = "Ödeme Yap";
            btnOdemeYap.UseVisualStyleBackColor = true;
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // lblStokMiktari
            // 
            lblStokMiktari.Font = new Font("Segoe UI", 10F);
            lblStokMiktari.Location = new Point(432, 76);
            lblStokMiktari.Name = "lblStokMiktari";
            lblStokMiktari.ReadOnly = true;
            lblStokMiktari.Size = new Size(65, 25);
            lblStokMiktari.TabIndex = 18;
            lblStokMiktari.TextChanged += lblStokMiktari_TextChanged;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStokMiktari);
            Controls.Add(btnOdemeYap);
            Controls.Add(btnSepettenCikar);
            Controls.Add(btnYeniMusteri);
            Controls.Add(dgvSepet);
            Controls.Add(btnSiparisiKaydet);
            Controls.Add(label5);
            Controls.Add(txtToplamTutar);
            Controls.Add(btnSepeteEkle);
            Controls.Add(label4);
            Controls.Add(nudAdet);
            Controls.Add(label3);
            Controls.Add(txtBirimFiyat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbOyuncak);
            Controls.Add(cmbMusteri);
            Name = "SiparisForm";
            Text = "SiparisForm";
            Load += SiparisForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)oyuncakBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)siparisDetayBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSepet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMusteri;
        private ComboBox cmbOyuncak;
        private Label label1;
        private Label label2;
        private TextBox txtBirimFiyat;
        private Label label3;
        private NumericUpDown nudAdet;
        private Label label4;
        private Button btnSepeteEkle;
        private BindingSource oyuncakBindingSource;
        private TextBox txtToplamTutar;
        private Label label5;
        private BindingSource siparisDetayBindingSource;
        private Button btnSiparisiKaydet;
        private DataGridViewTextBoxColumn oyuncakIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn siparisDataGridViewTextBoxColumn;
        private DataGridView dgvSepet;
        private Button btnYeniMusteri;
        private Button btnSepettenCikar;
        private Button btnOdemeYap;
        private TextBox lblStokMiktari;
    }
}