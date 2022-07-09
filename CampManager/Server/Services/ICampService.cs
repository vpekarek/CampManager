namespace CampManager.Server.Services;

public interface ICampService
{
    Task AddAsync(Model.Camp model);
    Task RemoveAsync(Guid id);
    Task<Model.Camp> GetAsync(Guid id);
    Task<IEnumerable<Model.Camp>> GetAllAsync();
    Task UpdateAsync(Guid id, Model.Camp model);
    Task AddParticipantAsync(Guid participantId, Guid campId);
    Task RemoveParticipantAsync(Guid participantId, Guid campId);
    Task<IEnumerable<Shared.CampInfoModel>> GetOpenedCampsAsync();
}
