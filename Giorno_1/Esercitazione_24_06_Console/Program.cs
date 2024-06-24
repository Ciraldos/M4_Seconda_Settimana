namespace Esercitazione_24_06_Console
{
    internal class Program { 
    
            public  string Name { get; set; }
            public  decimal Price { get; set; }

        private void Start()
        {
            var list = new List<Program>
            {
                new Program {Name = "Coca Cola 150 ML", Price = 2.50m },
                new Program {Name = "Insalata di Pollo", Price = 5.20m },
                new Program {Name = "Pizza Margherita", Price = 10m },
                new Program {Name = "Pizza 4 Formaggi", Price = 12.50m },
                new Program {Name = "Pz patatine fritte", Price = 3.50m },
                new Program {Name = "Insalata di riso", Price = 8m },
                new Program {Name = "Frutta di stagione", Price = 5m },
                new Program {Name = "Pizza Fritta", Price = 5m },
                new Program {Name = "Piadina Vegetariana", Price = 6m },
                new Program {Name = "Panino Hamburger", Price = 7.90m }
            };

            Console.WriteLine("======= MENU ======");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i}: {list[i].Name} - {list[i].Price}");
            }
            Console.WriteLine($"{list.Count + 1}: Stampa conto finale e conferma");
            int scelta = int.Parse(Console.ReadLine());
            if (scelta == list.Count + 1) {
                Console.WriteLine("\n\n Hai Scelto: Stampa conto finale e conferma\n");
                ContoFinale();
            }
            else {
                Console.WriteLine("\nNon hai selezionato un valore corretto. Uscita dal programma in corso.\n");
            }
            
        }

        private void ContoFinale()
        {
            
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();

        }
    }
}
