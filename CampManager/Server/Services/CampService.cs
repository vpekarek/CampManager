using MongoDb.DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
