namespace DesignPatternWorkshop.Decorator;

public class Decorator : VehicleGraphicalComponent
{
    private readonly VehicleGraphicalComponent _component;

    protected Decorator(VehicleGraphicalComponent component)
    {
        _component = component;
    }
    
    public override void Show()
    {
        _component.Show();
    }
}