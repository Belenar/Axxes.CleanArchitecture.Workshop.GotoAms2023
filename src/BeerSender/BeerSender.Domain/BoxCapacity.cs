namespace BeerSender.Domain;

public class BoxCapacity
{
    public int NumberOfSpots { get; init; }

    public BoxCapacity(int numberOfSpots)
    {
        switch (numberOfSpots)
        {
            case 6:
            case 12:
            case 24:
                NumberOfSpots = numberOfSpots;
                break;
            default:
                throw new ArgumentException("Invalid capacity", nameof(numberOfSpots));
        }
    }

    public class Brewery
    {
        public string? Name { get; set; }
        public string? Town { get; set; }
    }

    public class BeerBottle
    {
        public Brewery? Brewery { get; set; }
        public string? Name { get; set; }
        public decimal AlcoholPercentage { get; set; }
    }
}