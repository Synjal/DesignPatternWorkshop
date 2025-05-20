namespace DesignPatternWorkshop.Factory.electric;

public class ElectricMotorcycle : Motorcycle
{
    public override void GetTypeDescription()
    {
        Console.WriteLine("Scooter électrique");
    }
}