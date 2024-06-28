using Esercizio_28_06.Entities;

namespace Esercizio_28_06.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();

        void Create(Product product);
        void Delete(int productId);
        Product GetbyId(int productId);
    }
}
