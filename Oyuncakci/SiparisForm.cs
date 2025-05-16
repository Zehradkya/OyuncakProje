using Oyuncakci.Models;

namespace Oyuncakci
{
    public partial class SiparisForm : Form
    {
        private OyuncakciContext _context = new OyuncakciContext();
        private List<SiparisDetay> sepet = new List<SiparisDetay>();
        public SiparisForm()
        {
            InitializeComponent();
        }
        private void SiparisForm_Load(object sender, EventArgs e)
        {
            cmbMusteri.DataSource = _context.Musteriler.ToList();
            cmbMusteri.DisplayMember = "Ad";
            cmbMusteri.ValueMember = "MusteriID";

            cmbOyuncak.DataSource = _context.Oyuncaklar.ToList();
            cmbOyuncak.DisplayMember = "Ad";
            cmbOyuncak.ValueMember = "OyuncakID";

            cmbOyuncak.SelectedIndexChanged += cmbOyuncak_SelectedIndexChanged;
            nudAdet.Value = 1;

            if (cmbOyuncak.SelectedItem != null)
                txtBirimFiyat.Text = ((Oyuncak)cmbOyuncak.SelectedItem).Fiyat.ToString("0.00");
        }

        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudAdet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbOyuncak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOyuncak.SelectedItem != null)
            {
                var secilen = (Oyuncak)cmbOyuncak.SelectedItem;
                txtBirimFiyat.Text = secilen.Fiyat.ToString("0.00");
                lblStokMiktari.Text = $"Stokta: {secilen.StokMiktari} adet";
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (cmbOyuncak.SelectedItem == null) return;
            var secilenOyuncak = (Oyuncak)cmbOyuncak.SelectedItem;
            var adet = (int)nudAdet.Value;
            var fiyat = secilenOyuncak.Fiyat;

            //sepette bu üründen var mı kontrol kısmı
            int sepettekiMevcutAdet = sepet
            .Where(s => s.OyuncakID == secilenOyuncak.OyuncakID)
            .Sum(s => s.Adet);

            if (sepettekiMevcutAdet + adet > secilenOyuncak.StokMiktari)
            {
                int eklenebilecekMaks = secilenOyuncak.StokMiktari - sepettekiMevcutAdet;
                MessageBox.Show($"Stok yetersiz! Bu üründen sepete en fazla {eklenebilecekMaks} adet daha ekleyebilirsiniz.",
                    "Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (secilenOyuncak.StokMiktari < adet)
            {
                MessageBox.Show($"Stok yetersiz! En fazla {secilenOyuncak.StokMiktari} adet ekleyebilirsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var detay = new SiparisDetay
            {
                OyuncakID = secilenOyuncak.OyuncakID,
                Oyuncak = secilenOyuncak,
                Adet = adet,
                BirimFiyat = fiyat
            };

            sepet.Add(detay);
            SepetiYenile();
        }
        private void SepetiYenile()
        {
            dgvSepet.DataSource = null;

            dgvSepet.DataSource = sepet.Select((s, index) => new
            {
                No = index + 1,
                OyuncakAd = s.Oyuncak.Ad,
                Adet = s.Adet,
                BirimFiyat = s.BirimFiyat,
                Tutar = s.Adet * s.BirimFiyat
            }).ToList();

            // Görsel düzenlemeler
            dgvSepet.Columns["No"].HeaderText = "Sıra";
            dgvSepet.Columns["OyuncakAd"].HeaderText = "Oyuncak";
            dgvSepet.Columns["Adet"].HeaderText = "Adet";
            dgvSepet.Columns["BirimFiyat"].HeaderText = "Fiyat";
            dgvSepet.Columns["Tutar"].HeaderText = "Tutar";

            dgvSepet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSepet.RowHeadersVisible = false;
            dgvSepet.AllowUserToAddRows = false;
            dgvSepet.ReadOnly = true;

            // Toplam Tutar
            txtToplamTutar.Text = sepet.Sum(s => s.Adet * s.BirimFiyat).ToString("0.00");
        }

        private void btnSiparisiKaydet_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedItem == null || sepet.Count == 0)
            {
                MessageBox.Show("Lütfen müşteri seçin ve sepete en az 1 ürün ekleyin.");
                return;
            }

            var yeniSiparis = new Siparis
            {
                MusteriID = (int)cmbMusteri.SelectedValue,
                Tarih = DateTime.Now,
                ToplamTutar = sepet.Sum(s => s.Adet * s.BirimFiyat)
            };

            _context.Siparisler.Add(yeniSiparis);
            _context.SaveChanges();

            foreach (var detay in sepet)
            {
                detay.SiparisID = yeniSiparis.SiparisID;
                _context.SiparisDetaylari.Add(detay);

                var oyuncak = _context.Oyuncaklar.Find(detay.OyuncakID);
                oyuncak.StokMiktari -= detay.Adet;
            }

            _context.SaveChanges();
            MessageBox.Show("Sipariş başarıyla kaydedildi.");
            Temizle();

        }
        private void Temizle()
        {
            sepet.Clear();
            SepetiYenile();
            nudAdet.Value = 1;
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            var musteriForm = new MusteriForm();
            musteriForm.ShowDialog(); // Form kapanana kadar bekletir

            var musteriListesi = _context.Musteriler.ToList();
            cmbMusteri.DataSource = musteriListesi;
            cmbMusteri.DisplayMember = "Ad";
            cmbMusteri.ValueMember = "MusteriID";

            cmbMusteri.SelectedValue = musteriListesi.Last().MusteriID;
        }

        private void btnSepettenCikar_Click(object sender, EventArgs e)
        {
            if (dgvSepet.CurrentRow != null)
            {
                // Satırın indeksini al
                int seciliIndex = dgvSepet.CurrentRow.Index;

                // Listedeki o sıradaki ürünü sil
                if (seciliIndex >= 0 && seciliIndex < sepet.Count)
                {
                    sepet.RemoveAt(seciliIndex);
                    SepetiYenile();
                }
            }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            var odemeForm = new OdemeForm();
            odemeForm.ShowDialog();
        }

        private void lblStokMiktari_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
