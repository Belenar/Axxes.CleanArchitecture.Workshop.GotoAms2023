using BeerSender.Domain;

namespace BeerSender.Application.Boxes.Create;

public interface IBoxCreatedNotifier
{
    void NotifyOfBoxCreated(Box box);
}