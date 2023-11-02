using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Kernel
{
    public class MongoEntity : BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
