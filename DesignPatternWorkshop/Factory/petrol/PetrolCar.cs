namespace DesignPatternWorkshop.Factory.petrol;

public class PetrolCar(string brand, double price): Car(brand, price)
{
    public override void GetTypeDescription()
    {
        Console.WriteLine("Voiture essence");
    }
    
    protected override string GetDescription()
    {
        return "Description de la voiture à essence";
    }
}