namespace DesignPatternWorkshop.Prototype.documents;

public class PurchaseOrder : Document
{

    public override void Print()
    {
        Console.WriteLine("Impression du bon de commande : " + Content);
    }

    public override void Show()
    {
        Console.WriteLine("Bon de commande : " + Content);
    }
}