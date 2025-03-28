using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oyuncakci.Models
{
    public class Oyuncak
    {
        [Key]
        public int OyuncakID { get; set; }

        [Required, MaxLength(100)]
        public string Ad { get; set; }

        [MaxLength(50)]
        public string Marka { get; set; }

        public int KategoriID { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Fiyat { get; set; }

        public int StokMiktari { get; set; }

        public Kategori Kategori { get; set; }
    }
}
