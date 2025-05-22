using DesignPatternWorkshop.Factory;
using DesignPatternWorkshop.Factory.electric;
using DesignPatternWorkshop.Factory.petrol;

namespace DesignPatternWorkshop.Facade.components;

public class Catalog
{
    private readonly List<Vehicle> _availableVehicles =
    [
        new ElectricCar("Peugeot 208", 16000),
        new PetrolCar("Renault Clio", 15000),
        new ElectricMotorcycle("Tesla Model 3", 38000),
        new PetrolMotorcycle("Dacia Sandero", 12000)
    ];
    
    public void ShowProducts(VehicleFactory factory)
    {
        var car = factory.CreateCar();
        var scoot = factory.CreateMotorcycle();
        
        car.GetTypeDescription();
        scoot.GetTypeDescription();
    }

    public List<Vehicle> Search(double averagePrice, double gapMax)
    {
        return _availableVehicles
            .Where(v => Math.Abs(v.Price - averagePrice) <= gapMax)
            .ToList();
    }
}