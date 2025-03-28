namespace Oyuncakci.Models
{
    using System.ComponentModel.DataAnnotations;

    public class GecmisSiparis
    {
        [Key]
        public int GecmisSiparisID { get; set; }

        public int SiparisID { get; set; }

        public DateTime Tarih { get; set; }

        [MaxLength(200)]
        public string Detay { get; set; }

        public Siparis Siparis { get; set; }
    }

}
