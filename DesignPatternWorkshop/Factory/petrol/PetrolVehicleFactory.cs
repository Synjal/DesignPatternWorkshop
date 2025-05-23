namespace DesignPatternWorkshop.Factory.petrol;

public class PetrolVehicleFactory(string brand, double price) : VehicleFactory
{
    public override Motorcycle CreateMotorcycle()
    {
        var scooter = new PetrolMotorcycle(brand, price);
        VehicleRepository.Add(scooter);
        return scooter;
    }

    public override Car CreateCar()
    {
        var car = new PetrolCar(brand, price);
        VehicleRepository.Add(car);
        return car;
    } 
}