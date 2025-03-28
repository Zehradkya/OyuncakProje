using System.ComponentModel.DataAnnotations;

namespace Oyuncakci.Models
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }

        [Required, MaxLength(50)]
        public string KategoriAdi { get; set; }

        [MaxLength(200)]
        public string Aciklama { get; set; }

        public ICollection<Oyuncak> Oyuncaklar { get; set; }
    }
}
