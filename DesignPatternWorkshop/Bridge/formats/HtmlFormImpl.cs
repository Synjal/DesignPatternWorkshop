namespace DesignPatternWorkshop.Bridge.formats;

public class HtmlFormImpl : IFormImpl
{
    public void DrawText(string text)
    {
        Console.WriteLine($"[HTML]{text}");
    }

    public string HandleInputField()
    {
        Console.WriteLine("[HTML] Entrée utilisateur : ");
        return Console.ReadLine() ?? "";
    }
}