using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oyuncakci.Models
{
    public class Siparis
    {
        [Key]
        public int SiparisID { get; set; }

        public int MusteriID { get; set; }

        public DateTime Tarih { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ToplamTutar { get; set; }

        public Musteri Musteri { get; set; }
        public ICollection<SiparisDetay> SiparisDetaylari { get; set; }
        public ICollection<Odeme> Odemeler { get; set; }
        public ICollection<GecmisSiparis> GecmisSiparisler { get; set; }
    }
}
