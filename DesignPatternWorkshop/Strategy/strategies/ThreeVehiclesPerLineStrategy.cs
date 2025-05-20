namespace DesignPatternWorkshop.Strategy.strategies;

public class ThreeVehiclesPerLineStrategy : ICatalogDrawingStrategy
{
    public void Draw()
    {
        Console.WriteLine("Affiche :");
        Console.WriteLine("> 3 véhicule par ligne");
        Console.WriteLine("> Informations réduites");
        Console.WriteLine("> 1 photos");
    }
}