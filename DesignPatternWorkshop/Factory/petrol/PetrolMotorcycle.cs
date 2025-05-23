namespace DesignPatternWorkshop.Factory.petrol;

public class PetrolMotorcycle(string brand, double price): Motorcycle(brand, price)
{
    public override void GetTypeDescription()
    {
        Console.WriteLine("Scooter à essence");
    }
    
    protected override string GetDescription()
    {
        return "Description du scooter à essence";
    }
}