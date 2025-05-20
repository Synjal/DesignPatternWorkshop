namespace DesignPatternWorkshop.Decorator.decorations;

public class ModelDecorator(VehicleGraphicalComponent component) : Decorator(component)
{
    private static void ShowTechnicalInfos()
    {
        Console.WriteLine("Modèle : Audi A6");
    }
    
    public override void Show()
    {
        base.Show();
        ShowTechnicalInfos();
    }
}