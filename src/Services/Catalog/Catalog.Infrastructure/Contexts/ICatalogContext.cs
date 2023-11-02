using Catalog.Domain.Entities;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Contexts
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; set; }
        IMongoCollection<ProductBrand> ProductBrands { get; set; }
        IMongoCollection<ProductType> ProductTypes { get; set; }
    }
}
