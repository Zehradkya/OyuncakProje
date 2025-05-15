using Microsoft.EntityFrameworkCore;
using Oyuncakci.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyuncakci
{
    public partial class OdemeForm : Form
    {
        private OyuncakciContext _context = new OyuncakciContext();
        public OdemeForm()
        {
            InitializeComponent();
        }
        private void OdemeForm_Load(object sender, EventArgs e)
        {
            SiparisleriYukle();

            // Ödeme türlerini yükle
            cmbOdemeTuru.Items.AddRange(new[] { "Nakit", "Kredi Kartı", "Havale", "Banka Kartı" });
            cmbOdemeTuru.SelectedIndex = 0;
        }
        private void SiparisleriYukle()
        {
            //yalnızca ödenmemiş siparişler görünür
            var odenmemisSiparisler = _context.Siparisler
                .Include(s => s.Musteri)
                .Where(s => !_context.Odemeler.Any(o => o.SiparisID == s.SiparisID))
                .ToList();

            cmbSiparis.DataSource = odenmemisSiparisler;
            cmbSiparis.DisplayMember = "SiparisBilgisi";
            cmbSiparis.ValueMember = "SiparisID";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSiparis.SelectedItem is Siparis secili)
            {
                txtTutar.Text = secili.ToplamTutar.ToString("0.00");
            }
        }

        private void btnOdemeKaydet_Click(object sender, EventArgs e)
        {
            if (cmbSiparis.SelectedItem is Siparis seciliSiparis)
            {
                var odeme = new Odeme
                {
                    SiparisID = seciliSiparis.SiparisID,
                    OdemeTuru = cmbOdemeTuru.SelectedItem.ToString(),
                    OdemeTarihi = DateTime.Now,
                    Tutar = seciliSiparis.ToplamTutar
                };

                _context.Odemeler.Add(odeme);
                _context.SaveChanges();

                MessageBox.Show("Ödeme başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SiparisleriYukle();
                Temizle();
            }
        }
        private void Temizle()
        {
            cmbSiparis.SelectedIndex = -1;

            if (cmbOdemeTuru.Items.Count > 0)
                cmbOdemeTuru.SelectedIndex = 0;

            txtTutar.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
