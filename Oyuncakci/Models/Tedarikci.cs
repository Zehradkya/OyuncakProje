namespace Oyuncakci.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Tedarikci
    {
        [Key]
        public int TedarikciID { get; set; }

        [Required, MaxLength(100)]
        public string FirmaAdi { get; set; }

        [MaxLength(20)]
        public string Telefon { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Adres { get; set; }

        public ICollection<StokGiris> StokGirisleri { get; set; }
    }

}
