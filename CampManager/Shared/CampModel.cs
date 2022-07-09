using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampManager.Shared;
public class CampModel
{
    [BsonId]
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public int Year { get; set; }
    public DateOnly From { get; set; }
    public DateOnly To { get; set; }
    public AddressModel Address { get; set; } = new();
    public bool IsOpenedForApplications { get; set; }
    public decimal Price { get; set; }
    public decimal PriceAdvanced { get; set; }
    public decimal PriceTransportation { get; set; }
    public List<Guid> ParticipantIds { get; set; } = new();

    public string Description { get; set; } = string.Empty;
    public List<CampNotification> Notifications { get; set; } = new();

    public class CampNotification
    {
        public bool IsEmail { get; set; } = true;
        public string? Subject { get; set; }
        public string Body { get; set; } = string.Empty;
        public Types.NotificationType Type { get; set; }
        public string? Recipient { get; set; }
    }
}
