using CampManager.Server.Services;
using MongoDb.DatabaseProvider;

namespace CampManager.Tests;

public class ApplicationTest
{
    private IApplicationService _applicationService = new ApplicationService();

    [Fact]
    public async void NewApplication()
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

        Assert.True(application.Status == Shared.Types.ApplicationStatusType.New);
        Assert.Null(application.Resolved);
        Assert.Equal(Guid.Empty, application.Id);

        await _applicationService.AddAsync(application);
    }
}