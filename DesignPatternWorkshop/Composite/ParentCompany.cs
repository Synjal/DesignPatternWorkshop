using DesignPatternWorkshop.Factory;

namespace DesignPatternWorkshop.Composite;

public class ParentCompany : Company
{
    public override void AddSubsidiary(params Company[] companies)
    {
        foreach (var company in companies)
        {
            Subsidiaries.Add(company);
        }
    }
    
    public override double MaintenanceCost()
    {
        double cost = 0;
        
        foreach (var subsidiary in Subsidiaries)
        {
            cost += subsidiary.MaintenanceCost();
        }
        foreach (var vehicle in Vehicles)
        {
            cost += vehicle.MaintenanceCost;
        }

        return cost;
    }
}