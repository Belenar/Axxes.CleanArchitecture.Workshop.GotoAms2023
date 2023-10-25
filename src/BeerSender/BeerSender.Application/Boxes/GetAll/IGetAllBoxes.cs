using BeerSender.Domain;

namespace BeerSender.Application.Boxes.GetAll;

public interface IGetAllBoxes
{
    public IEnumerable<Box> Query();
}