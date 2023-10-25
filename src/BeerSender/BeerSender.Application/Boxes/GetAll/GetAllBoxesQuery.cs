using BeerSender.Domain;

namespace BeerSender.Application.Boxes.GetAll;

public class GetAllBoxesQuery : IGetAllBoxes
{
    private readonly IFetchAllBoxes _fetcher;

    public GetAllBoxesQuery(IFetchAllBoxes fetcher)
    {
        _fetcher = fetcher;
    }

    public IEnumerable<Box> Query()
    {
        return _fetcher.Query();
    }
}