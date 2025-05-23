namespace DesignPatternWorkshop.Factory.electric;

public class ElectricMotorcycle(string brand, double price): Motorcycle(brand, price)
{
    public override void GetTypeDescription()
    {
        Console.WriteLine("Scooter électrique");
    }
    
    protected override string GetDescription()
    {
        return "Description du scooter électrique";
    }
}