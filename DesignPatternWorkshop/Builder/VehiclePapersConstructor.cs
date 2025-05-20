namespace DesignPatternWorkshop.Builder;

public abstract class VehiclePapersConstructor
{
    public abstract void BuildPurchaseOrder();
    public abstract void BuildRegistrationApplication();
    public abstract Papers Result();
}