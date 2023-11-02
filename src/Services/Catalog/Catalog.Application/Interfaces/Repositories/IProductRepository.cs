using Catalog.Domain.Entities;

namespace Catalog.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(string id);
        Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
        Task<IEnumerable<Product>> GetProductsByBrandAsync(string name);
        Task<IEnumerable<Product>> GetAllProductsAsync();

        Task<Product> CreateProductAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(string id);
    }
}
