using Catalog.Application.Dtos;
using MediatR;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Application.Features.Products
{
    public class CreateProductCommand : IRequest<ProductViewModel>
    {
        [BsonElement("Name")]
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public BrandDto Brand { get; set; }
        public ProductTypeDto Type { get; set; }

        public decimal Price { get; set; }
    }
}
