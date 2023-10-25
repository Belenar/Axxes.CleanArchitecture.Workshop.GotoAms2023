using BeerSender.Application.Boxes.Create;
using BeerSender.Domain;

namespace BeerSender.Infrastructure;

public class BoxCreatedPostToAzure : IBoxCreatedNotifier
{
    public void NotifyOfBoxCreated(Box box)
    {
        Console.WriteLine("Posed to Azure");
    }
}