using MongoDB.Bson.Serialization.Attributes;

namespace CampManager.Shared;
public class CampInfoModel
{
    [BsonId]
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public AddressModel Address { get; set; } = new();
    public decimal Price { get; set; }
    public decimal PriceAdvanced { get; set; }
    public decimal PriceTransportation { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateOnly From { get; set; }
    public DateOnly To { get; set; }
}
