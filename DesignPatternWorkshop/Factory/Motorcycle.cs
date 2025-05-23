namespace DesignPatternWorkshop.Factory;

public abstract class Motorcycle(string brand, double price) : Vehicle(brand, price)
{
    protected override string GetDescription()
    {
        return "Description de la voiture";
    }
}