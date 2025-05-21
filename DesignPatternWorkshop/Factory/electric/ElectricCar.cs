using System.Runtime.CompilerServices;

namespace DesignPatternWorkshop.Factory.electric;

public class ElectricCar: Car
{
    public override double MaintenanceCost => 100;

    public override void GetTypeDescription()
    {
        Console.WriteLine("Voiture électrique");
    }
}