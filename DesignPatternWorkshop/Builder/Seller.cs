namespace DesignPatternWorkshop.Builder;

public class Seller
{
    public Papers Build(VehiclePapersConstructor constructor)
    {
        constructor.BuildPurchaseOrder();
        constructor.BuildRegistrationApplication();
        return constructor.Result();
    }
}