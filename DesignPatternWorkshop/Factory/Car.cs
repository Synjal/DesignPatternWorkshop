namespace DesignPatternWorkshop.Factory;

public abstract class Car(string brand, double price) : Vehicle(brand, price)
{
    protected override string GetDescription()
    {
        return "Description de la voiture";
    }
}