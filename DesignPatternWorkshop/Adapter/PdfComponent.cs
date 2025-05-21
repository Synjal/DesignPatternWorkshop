namespace DesignPatternWorkshop.Adapter;

public class PdfComponent
{
    private string _content = string.Empty;
    
    public void PdfContentFix(string content)
    {
        _content = content;
        Console.WriteLine($"[PDF] Contenu fixé : {_content}");
    }

    public void PdfPrepareShowing()
    {
        Console.WriteLine("[PDF] Préparation de l'affichage...");
    }

    public void PdfRefresh()
    {
        Console.WriteLine("[PDF] Rafraîchissement de l'affichage...");
    }

    public void FinishShowing()
    {
        Console.WriteLine("[PDF] Affichage terminé.");
    }

    public void PdfSendToPrinter()
    {
        Console.WriteLine($"[PDF] Impression : {_content}");
    }
}