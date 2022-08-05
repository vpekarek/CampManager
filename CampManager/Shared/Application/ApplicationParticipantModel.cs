using CampManager.Shared.Types;

namespace CampManager.Shared.Application;

public class ApplicationParticipantModel : PersonModel
{
    public DateOnly? DateOfBirth { get; set; }

    /// <summary>
    /// Can be personal identification number or company identification number.
    /// </summary>
    public string IdentificationNumber { get; set; } = string.Empty;

    public TransportationType Transportation { get; set; } = TransportationType.Collective;

    public SwimmerLevelType Swimmer { get; set; } = SwimmerLevelType.None;
}
