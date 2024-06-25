namespace Esercitazione_24_06_Console
{   

    internal class Program { 
    
            public  string Name { get; set; }
            public  decimal Price { get; set; }

            public List<Program> List { get;} = new List<Program>
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

        private void Start()
        {
           

            Console.WriteLine("======= MENU ======");
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine($"{i}: {List[i].Name} - {List[i].Price}");
            }
            Scegli();
            Console.WriteLine($"{List.Count + 1}: Stampa conto finale e conferma");

            int scelta = int.Parse(Console.ReadLine());
            if (scelta == List.Count + 1) {
                Console.WriteLine("\n\n Hai Scelto: Stampa conto finale e conferma\n");
                ContoFinale();
            }
            else {
                Console.WriteLine("\nNon hai selezionato un valore corretto. Uscita dal programma in corso.\n");
            }
            
        }


        private void Scegli()
        {
            Console.WriteLine("\nScegli gli elementi da aggiungere al carrello:\n");
            var carrello = new List<Program> { };
            int scelta = int.Parse(Console.ReadLine());
            if (scelta > 0 && scelta <= List.Count)
            { 
                carrello.Add(List[scelta]);
                Console.WriteLine($"Hai inserito:{List[scelta].Name}");
                Scegli();
            }

            for (int i = 0; i < carrello.Count; i++)
            {
                Console.WriteLine($"Elemento in posizione {i} nel carrello: {carrello[i].Name}\n");
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
