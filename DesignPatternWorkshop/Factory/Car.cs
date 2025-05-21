using System.Runtime.CompilerServices;

namespace DesignPatternWorkshop.Factory;

public abstract class Car : IVehicle
{
    public abstract double MaintenanceCost { get; }

    public abstract void GetTypeDescription();
}