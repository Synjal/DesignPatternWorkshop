using System.Runtime.CompilerServices;

namespace DesignPatternWorkshop.Factory;

public abstract class Car(string brand, double price) : Vehicle(brand, price)
{
    public string GetDescription()
    {
        return "Description de la voiture";
    }
}