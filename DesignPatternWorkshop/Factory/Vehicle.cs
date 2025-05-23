using DesignPatternWorkshop.Chain_Of_Responsibility;

namespace DesignPatternWorkshop.Factory;

public abstract class Vehicle(string brand, double price) : BaseObject
{
    public string Brand { get; set; } = brand;
    public double Price { get; private set; } = price;
    public double MaintenanceCost { get; set; } = price / 2;
    
    protected DateTime StockEntryDate = DateTime.Now;

    public abstract void GetTypeDescription();
    protected override string? GetDescription()
    {
        return "Description du véhicule";
    }

    public int GetStorageTime()
    {
        return (DateTime.Now - StockEntryDate).Days;
    }

    public void UpdatePrice(double coefficient, int storageTime)
    {
        Console.WriteLine($"Le véhicule {this} est présent depuis plus de {storageTime} jours.");
        Price *= coefficient / 100;
        Console.WriteLine($"Application d'une promotion de {coefficient}%...");
        Console.WriteLine($"Nouveau prix de vente : {Price}€");
        Console.WriteLine("---");
    }

    public void SetPrice(double newPrice)
    {
        Console.WriteLine($"Annulation de la promotion du véhicule {this}");
        Price = newPrice;
        Console.WriteLine($"Nouveau prix de vente : {Price}€");
        Console.WriteLine("---");
    }

    public override string ToString()
    {
        return $"[{Brand}]{StockEntryDate.ToShortDateString()} - {GetDescription()} - {Price}€";
    }
}