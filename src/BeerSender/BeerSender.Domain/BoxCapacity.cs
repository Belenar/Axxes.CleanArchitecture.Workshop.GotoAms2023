namespace BeerSender.Domain;

public class BoxCapacity
{
    public NumberOfSpots NumberOfSpots { get; init; }

    public BoxCapacity(NumberOfSpots numberOfSpots)
    {
        NumberOfSpots = numberOfSpots;
    }

    public static BoxCapacity FromNumberOfSpots(int numberOfSpots)
    {
        if (!Enum.IsDefined(typeof(NumberOfSpots), numberOfSpots))
            throw new ArgumentException("Invalid capacity", nameof(numberOfSpots));

        var spots = (NumberOfSpots)numberOfSpots;

        return new BoxCapacity(spots);
    }
}

public enum NumberOfSpots
{
    Six = 6,
    Twelve = 12,
    TwentyFour = 24
}