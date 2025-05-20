using DesignPatternWorkshop.Factory;

namespace DesignPatternWorkshop;

public class Catalog
{
    private readonly VehicleFactory _factory;

    public Catalog(VehicleFactory factory)
    {
        _factory = factory;
    }

    public void ShowProducts()
    {
        var car = _factory.CreateCar();
        var scoot = _factory.CreateMotorcycle();
        
        car.GetTypeDescription();
        scoot.GetTypeDescription();
    }
}