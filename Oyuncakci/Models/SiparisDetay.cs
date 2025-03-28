using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oyuncakci.Models
{
    public class SiparisDetay
    {
        [Key]
        public int SiparisDetayID { get; set; }

        public int SiparisID { get; set; }
        public int OyuncakID { get; set; }
        public int Adet { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal BirimFiyat { get; set; }

        public Siparis Siparis { get; set; }
        public Oyuncak Oyuncak { get; set; }
    }
}
