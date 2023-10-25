
using BeerSender.Application.Boxes.Create;
using BeerSender.Application.Boxes.GetAll;
using Microsoft.Extensions.DependencyInjection;

namespace BeerSender.Persistence;

public class PersistenceServiceRegistration
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddTransient<IBoxSaver, BoxRepository>();
        services.AddTransient<IFetchAllBoxes, BoxRepository>();
        // Register ORM context
        // Register repositories
    }
}