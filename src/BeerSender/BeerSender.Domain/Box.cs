namespace BeerSender.Domain;

public class Box
{
    public BoxCapacity Capacity { get; set; }

    public Box(BoxCapacity capacity)
    {
        Capacity = capacity;
    }
}