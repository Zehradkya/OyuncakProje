using System.ComponentModel.DataAnnotations;

namespace Oyuncakci.Models
{
    public class Calisan
    {
        [Key]
        public int CalisanID { get; set; }

        [Required, MaxLength(50)]
        public string Ad { get; set; }

        [Required, MaxLength(50)]
        public string Soyad { get; set; }

        [MaxLength(50)]
        public string Pozisyon { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Telefon { get; set; }

        public int RolID { get; set; }
        public Rol Rol { get; set; }
    }
}
