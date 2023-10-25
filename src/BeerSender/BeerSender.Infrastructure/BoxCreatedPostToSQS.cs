using BeerSender.Application;
using BeerSender.Application.Boxes.Create;
using BeerSender.Application.Boxes.GetAll;
using BeerSender.Domain;

namespace BeerSender.Infrastructure;

public class BoxCreatedPostToSQS : IBoxCreatedNotifier
{
    public void NotifyOfBoxCreated(Box box)
    {
        Console.WriteLine("Posed to SQS");
    }
}