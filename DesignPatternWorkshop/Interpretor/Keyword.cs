using DesignPatternWorkshop.Factory;

namespace DesignPatternWorkshop.Interpretor;

public class Keyword(string keyword) : IExpression
{
    private readonly string _keyword = keyword.ToLower();
    
    public List<Vehicle> Evaluate(List<Vehicle> vehicles)
    {
        return vehicles.Where(vehicle
            => vehicle.GiveDescription().ToLower().Contains(_keyword)
               || (_keyword == "récent" && vehicle.GetStorageTime() <= 30)
        ).ToList();
    }
}