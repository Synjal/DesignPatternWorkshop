using DesignPatternWorkshop.Proxy;

namespace DesignPatternWorkshop.Decorator;

public class VehicleView(Animation animation) : VehicleGraphicalComponent
{
    public override void Show()
    {
        Console.WriteLine("Vue du véhicule");
    }

    public void ClickOnAnimation()
    {
        animation.Clic();
    }
}