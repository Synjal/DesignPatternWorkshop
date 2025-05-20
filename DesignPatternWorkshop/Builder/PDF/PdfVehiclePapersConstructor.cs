namespace DesignPatternWorkshop.Builder.PDF;

public class PdfVehiclePapersConstructor : VehiclePapersConstructor
{
    private readonly PdfPapers _papers = new PdfPapers();
    
    public override void BuildPurchaseOrder()
    {
        _papers.AddDocument("Bon de commande (PDF)");
    }

    public override void BuildRegistrationApplication()
    {
        _papers.AddDocument("Demande d'immatriculation (PDF)");
    }

    public override Papers Result()
    {
        return _papers;
    }
}