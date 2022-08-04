using CampManager.Server.Model;
using CampManager.Server.Services;

namespace CampManager.Tests;

public class ApplicationTest
{
    private IApplicationService _applicationService;

    [SetUp]
    public void Setup()
    {
        _applicationService = new ApplicationService(new MongoDb.DatabaseProvider.MongoDbContext("CampManager"));
    }

    [Test]
    public async Task NewApplication()
    {
        Application application = NewApplicationModel();

        Assert.True(application.Status == Shared.Types.ApplicationStatusType.New);
        Assert.Null(application.Resolved);
        Assert.That(application.Id, Is.EqualTo(Guid.Empty));

        await _applicationService.AddAsync(application);

        Assert.That(application.Id, Is.Not.EqualTo(Guid.Empty));
    }

    [Test]
    public async Task ApproveApplication()
    {
        Application application = NewApplicationModel();
        await _applicationService.AddAsync(application);
        await _applicationService.ApproveAsync(application.Id);
        application = await _applicationService.GetAsync(application.Id);

        Assert.That(application.Status, Is.EqualTo(Shared.Types.ApplicationStatusType.Accepted));
    }

    [Test]
    public async Task RejectApplication()
    {
        Application application = NewApplicationModel();
        await _applicationService.AddAsync(application);
        await _applicationService.RejectAsync(application.Id);
        application = await _applicationService.GetAsync(application.Id);

        Assert.That(application.Status, Is.EqualTo(Shared.Types.ApplicationStatusType.Rejected));
    }

    private static Application NewApplicationModel()
    {
        var address = new Shared.AddressModel
        {
            Line1 = "Vítězné náměstí 13",
            PostalCode = "11000",
            City = "Praha 1"
        };
        var participant = new Shared.ApplicationModel.ParticipantModel
        {
            DateOfBirth = new DateOnly(2014, 12, 31),
            FirstName = "Jan",
            LastName = "Novak",
            Swimmer = Shared.Types.SwimmerLevelType.WithSupport,
            Transportation = Shared.Types.TransportationType.Collective,
            Address = address
        };
        var representative = new Shared.PersonModel
        {
            Address = address,
            FirstName = "Pavel",
            LastName = "Novak",
            Email = "pavel.novak@example.org",
            Phone = "+420123123123"
        };

        var application = new Server.Model.Application
        {
            Participants = new[] { participant },
            Representatives = new[] { representative },
        };
        return application;
    }
}