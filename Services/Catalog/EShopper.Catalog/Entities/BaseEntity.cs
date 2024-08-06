using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace EShopper.Catalog.Entities
{
  public class BaseEntity
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
  }
}
