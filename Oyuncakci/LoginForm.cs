using Microsoft.EntityFrameworkCore;
using Oyuncakci.Helpers;
using Oyuncakci.Models;

namespace Oyuncakci
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            using (var context = new OyuncakciContext())
            {
                string kullaniciAdi = txtKullaniciAdi.Text.Trim();
                string sifre = txtSifre.Text;

                var calisan = context.Calisanlar
                    .Include(c => c.Rol)
                    .FirstOrDefault(c => c.KullaniciAdi == kullaniciAdi);

                if (calisan != null && HashHelper.VerifyHash(sifre, calisan.SifreHash))
                {
                    MessageBox.Show($"Giriş başarılı! Hoş geldiniz, {calisan.Ad}.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    var mainForm = new MainForm(); // MainForm açılıyor
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
