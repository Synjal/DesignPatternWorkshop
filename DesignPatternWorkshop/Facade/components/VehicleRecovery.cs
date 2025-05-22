using DesignPatternWorkshop.Factory;

namespace DesignPatternWorkshop.Facade.components;

public static class VehicleRecovery
{
    public static bool IsEligibleForRecovery(Vehicle vehicle)
    {
        return vehicle.Price <= 3000;
    }
}