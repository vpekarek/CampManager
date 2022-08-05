namespace CampManager.Server.Services;

public interface IParticipantService
{
    Task<Guid> GetOrCreateAsync(Shared.Application.ApplicationParticipantModel participant);
    Task<Model.Participant> GetAsync(Guid participantId);
    Task<IEnumerable<Model.Participant>> GetAllAsync();
    Task UpdateAsync(Guid id, Model.Participant model);
    Task RemoveAsync(Guid id);
}
