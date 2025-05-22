namespace DesignPatternWorkshop.Flyweight;

public class Option(string name, string description, double standardPrice = 1000)
{
    public void Show(double sellingPrice)
    {
        Console.WriteLine($"Option : {name}");
        Console.WriteLine($"Description : {description}");
        Console.WriteLine($"Prix standard : {standardPrice}€");
        Console.WriteLine($"Prix de vente : {sellingPrice}€");
    }
}