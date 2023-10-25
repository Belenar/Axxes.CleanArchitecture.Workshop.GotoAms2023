using BeerSender.Domain;

namespace BeerSender.Application.Boxes.GetAll;

public interface IFetchAllBoxes
{
    public IEnumerable<Box> Query();
}