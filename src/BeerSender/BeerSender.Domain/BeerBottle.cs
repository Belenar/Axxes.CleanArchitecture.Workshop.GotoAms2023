namespace BeerSender.Domain;

public class BeerBottle
{
    public Brewery? Brewery { get; set; }
    public string? Name { get; set; }
    public decimal AlcoholPercentage { get; set; }
}