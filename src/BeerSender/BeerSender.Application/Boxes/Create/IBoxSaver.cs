using BeerSender.Domain;

namespace BeerSender.Application.Boxes.Create;

public interface IBoxSaver
{
    void SaveBox(Box box);
}