using Microsoft.EntityFrameworkCore;
using Oyuncakci.Models;

namespace Oyuncakci
{
    public partial class OyuncakForm : Form
    {
        private OyuncakciContext _context = new OyuncakciContext();
        private int seciliOyuncakId = -1;
        public OyuncakForm()
        {
            InitializeComponent();
        }

        private void Oyuncak_Load(object sender, EventArgs e)
        {
            KategorileriYukle();
            OyuncakListele();
        }

        private void KategorileriYukle()
        {
            var kategoriler = _context.Kategoriler.ToList();
            cmbKategori.DataSource = kategoriler;
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";
        }
        private void OyuncakListele()
        {
            dgvOyuncaklar.DataSource = _context.Oyuncaklar
                .Include(o => o.Kategori)
                .Select(o => new
                {
                    o.OyuncakID,
                    o.Ad,
                    o.Marka,
                    o.KategoriID,
                    o.Fiyat,
                    o.StokMiktari,
                    Kategori = o.Kategori.KategoriAdi
                }).ToList();
        }





        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOyuncaklar.Rows[e.RowIndex];
                seciliOyuncakId = Convert.ToInt32(row.Cells[0].Value);
                txtAd.Text = row.Cells[1].Value.ToString();
                txtMarka.Text = row.Cells[2].Value.ToString();
                cmbKategori.SelectedValue = row.Cells[3].Value;
                txtFiyat.Text = row.Cells[4].Value.ToString();
                nudStok.Value = Convert.ToDecimal(row.Cells[5].Value);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var oyuncak = new Oyuncak
            {
                Ad = txtAd.Text,
                Marka = txtMarka.Text,
                Fiyat = decimal.Parse(txtFiyat.Text),
                StokMiktari = (int)nudStok.Value,
                KategoriID = (int)cmbKategori.SelectedValue
            };

            _context.Oyuncaklar.Add(oyuncak);
            _context.SaveChanges();
            OyuncakListele();
            Temizle();
        }
        private void btnGuncelle_click(object sender, EventArgs e)
        {
            var oyuncak = _context.Oyuncaklar.Find(seciliOyuncakId);
            if (oyuncak != null)
            {
                oyuncak.Ad = txtAd.Text;
                oyuncak.Marka = txtMarka.Text;
                oyuncak.Fiyat = decimal.Parse(txtFiyat.Text);
                oyuncak.StokMiktari = (int)nudStok.Value;
                oyuncak.KategoriID = (int)cmbKategori.SelectedValue;

                _context.SaveChanges();
                OyuncakListele();
                Temizle();
            }
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtMarka.Clear();
            txtFiyat.Clear();
            nudStok.Value = 0;
            cmbKategori.SelectedIndex = 0;
            seciliOyuncakId = -1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var oyuncak = _context.Oyuncaklar.Find(seciliOyuncakId);
            if (oyuncak != null)
            {
                _context.Oyuncaklar.Remove(oyuncak);
                _context.SaveChanges();
                OyuncakListele();
                Temizle();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            var kategoriForm = new KategoriEkleForm();
            kategoriForm.ShowDialog();
            KategorileriYukle();
        }
    }
}
