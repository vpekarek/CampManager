using CampManager.Shared.Types;
using MongoDB.Bson.Serialization.Attributes;

namespace CampManager.Shared.Participant;

public class ParticipantModel : PersonModel
{
    [BsonId]
    public Guid Id { get; set; }
    public DateOnly? DateOfBirth { get; set; }

    /// <summary>
    /// Can be personal identification number or company identification number.
    /// </summary>
    public string IdentificationNumber { get; set; } = string.Empty;

    public DateOnly? DateOfPayment { get; set; }
    public DateOnly? DateOfAdvancedPayment { get; set; }
    public decimal? AdvancedPaymentAmount { get; set; }
    public DateOnly? DateOfTransportPayment { get; set; }
    public string Note { get; set; } = string.Empty;
    public TransportationType Transportation { get; set; } = TransportationType.Collective;
    public SwimmerLevelType Swimmer { get; set; } = SwimmerLevelType.None;
    public string Accomodation { get; set; } = string.Empty;
    public ParticipantMedicalModel MedicalInfo { get; set; } = new();
    public List<ParticipantTransferModel> Transfers { get; set; } = new();
    public List<string> Files { get; set; } = new();
    public List<Guid> RepresentativeIds { get; set; } = new();
}
