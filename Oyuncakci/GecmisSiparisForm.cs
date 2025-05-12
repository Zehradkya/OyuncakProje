using Microsoft.EntityFrameworkCore;
using Oyuncakci.Models;
using ClosedXML.Excel; //excele aktarmak için

namespace Oyuncakci
{
    public partial class GecmisSiparisForm : Form
    {
        private OyuncakciContext _context = new OyuncakciContext();

        public GecmisSiparisForm()
        {
            InitializeComponent();
        }

        private void GecmisSiparisForm_Load(object sender, EventArgs e)
        {
            MusteriFiltreleriYukle();
            GecmisSiparisleriYukle();
            cmbMusteriFiltre.SelectedIndexChanged += CmbMusteriFiltre_SelectedIndexChanged;

        }
        private void CmbMusteriFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            GecmisSiparisleriYukle(); // Filtre değişince liste otomatik yenilenecek
        }

        private void GecmisSiparisleriYukle()
        {
            int? musteriID = cmbMusteriFiltre.SelectedValue as int?;

            var siparisler = _context.Siparisler
                .Include(s => s.Musteri)
                .Include(s => s.Odemeler)
                .Where(s => _context.Odemeler.Any(o => o.SiparisID == s.SiparisID));

            if (cmbMusteriFiltre.SelectedItem != null)
            {
                siparisler = siparisler.Where(s => s.MusteriID == musteriID);
            }

            dgvGecmisSiparisler.DataSource = siparisler
                .Select(s => new
                {
                    SiparisNo = s.SiparisID,
                    Musteri = s.Musteri.Ad + " " + s.Musteri.Soyad,
                    Tarih = s.Tarih.ToShortDateString(),
                    ToplamTutar = s.ToplamTutar,
                    OdemeTuru = s.Odemeler.FirstOrDefault().OdemeTuru,
                    OdemeTarihi = s.Odemeler.FirstOrDefault().OdemeTarihi.ToShortDateString()
                })
                .ToList();

            dgvGecmisSiparisler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void MusteriFiltreleriYukle()
        {
            var musteriListesi = _context.Musteriler.ToList();

            cmbMusteriFiltre.DataSource = musteriListesi;
            cmbMusteriFiltre.DisplayMember = "Ad"; // Gerekirse "Ad + Soyad" yaparız
            cmbMusteriFiltre.ValueMember = "MusteriID";

            cmbMusteriFiltre.SelectedIndex = -1; // Başlangıçta boş seçili
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("GecmisSiparisler");

            // Başlıklar
            worksheet.Cell(1, 1).Value = "Sipariş No";
            worksheet.Cell(1, 2).Value = "Müşteri";
            worksheet.Cell(1, 3).Value = "Tarih";
            worksheet.Cell(1, 4).Value = "Toplam Tutar";
            worksheet.Cell(1, 5).Value = "Ödeme Türü";
            worksheet.Cell(1, 6).Value = "Ödeme Tarihi";

            int row = 2;

            // Aynı filtreyi burada da uyguluyoruz
            int? musteriID = cmbMusteriFiltre.SelectedValue as int?;

            var siparisler = _context.Siparisler
                .Include(s => s.Musteri)
                .Include(s => s.Odemeler)
                .Where(s => _context.Odemeler.Any(o => o.SiparisID == s.SiparisID));

            if (cmbMusteriFiltre.SelectedItem != null)
                siparisler = siparisler.Where(s => s.MusteriID == musteriID);

            var raporListesi = siparisler
                .Select(s => new
                {
                    SiparisNo = s.SiparisID,
                    Musteri = s.Musteri.Ad + " " + s.Musteri.Soyad,
                    Tarih = s.Tarih,
                    ToplamTutar = s.ToplamTutar,
                    OdemeTuru = s.Odemeler.FirstOrDefault().OdemeTuru,
                    OdemeTarihi = s.Odemeler.FirstOrDefault().OdemeTarihi
                }).ToList();

            foreach (var s in raporListesi)
            {
                worksheet.Cell(row, 1).Value = s.SiparisNo;
                worksheet.Cell(row, 2).Value = s.Musteri;
                worksheet.Cell(row, 3).Value = s.Tarih.ToShortDateString();
                worksheet.Cell(row, 4).Value = s.ToplamTutar;
                worksheet.Cell(row, 5).Value = s.OdemeTuru;
                worksheet.Cell(row, 6).Value = s.OdemeTarihi.ToShortDateString();
                row++;
            }

            worksheet.Columns().AdjustToContents();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Dosyası|*.xlsx";
            sfd.FileName = "GecmisSiparisler.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(sfd.FileName);
                MessageBox.Show("Excel dosyası başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
