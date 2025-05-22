namespace DesignPatternWorkshop.Factory.petrol;

public class PetrolVehicleFactory(string brand, double price) : VehicleFactory
{
    public override Motorcycle CreateMotorcycle() => new PetrolMotorcycle(brand, price);
    public override Car CreateCar() => new PetrolCar(brand, price);
}