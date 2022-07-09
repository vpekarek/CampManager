namespace CampManager.Server.Services;

public interface IRepresentativeService
{
    Task<Guid> GetOrCreateAsync(Shared.PersonModel representative);
    Task<Model.Representative> GetAsync(Guid representativeId);
    Task<IEnumerable<Model.Representative>> GetAllAsync();
    Task UpdateAsync(Guid id, Model.Representative model);
    Task RemoveAsync(Guid id);
}