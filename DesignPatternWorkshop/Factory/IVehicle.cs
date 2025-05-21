namespace DesignPatternWorkshop.Factory;

public interface IVehicle
{
    double MaintenanceCost { get; }
    void GetTypeDescription();
}