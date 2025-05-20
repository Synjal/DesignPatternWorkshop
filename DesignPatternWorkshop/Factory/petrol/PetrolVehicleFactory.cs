namespace DesignPatternWorkshop.Factory.petrol;

public class PetrolVehicleFactory : VehicleFactory
{
    public override Motorcycle CreateMotorcycle() => new PetrolMotorcycle();
    public override Car CreateCar() => new PetrolCar();
}