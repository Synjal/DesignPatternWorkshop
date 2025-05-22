using DesignPatternWorkshop.Factory;
using DesignPatternWorkshop.Prototype;

namespace DesignPatternWorkshop.Facade.components;

public static class DocumentHandling
{
    public static List<IDocument> GenerateClientsPapers(string infos)
    {
        ClientPapers clientPapers = new(infos);
        return clientPapers.getDocuments();
    }
}