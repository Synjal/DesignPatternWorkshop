using DesignPatternWorkshop.Factory;

namespace DesignPatternWorkshop.Command;

public class OrderSettle(int storageTime, double discountRate)
{
    protected List<(Vehicle vehicle, double oldPrice)> UpdatedVehicles = [];

    public void Settle(List<Vehicle> stock)
    {
        foreach (var vehicle in stock)
        {
            if (vehicle.GetStorageTime() >= storageTime)
            {
                UpdatedVehicles.Add((vehicle, vehicle.Price));
                vehicle.UpdatePrice(discountRate, storageTime);
            }
        }
    }

    public void Cancel()
    {
        foreach (var (vehicle, oldPrice) in UpdatedVehicles)
        {
            vehicle.SetPrice(oldPrice);
        }
    }

    public void Restore()
    {
        foreach (var (vehicle, _) in UpdatedVehicles)
        {
            vehicle.UpdatePrice(discountRate, storageTime);
        }
    }
}