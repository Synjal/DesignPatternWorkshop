namespace DesignPatternWorkshop.Factory.petrol;

public class PetrolCar : Car
{
    public override double MaintenanceCost => 180;
    public override void GetTypeDescription()
    {
        Console.WriteLine("Voiture essence");
    }
}