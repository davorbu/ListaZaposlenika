
using System.ComponentModel.DataAnnotations;

namespace ListaZaposlenika.Models
{
   
    public class Zaposlenik
    {
        [Key]
        public int Id { get; set; }

        public string Ime{ get; set; }

        public string Prezime { get; set; }

        public string Oib { get; set; }

        public DateTime? DatumRođenja { get; set; }
    }
}
