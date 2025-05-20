namespace DesignPatternWorkshop.Factory.petrol;

public class PetrolCar : Car
{
    public override void GetTypeDescription()
    {
        Console.WriteLine("Voiture essence");
    }
}