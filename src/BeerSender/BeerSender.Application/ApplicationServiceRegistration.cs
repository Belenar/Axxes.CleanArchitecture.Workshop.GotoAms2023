using BeerSender.Application.Boxes.Create;
using BeerSender.Application.Boxes.GetAll;
using Microsoft.Extensions.DependencyInjection;

namespace BeerSender.Application;

public static class ApplicationServiceRegistration
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddTransient<
            IHandleCommand<CreateBox, CreateBoxResult>, 
            CreateBoxHandler>();
        services.AddTransient<IGetAllBoxes, GetAllBoxesQuery>();
    }
}