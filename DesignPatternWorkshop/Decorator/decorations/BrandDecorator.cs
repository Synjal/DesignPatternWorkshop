namespace DesignPatternWorkshop.Decorator.decorations;

public class BrandDecorator(VehicleGraphicalComponent component) : Decorator(component)
{
    private static void ShowLogo()
    {
        Console.WriteLine("Marque : Logo.png");
    }

    public override void Show()
    {
        base.Show();
        ShowLogo();
    }
}