namespace DesignPatternWorkshop.Factory.electric;

public class ElectricVehicleFactory(string brand, double price) : VehicleFactory
{
    public override Motorcycle CreateMotorcycle() => new ElectricMotorcycle(brand, price);
    public override Car CreateCar() => new ElectricCar(brand, price);
}