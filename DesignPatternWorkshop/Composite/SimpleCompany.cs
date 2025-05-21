using DesignPatternWorkshop.Factory;

namespace DesignPatternWorkshop.Composite;

public class SimpleCompany : Company
{
    public override double MaintenanceCost()
    {
        double cost = 0;
        
        foreach (var vehicle in Vehicles)
        {
            cost += vehicle.MaintenanceCost;
        }

        return cost;
    }
}