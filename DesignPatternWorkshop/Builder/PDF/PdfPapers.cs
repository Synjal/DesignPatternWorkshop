namespace DesignPatternWorkshop.Builder.PDF;

public class PdfPapers : Papers
{
    public override void Print()
    {
        Console.WriteLine("Papiers version PDF :");
        foreach (var doc in Documents)
        {
            Console.WriteLine($"{doc}.pdf");
        }
    }
}