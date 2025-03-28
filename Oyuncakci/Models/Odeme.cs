using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oyuncakci.Models
{
    public class Odeme
    {
        [Key]
        public int OdemeID { get; set; }

        public int SiparisID { get; set; }

        [MaxLength(20)]
        public string OdemeTuru { get; set; }

        public DateTime OdemeTarihi { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Tutar { get; set; }

        public Siparis Siparis { get; set; }
    }
}
