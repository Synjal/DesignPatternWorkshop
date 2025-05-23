namespace DesignPatternWorkshop.Factory;

public static class VehicleRepository
{
    private static readonly List<Vehicle> _vehicles = [];

    public static void Add(Vehicle vehicle) => _vehicles.Add(vehicle);
    public static void Remove(Vehicle vehicle) => _vehicles.Remove(vehicle);
    public static List<Vehicle> GetAll() => _vehicles;
    public static void Clear() => _vehicles.Clear();
}