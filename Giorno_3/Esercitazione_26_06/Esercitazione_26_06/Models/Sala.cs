namespace Esercitazione_26_06.Models
{
    public class Sala
    {
        public string Nome { get; set; }
        public int TotPosti { get; set; } = 120;
        public int PostiOccupati {  get; set; }
        public int PostiOccupatiRidotti { get; set; }
    }
}
