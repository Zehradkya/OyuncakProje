namespace Oyuncakci
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnOyuncak = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnCalisan = new System.Windows.Forms.Button();
            this.btnGecmis = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Arka plan
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            // lblBaslik
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblBaslik.Location = new System.Drawing.Point(0, 20);
            this.lblBaslik.Size = new System.Drawing.Size(400, 40);
            this.lblBaslik.Text = "🧸 Oyuncakçı Yönetim Paneli";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSaat
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaat.ForeColor = System.Drawing.Color.Gray;
            this.lblSaat.Location = new System.Drawing.Point(0, 420);
            this.lblSaat.Size = new System.Drawing.Size(400, 20);
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // timer
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // Ortak buton stilleri
            Color butonRenk = Color.FromArgb(52, 152, 219); // mavi
            Font butonFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            
            Button[] butonlar = { btnMusteri, btnOyuncak, btnSiparis, btnOdeme, btnStok, btnCalisan, btnGecmis };
            string[] yazi = { "Müşteri Yönetimi", "Oyuncaklar", "Sipariş Oluştur", "Ödeme", "Stok Girişi", "Çalışanlar", "Geçmiş Siparişler" };
            int topOffset = 80;

            for (int i = 0; i < butonlar.Length; i++)
            {
                Button btn = butonlar[i];
                btn.Text = yazi[i];
                btn.Size = new System.Drawing.Size(200, 40);
                btn.Location = new System.Drawing.Point(100, topOffset + i * 45);
                btn.BackColor = butonRenk;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = butonFont;
                this.Controls.Add(btn);
            }

            // Buton Event Eşlemeleri
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            this.btnOyuncak.Click += new System.EventHandler(this.btnOyuncak_Click);
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            this.btnCalisan.Click += new System.EventHandler(this.btnCalisan_Click);
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);

            // Form Özellikleri
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblSaat);

            this.Name = "MainForm";
            this.Text = "Oyuncakçı Paneli";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }


        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnOyuncak;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnCalisan;
        private System.Windows.Forms.Button btnGecmis;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timer1;
    }
}
