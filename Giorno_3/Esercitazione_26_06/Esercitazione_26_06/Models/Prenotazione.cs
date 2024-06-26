using System.ComponentModel.DataAnnotations;

namespace Esercitazione_26_06.Models
{
    public class Prenotazione
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Inserire il nome")]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Display(Name = "Cognome")]
        public string LastName { get; set; }
        [Display(Name = "Sala")]
        public Sala Hall { get; set; }
        [Display(Name = "Biglietto:")]
        public string Ticket { get; set; }

    }
}
