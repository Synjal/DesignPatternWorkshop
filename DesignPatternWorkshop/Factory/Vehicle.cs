namespace DesignPatternWorkshop.Factory;

public abstract class Vehicle(string brand, double price)
{
    public string Brand { get; set; } = brand;
    public double Price { get; set; } = price;
    public double MaintenanceCost { get; set; } = price / 2;
    
    public abstract void GetTypeDescription();
}