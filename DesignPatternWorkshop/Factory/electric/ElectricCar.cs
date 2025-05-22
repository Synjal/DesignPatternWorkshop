namespace DesignPatternWorkshop.Factory.electric;

public class ElectricCar(string brand, double price): Car(brand, price)
{
    public override void GetTypeDescription()
    {
        Console.WriteLine("Voiture électrique");
    }
}