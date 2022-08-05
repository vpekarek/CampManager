namespace CampManager.Shared.Participant;

public class ParticipantMedicalModel
{
    public bool IsCheckedByParamedic { get; set; }
    public string Alergies { get; set; } = string.Empty;
    public bool DrugsByParamedic { get; set; }
    public string DrugsOnMorning { get; set; } = string.Empty;
    public string DrugsOnEvening { get; set; } = string.Empty;
    public string DrugsAtNight { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public DateOnly[] Ticks { get; set; } = Array.Empty<DateOnly>();
    public ParticipantMedicalCareModel[] MedicalCares { get; set; } = Array.Empty<ParticipantMedicalCareModel>();
}
