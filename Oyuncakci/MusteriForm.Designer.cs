namespace Oyuncakci
{
    partial class MusteriForm
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
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            dataGridView1 = new DataGridView();
            musteriIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soyadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            musteriBindingSource = new BindingSource(components);

            SuspendLayout();

            // Ortak stil
            Color anaRenk = Color.FromArgb(52, 152, 219);
            Font genelFont = new Font("Segoe UI", 10F, FontStyle.Regular);
            Font butonFont = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Butonlar - Modern
            Button[] butonlar = { btnEkle, btnGuncelle, btnSil, btnTemizle };
            foreach (var btn in butonlar)
            {
                btn.BackColor = anaRenk;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = butonFont;
                btn.Size = new Size(75, 30);
            }

            // btnTemizle
            btnTemizle.Location = new Point(476, 210);
            btnTemizle.Text = "Temizle";
            btnTemizle.Click += btnTemizle_Click_1;

            // btnSil
            btnSil.Location = new Point(395, 210);
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click_1;

            // btnGuncelle
            btnGuncelle.Location = new Point(314, 210);
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.Click += btnGuncelle_Click_1;

            // btnEkle
            btnEkle.Location = new Point(233, 210);
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click_1;

            // Label'lar
            Label[] etiketler = { label1, label2, label3, label4, label5 };
            string[] etiketText = { "AD:", "SOYAD:", "EMAİL:", "TELEFON:", "ADRES:" };
            for (int i = 0; i < etiketler.Length; i++)
            {
                etiketler[i].AutoSize = true;
                etiketler[i].Font = genelFont;
                etiketler[i].ForeColor = Color.FromArgb(44, 62, 80);
                etiketler[i].Location = new Point(206, 60 + (i * 29));
                etiketler[i].Text = etiketText[i];
            }

            // TextBox'lar
            TextBox[] kutular = { txtAd, txtSoyad, txtEmail, txtTelefon, txtAdres };
            for (int i = 0; i < kutular.Length; i++)
            {
                kutular[i].Font = genelFont;
                kutular[i].Size = new Size(285, 23);
                kutular[i].Location = new Point(290, 52 + (i * 29));
            }
            txtAd.TextChanged += textBox1_TextChanged;

            // DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { musteriIDDataGridViewTextBoxColumn, adDataGridViewTextBoxColumn, soyadDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn, adresDataGridViewTextBoxColumn });
            dataGridView1.DataSource = musteriBindingSource;
            dataGridView1.Location = new Point(94, 275);
            dataGridView1.Size = new Size(643, 150);
            dataGridView1.DefaultCellStyle.Font = genelFont;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = anaRenk;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;

            // Kolonlar
            musteriIDDataGridViewTextBoxColumn.DataPropertyName = "MusteriID";
            musteriIDDataGridViewTextBoxColumn.HeaderText = "MusteriID";
            adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            adDataGridViewTextBoxColumn.HeaderText = "Ad";
            soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            adresDataGridViewTextBoxColumn.HeaderText = "Adres";

            // BindingSource
            musteriBindingSource.DataSource = typeof(Models.Musteri);

            // Form ayarları
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            BackColor = Color.White;
            Controls.AddRange(new Control[] {
        dataGridView1, btnTemizle, btnSil, btnGuncelle, btnEkle,
        label5, label4, label3, label2, label1,
        txtAdres, txtTelefon, txtEmail, txtSoyad, txtAd
    });
            Name = "Musteri";
            Text = "Müşteri Yönetimi";
            Load += Musteri_Load;

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
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private DataGridView dataGridView1;
        private BindingSource musteriBindingSource;
        private DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}