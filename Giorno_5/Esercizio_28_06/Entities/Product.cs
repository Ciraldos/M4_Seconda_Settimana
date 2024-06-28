namespace Esercizio_28_06.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime Published { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public IFormFile Cover { get; set; }
        public IFormFile FirstImg { get; set; }
        public IFormFile SecondImg { get; set; }
    }
}

