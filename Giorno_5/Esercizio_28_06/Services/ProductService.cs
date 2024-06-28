using Esercizio_28_06.Entities;

namespace Esercizio_28_06.Services
{
    public class ProductService : IProductService
    {   
        private static readonly List<Product> products = new List<Product>();
        private static int lastId = 0;
        public void Create(Product product)
        {
            product.Id = ++lastId;
            product.Published = DateTime.Now;
            products.Add(product);
        }

        public void Delete(int productId)
        {
           var product = products.SingleOrDefault(p  => p.Id == productId);
           products.Remove(product); 
        }

        public IEnumerable<Product> GetAll() => products;
        public Product GetbyId(int productId) => products.Single(p => p.Id == productId); 
        
    }
}
