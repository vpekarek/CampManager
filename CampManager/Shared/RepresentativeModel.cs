using MongoDB.Bson.Serialization.Attributes;

namespace CampManager.Shared;

public class RepresentativeModel : PersonModel
{
    [BsonId]
    public Guid Id { get; set; }
}
