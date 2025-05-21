namespace DesignPatternWorkshop.Factory;

public abstract class Motorcycle : IVehicle
{
    public abstract double MaintenanceCost { get; }
    public abstract void GetTypeDescription();
}