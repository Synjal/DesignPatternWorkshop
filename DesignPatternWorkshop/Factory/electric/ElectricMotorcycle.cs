namespace DesignPatternWorkshop.Factory.electric;

public class ElectricMotorcycle : Motorcycle
{
    public override double MaintenanceCost => 70;
    public override void GetTypeDescription()
    {
        Console.WriteLine("Scooter électrique");
    }
}