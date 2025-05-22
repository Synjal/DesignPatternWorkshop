using DesignPatternWorkshop.Prototype.documents;

namespace DesignPatternWorkshop.Builder.PDF;

public class PdfVehiclePapersConstructor : VehiclePapersConstructor
{
    private readonly PdfPapers _papers = new PdfPapers();
    
    public override void BuildPurchaseOrder()
    {
        _papers.AddDocument(new PurchaseOrder());
    }

    public override void BuildRegistrationApplication()
    {
        _papers.AddDocument(new RegistrationOrder());
    }

    public override Papers Result()
    {
        return _papers;
    }
}