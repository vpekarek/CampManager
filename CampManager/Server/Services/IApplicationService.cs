namespace CampManager.Server.Services;

public interface IApplicationService
{
    Task AddAsync(Model.Application model);
    Task<Model.Application> GetAsync(Guid applicationId);
    Task ApproveAsync(Guid applicationId);
    Task RejectAsync(Guid applicationId);
}
