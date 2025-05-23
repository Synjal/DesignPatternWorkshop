namespace DesignPatternWorkshop.Factory;

public abstract class VehicleFactory
{
    
    public abstract Motorcycle CreateMotorcycle();
    public abstract Car CreateCar();
}