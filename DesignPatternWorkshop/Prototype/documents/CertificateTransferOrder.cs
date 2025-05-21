namespace DesignPatternWorkshop.Prototype.documents;

public class CertificateTransferOrder: Document
{

    public override void Print()
    {
        Console.WriteLine("Impression de la demande de cession de certificat : " + Content);
    }

    public override void Show()
    {
        Console.WriteLine("Demande de cession de certificat : " + Content);
    }
    
}