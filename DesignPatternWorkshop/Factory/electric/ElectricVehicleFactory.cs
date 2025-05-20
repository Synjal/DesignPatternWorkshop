namespace DesignPatternWorkshop.Factory.electric;

public class ElectricVehicleFactory : VehicleFactory
{
    public override Motorcycle CreateMotorcycle() => new ElectricMotorcycle();
    public override Car CreateCar() => new ElectricCar();
}