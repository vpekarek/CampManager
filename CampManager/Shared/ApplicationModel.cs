using CampManager.Shared.Types;
using MongoDB.Bson.Serialization.Attributes;

namespace CampManager.Shared;
public class ApplicationModel
{
    [BsonId]
    public Guid Id { get; set; }
    public Guid CampId { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public ApplicationStatusType Status { get; set; } = ApplicationStatusType.New;
    public DateTime? Resolved { get; set; }
    public ParticipantModel[] Participants { get; set; } = Array.Empty<ParticipantModel>();
    public PersonModel[] Representatives { get; set; } = Array.Empty<PersonModel>();

    public class ParticipantModel : PersonModel
    {
        public DateOnly? DateOfBirth { get; set; }

        /// <summary>
        /// Can be personal identification number or company identification number.
        /// </summary>
        public string IdentificationNumber { get; set; } = string.Empty;
        public TransportationType Transportation { get; set; } = TransportationType.Collective;
        public SwimmerLevelType Swimmer { get; set; } = SwimmerLevelType.None;
    }
}
