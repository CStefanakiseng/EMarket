using Catalog.Domain.Entities;

namespace Catalog.Application.Interfaces.Repositories
{
    public interface ITypeRepository
    {
        Task<IEnumerable<ProductType>> GetAllProductTypesAsync();
    }
}
