namespace DesignPatternWorkshop.Prototype.documents;

public class RegistrationOrder : Document
{

    public override void Print()
    {
        Console.WriteLine("Impression de la demande d'immatriculation : " + Content);
    }

    public override void Show()
    {
        Console.WriteLine("Demande d'immatriculation : " + Content);
    }
}