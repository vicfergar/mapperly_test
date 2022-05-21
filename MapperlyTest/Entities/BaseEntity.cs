using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MapperlyTest.Entities
{
    internal record BaseEntity
    {
        [BsonId]
        public virtual ObjectId Id { get; private set; } = ObjectId.GenerateNewId();

        public DateTime? DeletedAt { get; set; }
    }
}
