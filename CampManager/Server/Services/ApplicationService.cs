using CampManager.Server.Model;
using MongoDb.DatabaseProvider;

namespace CampManager.Server.Services;

public class ApplicationService : IApplicationService
{
    private readonly MongoDbContext _dbContext;

    public ApplicationService(MongoDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task AddAsync(Application model)
    {
        await _dbContext.Applications.InsertRecordAsync(model);
    }

    public async Task ApproveAsync(Guid applicationId)
    {
        var application = await _dbContext.Applications.LoadRecordByIdAsync(applicationId);
        application.Approve();
        await _dbContext.Applications.UpsertRecordAsync(applicationId, application);
    }

    public async Task<Application> GetAsync(Guid applicationId)
    {
        return await _dbContext.Applications.LoadRecordByIdAsync(applicationId);
    }

    public async Task RejectAsync(Guid applicationId)
    {
        var application = await _dbContext.Applications.LoadRecordByIdAsync(applicationId);
        application.Reject();
        await _dbContext.Applications.UpsertRecordAsync(applicationId, application);
    }
}