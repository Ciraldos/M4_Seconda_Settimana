namespace Esercitazione_25_06
{
    public class InformazioniPersonali
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }

    public class StudiEffettivi
    {
        public string Qualifica { get; set; }
        public string Istituto { get; set; }
        public string Tipo { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }
    }

    public class Impieghi
    {
        public Esperienza Esperienza { get; set; } 
    }

    public class Esperienza { 
        public string Azienda { get; set; }
        public string JobTitle { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }
        public string Descrizione { get; set; }
        public string Compiti { get; set; }
    }

    public class CV
    {
        public InformazioniPersonali Info { get; set; }
        public StudiEffettivi Studi { get; set; }
        public Impieghi Impieghi { get; set; }
    }

    internal class Program
    {
        private static void StampaCv(CV cv)
        {
            Console.WriteLine("\t++++++++ SCHEDA CV +++++++");
            Console.WriteLine("\n ====== INFORMAZIONI PERSONALI ======");
            Console.WriteLine($"\n Nome: {cv.Info.Nome}");
            Console.WriteLine($"\n Cognome: {cv.Info.Cognome}");
            Console.WriteLine($"\n Email: {cv.Info.Email}");
            Console.WriteLine($"\n Telefono: {cv.Info.Telefono}");

            Console.WriteLine("\n ====== STUDI EFFETTIVI ======");
            Console.WriteLine($"\n Qualifica: {cv.Studi.Qualifica}");
            Console.WriteLine($"\n Istituto: {cv.Studi.Istituto}");
            Console.WriteLine($"\n Tipo: {cv.Studi.Tipo}");
            Console.WriteLine($"\n Dal: {cv.Studi.Dal}");
            Console.WriteLine($"\n Al: {cv.Studi.Al}");

            Console.WriteLine("\n ====== IMPIEGHI ======");
            Console.WriteLine($"\n Azienda: {cv.Impieghi.Esperienza.Azienda}");
            Console.WriteLine($"\n Job Title: {cv.Impieghi.Esperienza.JobTitle}");
            Console.WriteLine($"\n Dal: {cv.Impieghi.Esperienza.Dal}");
            Console.WriteLine($"\n Al: {cv.Impieghi.Esperienza.Al}");
            Console.WriteLine($"\n Descrizione: {cv.Impieghi.Esperienza.Descrizione}");
            Console.WriteLine($"\n Compiti: {cv.Impieghi.Esperienza.Compiti}");
        }


        static void Main(string[] args)
        {

            CV cv = new CV
            {
                Info = new InformazioniPersonali
                {
                    Nome = "Ilario",
                    Cognome = "Alicante",
                    Email = "ilarioalicante@gmail.com",
                    Telefono = "+39328123456"
                },
                Studi = new StudiEffettivi
                {
                    Qualifica = "DJ",
                    Istituto = "Mat Academy",
                    Tipo = "Diploma",
                    Dal = "10/09/2005",
                    Al = "15/03/2007"
                },
                Impieghi = new Impieghi
                {
                    Esperienza = new Esperienza
                    {
                        Azienda = "Drumcode",
                        JobTitle = "Dj & Producer",
                        Dal = "20/09/2006",
                        Al = "- Attuale",
                        Descrizione = "Dj & Producer a titolo professionale",
                        Compiti = "Dj & Producer a titolo professionale, Analyst Drumcode Records & Radio"
                    }
                }
            };

            StampaCv(cv);

        }
    }
}
