using CampManager.Shared.Types;

namespace CampManager.Shared.Participant;

public class ParticipantTransferModel
{
    public DateOnly Date { get; set; }
    public TransferDirectionType Direction { get; set; }
    public FoodType LastFood { get; set; }
    public bool IsRequestedByRepresentative { get; set; }
}
