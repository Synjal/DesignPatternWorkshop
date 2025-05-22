using DesignPatternWorkshop.Facade.components;
using DesignPatternWorkshop.Factory;
using DesignPatternWorkshop.Prototype;

namespace DesignPatternWorkshop.Facade;

public class AutoWebService
{
    private readonly Catalog _catalog = new ();

    public List<Vehicle> SearchVehicles(double averagePrice, double gapMax) => _catalog.Search(averagePrice, gapMax);
    public bool IsEligibleForRecovery(Vehicle vehicle) => VehicleRecovery.IsEligibleForRecovery(vehicle);
    public List<IDocument> GenerateClientPapers(string infos) => DocumentHandling.GenerateClientsPapers(infos);
}