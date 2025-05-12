using Oyuncakci.Models;

namespace Oyuncakci.Helpers
{
    public static class DataInitializer
    {
        public static void EnsureAdminUser()
        {
            using (var context = new OyuncakciContext())
            {
                // Admin var mı kontrolü
                if (!context.Calisanlar.Any(c => c.KullaniciAdi == "admin"))
                {
                    // Rol kontrolü
                    var adminRol = context.Roller.FirstOrDefault(r => r.RolAdi == "Admin");
                    if (adminRol == null)
                    {
                        adminRol = new Rol
                        {
                            RolAdi = "Admin",
                            Aciklama = "Sistem yöneticisi"
                        };
                        context.Roller.Add(adminRol);
                        context.SaveChanges();
                    }

                    // Admin kullanıcı oluşturuluyor
                    var admin = new Calisan
                    {
                        Ad = "Admin",
                        Soyad = "Yönetici",
                        Pozisyon = "Sistem Yöneticisi",
                        Email = "admin@oyuncakci.com",
                        Telefon = "05001234567",
                        KullaniciAdi = "admin",
                        SifreHash = HashHelper.ComputeHash("admin1234"),
                        RolID = adminRol.RolID
                    };

                    context.Calisanlar.Add(admin);
                    context.SaveChanges();
                }
            }
        }
    }
}
