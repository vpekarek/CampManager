using CampManager.Shared.Types;
using MongoDB.Bson.Serialization.Attributes;

namespace CampManager.Shared;

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
    public MedicalModel MedicalInfo { get; set; } = new();
    public List<TransferModel> Transfers { get; set; } = new();
    public List<string> Files { get; set; } = new();

    public List<Guid> RepresentativeIds { get; set; } = new();

    public class TransferModel
    {
        public DateOnly Date { get; set; }
        public TransferDirectionType Direction { get; set; }
        public FoodType LastFood { get; set; }
        public bool IsRequestedByRepresentative { get; set; }
    }

    public class MedicalModel
    {
        public bool IsCheckedByParamedic { get; set; }
        public string Alergies { get; set; } = string.Empty;
        public bool DrugsByParamedic { get; set; }
        public string DrugsOnMorning { get; set; } = string.Empty;
        public string DrugsOnEvening { get; set; } = string.Empty;
        public string DrugsAtNight { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
    }
}
