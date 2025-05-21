namespace DesignPatternWorkshop.Bridge.formats;

public class AppleFormImpl : IFormImpl
{
    public void DrawText(string text)
    {
        Console.WriteLine("[Apple]" + text);
    }

    public string HandleInputField()
    {
        Console.WriteLine("[Apple] Entrée utilisateur : ");
        return Console.ReadLine() ?? "";
    }
}