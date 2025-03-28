using Microsoft.EntityFrameworkCore;

namespace Oyuncakci.Models
{
    public class OyuncakciContext:DbContext
    {
        //dışardan oluşturmaya şuan ihtiyaç yok ileride istenirse eklenebilir
        
        //public OyuncakcıContext(DbContextOptions<OyuncakcıContext> options)
        //: base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost\\MSSQLSERVER02;Initial Catalog=Oyuncakci;Integrated Security=True;Trust Server Certificate=True");
            }
            //Server=.;Database=OyuncakciDb;Trusted_Connection=True;
        }

        #region DbSet Alanları
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Oyuncak> Oyuncaklar { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetaylari { get; set; }
        public DbSet<Odeme> Odemeler { get; set; }
        public DbSet<GecmisSiparis> GecmisSiparisler { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<StokGiris> StokGirisleri { get; set; }
        #endregion 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musteri>().ToTable("Musteriler");
            modelBuilder.Entity<Calisan>().ToTable("Calisanlar");
            modelBuilder.Entity<Rol>().ToTable("Roller");
            modelBuilder.Entity<Oyuncak>().ToTable("Oyuncaklar");
            modelBuilder.Entity<Kategori>().ToTable("Kategoriler");
            modelBuilder.Entity<Siparis>().ToTable("Siparisler");
            modelBuilder.Entity<SiparisDetay>().ToTable("SiparisDetaylari");
            modelBuilder.Entity<Odeme>().ToTable("Odemeler");
            modelBuilder.Entity<GecmisSiparis>().ToTable("GecmisSiparisler");
            modelBuilder.Entity<Tedarikci>().ToTable("Tedarikciler");
            modelBuilder.Entity<StokGiris>().ToTable("StokGirisleri");
        }

    }
}
