namespace DesignPatternWorkshop.Decorator;

public class VehicleView : VehicleGraphicalComponent
{
    public override void Show()
    {
        Console.WriteLine("Vue du véhicule");
    }
}