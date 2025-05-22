using DesignPatternWorkshop.Factory;

namespace DesignPatternWorkshop.Composite;

public abstract class Company
{
    protected readonly List<Vehicle> Vehicles = [];
    protected readonly List<Company> Subsidiaries = [];

    public virtual void AddVehicle(params Vehicle[] vehicles)
    {
        foreach (var vehicle in vehicles) Vehicles.Add(vehicle);
    }
    
    public virtual void AddSubsidiary(params Company[] companies)
    {
        Console.WriteLine("Cette société ne peut pas avoir de filiales");
    }
    
    public abstract double MaintenanceCost();
}