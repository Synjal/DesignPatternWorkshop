namespace DesignPatternWorkshop.Builder.HTML;

public class HtmlPapers : Papers
{
    public override void Print()
    {
        Console.WriteLine("Papiers version HTML :");
        foreach (var doc in Documents)
        {
            Console.WriteLine($"<html>{doc}</html>");
        }
    }
}