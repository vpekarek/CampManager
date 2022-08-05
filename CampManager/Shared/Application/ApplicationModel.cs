using CampManager.Shared.Types;
using MongoDB.Bson.Serialization.Attributes;

namespace CampManager.Shared.Application;
public class ApplicationModel
{
    [BsonId]
    public Guid Id { get; set; }
    public Guid CampId { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public ApplicationStatusType Status { get; private set; } = ApplicationStatusType.New;
    public DateTime? Resolved { get; private set; }
    public ApplicationParticipantModel[] Participants { get; set; } = Array.Empty<ApplicationParticipantModel>();
    public PersonModel[] Representatives { get; set; } = Array.Empty<PersonModel>();

    public void Approve()
    {
        Status = ApplicationStatusType.Accepted;
        Resolved = DateTime.Now;
    }

    public void Reject()
    {
        Status = ApplicationStatusType.Rejected;
        Resolved = DateTime.Now;
    }

}
