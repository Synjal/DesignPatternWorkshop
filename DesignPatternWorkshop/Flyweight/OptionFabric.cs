namespace DesignPatternWorkshop.Flyweight;

public class OptionFabric
{
    private readonly Dictionary<string, Option> options = new();

    public Option GetOption(string name)
    {
        if (options.TryGetValue(name, out _))
        {
            return options[name];
        }

        var newOption = new Option(name, "Description de " + name);
        options[name] = newOption;
        return newOption;
    }
}