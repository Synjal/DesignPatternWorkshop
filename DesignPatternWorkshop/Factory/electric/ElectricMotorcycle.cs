namespace DesignPatternWorkshop.Factory.electric;

public class ElectricMotorcycle(string brand, double price): Motorcycle(brand, price)
{
    public override void GetTypeDescription()
    {
        Console.WriteLine("Scooter électrique");
    }
}