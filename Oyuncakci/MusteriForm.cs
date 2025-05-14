using Oyuncakci.Models;

namespace Oyuncakci
{
    public partial class MusteriForm : Form
    {
        private OyuncakciContext _context = new OyuncakciContext();
        private int seciliMusteriId = -1;
        public MusteriForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }


        private void MusteriListele()
        {
            dataGridView1.DataSource = _context.Musteriler
                .Select(m => new
                {
                    m.MusteriID,
                    m.Ad,
                    m.Soyad,
                    m.Email,
                    m.Telefon,
                    m.Adres
                }).ToList();
        }


        //ekle butonu
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            var musteri = new Models.Musteri
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Email = txtEmail.Text,
                Telefon = txtTelefon.Text,
                Adres = txtAdres.Text
            };

            _context.Musteriler.Add(musteri);
            _context.SaveChanges();
            MusteriListele();
            Temizle();
        }

        //datagridden satır içine veri alma güncelleme
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                seciliMusteriId = Convert.ToInt32(row.Cells[0].Value); // 0 = MusteriID
                txtAd.Text = row.Cells[1].Value.ToString();
                txtSoyad.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                txtTelefon.Text = row.Cells[4].Value.ToString();
                txtAdres.Text = row.Cells[5].Value.ToString();

            }
        }

        //güncelleme butonu
        private void btnGuncelle_Click_1(object sender, EventArgs e)

        {
            var musteri = _context.Musteriler.Find(seciliMusteriId);
            if (musteri != null)
            {
                musteri.Ad = txtAd.Text;
                musteri.Soyad = txtSoyad.Text;
                musteri.Email = txtEmail.Text;
                musteri.Telefon = txtTelefon.Text;
                musteri.Adres = txtAdres.Text;

                _context.SaveChanges();
                MusteriListele();
                Temizle();
            }
        }

        //silme butonu
        private void btnSil_Click_1(object sender, EventArgs e)
        {
            var musteri = _context.Musteriler.Find(seciliMusteriId);
            if (musteri != null)
            {
                _context.Musteriler.Remove(musteri);
                _context.SaveChanges();
                MusteriListele();
                Temizle();
            }
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            Temizle();
        }

        //temizleme yapar form içersini temizler 
        private void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtEmail.Text = "";
            txtTelefon.Text = "";
            txtAdres.Text = "";
            seciliMusteriId = -1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
