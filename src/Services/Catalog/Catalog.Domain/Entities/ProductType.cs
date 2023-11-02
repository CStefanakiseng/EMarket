using Kernel;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Domain.Entities
{
    public class ProductType : MongoEntity
    {
        [BsonElement("Name")]
        public string Name { get; set; }
    }
}
