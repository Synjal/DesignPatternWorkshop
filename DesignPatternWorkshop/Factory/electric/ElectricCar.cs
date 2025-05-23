namespace DesignPatternWorkshop.Factory.electric;

public class ElectricCar(string brand, double price): Car(brand, price)
{
    public override void GetTypeDescription()
    {
        Console.WriteLine("Voiture électrique");
    }
    protected override string GetDescription()
    {
        return "Description de la voiture électrique";
    }
}