namespace Oyuncakci
{
    partial class OyuncakForm
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
            btnTemizle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFiyat = new TextBox();
            txtMarka = new TextBox();
            txtAd = new TextBox();
            cmbKategori = new ComboBox();
            nudStok = new NumericUpDown();
            dgvOyuncaklar = new DataGridView();
            oyuncakIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            markaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fiyatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stokMiktariDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            oyuncakBindingSource = new BindingSource(components);
            btnKategoriEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)nudStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOyuncaklar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oyuncakBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(460, 151);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(75, 23);
            btnTemizle.TabIndex = 43;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(379, 151);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 42;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(298, 151);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 41;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(217, 151);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 40;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 73);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 39;
            label5.Text = "STOK MİKTARI:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 102);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 38;
            label4.Text = "FİYAT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 39);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 37;
            label3.Text = "KATEGORİ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 73);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 36;
            label2.Text = "MARKA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(113, 44);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 35;
            label1.Text = "AD:";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(205, 94);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(169, 23);
            txtFiyat.TabIndex = 33;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(205, 65);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(169, 23);
            txtMarka.TabIndex = 31;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(205, 36);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(169, 23);
            txtAd.TabIndex = 30;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(497, 36);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(169, 23);
            cmbKategori.TabIndex = 45;
            // 
            // nudStok
            // 
            nudStok.Location = new Point(497, 65);
            nudStok.Name = "nudStok";
            nudStok.Size = new Size(169, 23);
            nudStok.TabIndex = 46;
            // 
            // dgvOyuncaklar
            // 
            dgvOyuncaklar.AutoGenerateColumns = false;
            dgvOyuncaklar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOyuncaklar.Columns.AddRange(new DataGridViewColumn[] { oyuncakIDDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, markaDataGridViewTextBoxColumn, kategoriIDDataGridViewTextBoxColumn, fiyatDataGridViewTextBoxColumn, stokMiktariDataGridViewTextBoxColumn, kategoriDataGridViewTextBoxColumn });
            dgvOyuncaklar.DataSource = oyuncakBindingSource;
            dgvOyuncaklar.Location = new Point(30, 180);
            dgvOyuncaklar.Name = "dgvOyuncaklar";
            dgvOyuncaklar.Size = new Size(744, 150);
            dgvOyuncaklar.TabIndex = 47;
            dgvOyuncaklar.CellContentClick += dataGridView1_CellContentClick;
            // 
            // oyuncakIDDataGridViewTextBoxColumn
            // 
            oyuncakIDDataGridViewTextBoxColumn.DataPropertyName = "OyuncakID";
            oyuncakIDDataGridViewTextBoxColumn.HeaderText = "OyuncakID";
            oyuncakIDDataGridViewTextBoxColumn.Name = "oyuncakIDDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            adDataGridViewTextBoxColumn.HeaderText = "Ad";
            adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // kategoriIDDataGridViewTextBoxColumn
            // 
            kategoriIDDataGridViewTextBoxColumn.DataPropertyName = "KategoriID";
            kategoriIDDataGridViewTextBoxColumn.HeaderText = "KategoriID";
            kategoriIDDataGridViewTextBoxColumn.Name = "kategoriIDDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // stokMiktariDataGridViewTextBoxColumn
            // 
            stokMiktariDataGridViewTextBoxColumn.DataPropertyName = "StokMiktari";
            stokMiktariDataGridViewTextBoxColumn.HeaderText = "StokMiktari";
            stokMiktariDataGridViewTextBoxColumn.Name = "stokMiktariDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // oyuncakBindingSource
            // 
            oyuncakBindingSource.DataSource = typeof(Models.Oyuncak);
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(679, 38);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(95, 23);
            btnKategoriEkle.TabIndex = 48;
            btnKategoriEkle.Text = "Kategori Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // OyuncakForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKategoriEkle);
            Controls.Add(dgvOyuncaklar);
            Controls.Add(nudStok);
            Controls.Add(cmbKategori);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFiyat);
            Controls.Add(txtMarka);
            Controls.Add(txtAd);
            Name = "OyuncakForm";
            Text = "Oyuncak";
            Load += Oyuncak_Load;
            ((System.ComponentModel.ISupportInitialize)nudStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOyuncaklar).EndInit();
            ((System.ComponentModel.ISupportInitialize)oyuncakBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTemizle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtFiyat;
        private TextBox txtMarka;
        private TextBox txtAd;
        private ComboBox cmbKategori;
        private NumericUpDown nudStok;
        private DataGridView dgvOyuncaklar;
        private DataGridViewTextBoxColumn oyuncakIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stokMiktariDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private BindingSource oyuncakBindingSource;
        private Button btnKategoriEkle;
    }
}