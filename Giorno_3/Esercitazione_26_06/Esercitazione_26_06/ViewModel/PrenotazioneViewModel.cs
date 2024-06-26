namespace Esercitazione_26_06.ViewModel
{
    using Esercitazione_26_06.Models;
    using System.Collections.Generic;

    public class PrenotazioneViewModel
    {
        public Prenotazione NuovaPrenotazione { get; set; }
        public List<Prenotazione> ListaPrenotazioni { get; set; }
    }
}