namespace DesignPatternWorkshop.Factory.electric;

public class ElectricVehicleFactory(string brand, double price) : VehicleFactory
{
    public override Motorcycle CreateMotorcycle()
    {
        var scooter = new ElectricMotorcycle(brand, price);
        VehicleRepository.Add(scooter);
        return scooter;
    }

    public override Car CreateCar()
    {
        var car = new ElectricCar(brand, price);
        VehicleRepository.Add(car);
        return car;
    } 
}