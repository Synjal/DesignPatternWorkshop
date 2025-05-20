namespace DesignPatternWorkshop.Strategy.strategies;

public class OneVehiclePerLineStrategy : ICatalogDrawingStrategy
{
    public void Draw()
    {
        Console.WriteLine("Affiche :");
        Console.WriteLine("> 1 véhicule par ligne");
        Console.WriteLine("> Details complet");
        Console.WriteLine("> 4 photos");
    }
}