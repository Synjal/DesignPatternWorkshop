using DesignPatternWorkshop.Prototype.documents;

namespace DesignPatternWorkshop.Builder.HTML;

public class HtmlVehiclePapersConstructor : VehiclePapersConstructor
{
    private readonly HtmlPapers _papers = new HtmlPapers();

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