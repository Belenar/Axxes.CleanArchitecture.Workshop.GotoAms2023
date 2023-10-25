using BeerSender.Application.Boxes.Create;
using Microsoft.Extensions.DependencyInjection;

namespace BeerSender.Infrastructure;

public static class InfrastuctureServiceRegistration
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddTransient<IBoxCreatedNotifier, BoxCreatedPostToAzure>();
        services.AddTransient<IBoxCreatedNotifier, BoxCreatedPostToSQS>();
    }
}