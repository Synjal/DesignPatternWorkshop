namespace DesignPatternWorkshop.Flyweight;

public class VehicleOrder
{
    private readonly List<(Option option, double sellingPrice)> _options = [];

    public void AddOption(Option option, double sellingPrice)
    {
        _options.Add((option, sellingPrice));
    }

    public void ShowOptions()
    {
        foreach (var (option, sellingPrice) in _options)
        {
            option.Show(sellingPrice);
            Console.WriteLine("---");
        }
    }
}