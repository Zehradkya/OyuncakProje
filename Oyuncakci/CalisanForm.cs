using Microsoft.EntityFrameworkCore;
using Oyuncakci.Models;

namespace Oyuncakci
{
    public partial class CalisanForm : Form
    {
        private OyuncakciContext _context = new OyuncakciContext();
        private int seciliCalisanId = -1;
        public CalisanForm()
        {
            InitializeComponent();
        }

        private void CalisanForm_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = _context.Roller.ToList();
            cmbRol.DisplayMember = "RolAdi";
            cmbRol.ValueMember = "RolID";
            cmbRol.SelectedIndex = -1;

            CalisanlariListele();
        }
        private void CalisanlariListele()
        {
            dgvCalisanlar.DataSource = _context.Calisanlar
                .Include(c => c.Rol)
                .Select(c => new
                {
                    c.CalisanID,
                    c.Ad,
                    c.Soyad,
                    c.Email,
                    c.Telefon,
                    c.Pozisyon,
                    Rol = c.Rol.RolAdi
                }).ToList();

            dgvCalisanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var calisan = new Calisan
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Email = txtEmail.Text,
                Telefon = txtTelefon.Text,
                Pozisyon = txtPozisyon.Text,
                RolID = (int)cmbRol.SelectedValue
            };

            _context.Calisanlar.Add(calisan);
            _context.SaveChanges();

            MessageBox.Show("Çalışan eklendi.");
            CalisanlariListele();
            Temizle();
        }

        private void dgvCalisanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvCalisanlar.Rows[e.RowIndex];
                seciliCalisanId = (int)row.Cells["CalisanID"].Value;

                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtPozisyon.Text = row.Cells["Pozisyon"].Value.ToString();
                cmbRol.Text = row.Cells["Rol"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var calisan = _context.Calisanlar.Find(seciliCalisanId);
            if (calisan != null)
            {
                calisan.Ad = txtAd.Text;
                calisan.Soyad = txtSoyad.Text;
                calisan.Email = txtEmail.Text;
                calisan.Telefon = txtTelefon.Text;
                calisan.Pozisyon = txtPozisyon.Text;
                calisan.RolID = (int)cmbRol.SelectedValue;

                _context.SaveChanges();
                MessageBox.Show("Çalışan güncellendi.");
                CalisanlariListele();
                Temizle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var calisan = _context.Calisanlar.Find(seciliCalisanId);
            if (calisan != null)
            {
                _context.Calisanlar.Remove(calisan);
                _context.SaveChanges();
                MessageBox.Show("Çalışan silindi.");
                CalisanlariListele();
                Temizle();
            }
        }
        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtEmail.Clear();
            txtTelefon.Clear();
            txtPozisyon.Clear();
            cmbRol.SelectedIndex = -1;
            seciliCalisanId = -1;
        }
    }
}
