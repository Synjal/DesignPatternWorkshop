namespace DesignPatternWorkshop.Factory.electric;

public class ElectricCar: Car
{
    public override void GetTypeDescription()
    {
        Console.WriteLine("Voiture électrique");
    }
}