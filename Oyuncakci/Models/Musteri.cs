using System.ComponentModel.DataAnnotations;

namespace Oyuncakci.Models
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        [Required, MaxLength(50)]
        public string Soyad { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Telefon { get; set; }

        [MaxLength(200)]
        public string Adres { get; set; }

        public ICollection<Siparis> Siparisler { get; set; }
    }
}
