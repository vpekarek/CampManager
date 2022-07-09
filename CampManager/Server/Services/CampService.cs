using CampManager.Server.Model;
using CampManager.Shared;
using MongoDb.DatabaseProvider;

namespace CampManager.Server.Services;
public class CampService : ICampService
{
    private readonly MongoDbContext _mongoDbContext;

    public CampService(MongoDbContext mongoDbContext)
    {
        _mongoDbContext = mongoDbContext;
    }

    public Task AddAsync(Camp model)
    {
        throw new NotImplementedException();
    }

    public Task AddParticipantAsync(Guid participantId, Guid campId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Camp>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Camp> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CampInfoModel>> GetOpenedCampsAsync()
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task RemoveParticipantAsync(Guid participantId, Guid campId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid id, Camp model)
    {
        throw new NotImplementedException();
    }
}
