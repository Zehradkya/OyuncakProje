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
    public partial class KategoriEkleForm : Form
    {
        private OyuncakciContext _context = new OyuncakciContext();
        public KategoriEkleForm()
        {
            InitializeComponent();
        }

        private void KategoriEkleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yeniKategori = new Kategori
            {
                KategoriAdi = txtKategoriAdi.Text,
                Aciklama = txtAciklama.Text
            };

            _context.Kategoriler.Add(yeniKategori);
            _context.SaveChanges();

            MessageBox.Show("Kategori başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Formu kapat
        }
    }
}
