namespace DesignPatternWorkshop.Builder.HTML;

public class HtmlVehiclePapersConstructor : VehiclePapersConstructor
{
    private readonly HtmlPapers _papers = new HtmlPapers();

    public override void BuildPurchaseOrder()
    {
        _papers.AddDocument("Bon de commande (HTML)");
    }

    public override void BuildRegistrationApplication()
    {
        _papers.AddDocument("Demande d'immatriculation (HTML)");
    }

    public override Papers Result()
    {
        return _papers;
    }
}