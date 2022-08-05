namespace CampManager.Shared.Participant;

public class ParticipantMedicalCareModel
{
    public DateOnly Date { get; set; }
    public string Reason { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public string? FileUrl { get; set; }
}
