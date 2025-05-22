using DesignPatternWorkshop.Chain_Of_Responsibility;

namespace DesignPatternWorkshop.Factory;

public abstract class Vehicle(string brand, double price) : BaseObject
{
    public string Brand { get; set; } = brand;
    public double Price { get; set; } = price;
    public double MaintenanceCost { get; set; } = price / 2;

    public abstract void GetTypeDescription();
    protected override string? GetDescription()
    {
        return "Description du véhicule";
    }
}