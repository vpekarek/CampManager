using CampManager.Server.Model;

namespace CampManager.Server.Services;

public class ApplicationService : IApplicationService
{
    public Task AddAsync(Application model)
    {
        throw new NotImplementedException();
    }

    public Task ApproveAsync(Guid applicationId)
    {
        throw new NotImplementedException();
    }

    public Task RejectAsync(Guid applicationId)
    {
        throw new NotImplementedException();
    }
}