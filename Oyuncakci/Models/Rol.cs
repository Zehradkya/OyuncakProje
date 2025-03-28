using System.ComponentModel.DataAnnotations;

namespace Oyuncakci.Models
{
    public class Rol
    {
        [Key]
        public int RolID { get; set; }

        [Required, MaxLength(30)]
        public string RolAdi { get; set; }

        [MaxLength(200)]
        public string Aciklama { get; set; }

        public ICollection<Calisan> Calisanlar { get; set; }
    }
}
