using BeerSender.Application.Boxes.Create;
using BeerSender.Application.Boxes.GetAll;
using BeerSender.Domain;

namespace BeerSender.Persistence;

public class BoxRepository : IBoxSaver, IFetchAllBoxes
{
    public void SaveBox(Box box)
    {
        BoxList.Boxes.Add(box);
    }

    public IEnumerable<Box> Query()
    {
        return BoxList.Boxes;
    }
}

static class BoxList
{
    public static List<Box> Boxes = new List<Box>();
}