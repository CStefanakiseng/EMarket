using Catalog.Domain.Entities;
using Catalog.Infrastructure.Seeds;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.Infrastructure.Contexts
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:ProductsCollection"));
            ProductContextSeed.SeedData(Products);
            ProductBrands = database.GetCollection<ProductBrand>(configuration.GetValue<string>("DatabaseSettings:BrandsCollection"));
            BrandContextSeed.SeedData(ProductBrands);
            ProductTypes = database.GetCollection<ProductType>(configuration.GetValue<string>("DatabaseSettings:TypesCollection"));
            TypeContextSeed.SeedData(ProductTypes);

        }


        public IMongoCollection<Product> Products { get; set; }
        public IMongoCollection<ProductBrand> ProductBrands { get; set; }
        public IMongoCollection<ProductType> ProductTypes { get; set; }
    }
}
