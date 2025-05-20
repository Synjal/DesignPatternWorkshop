using DesignPatternWorkshop.Builder;
using DesignPatternWorkshop.Builder.HTML;
using DesignPatternWorkshop.Builder.PDF;

namespace DesignPatternWorkshop;

public class VehicleClient
{
    public VehicleClient(FileFormat format)
    {
        VehiclePapersConstructor constructor = format switch
        {
            FileFormat.Html => new HtmlVehiclePapersConstructor(),
            FileFormat.Pdf => new PdfVehiclePapersConstructor(),
            _ => throw new ArgumentException("Format de fichier non reconnu")
        };

        var seller = new Seller();
        var papers = seller.Build(constructor);
        papers.Print();
    }
}