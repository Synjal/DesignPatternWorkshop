namespace DesignPatternWorkshop.Factory.petrol;

public class PetrolMotorcycle : Motorcycle
{
    public override double MaintenanceCost => 90;
    public override void GetTypeDescription()
    {
        Console.WriteLine("Scooter à essence");
    }
}