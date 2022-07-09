using MongoDb.DatabaseProvider;

namespace CampManager.Server.Services;
public class CampService
{
    private readonly MongoDbContext _mongoDbContext;

    public CampService(MongoDbContext mongoDbContext)
    {
        _mongoDbContext = mongoDbContext;
    }

    public Task AddCamp(Model.Camp model)
    {
        return _mongoDbContext.InsertRecordAsync("Camps", model);
    }
}
