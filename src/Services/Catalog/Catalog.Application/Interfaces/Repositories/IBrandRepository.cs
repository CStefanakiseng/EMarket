using Catalog.Domain.Entities;

namespace Catalog.Application.Interfaces.Repositories
{
    public interface IBrandRepository
    {
        Task<IEnumerable<ProductBrand>> GetAllProductBrandsAsync();
    }
}
