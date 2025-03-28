using System.ComponentModel.DataAnnotations;

namespace Oyuncakci.Models
{
    public class StokGiris
    {
        [Key]
        public int StokGirisID { get; set; }

        public int OyuncakID { get; set; }
        public int TedarikciID { get; set; }
        public int Adet { get; set; }
        public DateTime Tarih { get; set; }

        public Oyuncak Oyuncak { get; set; }
        public Tedarikci Tedarikci { get; set; }
    }
}
