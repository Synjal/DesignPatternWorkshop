using DesignPatternWorkshop.Prototype;

namespace DesignPatternWorkshop.Builder;

public abstract class Papers
{
    protected readonly List<IDocument> Documents = [];

    public void AddDocument(IDocument document)
    {
        Documents.Add(document);
    }

    public abstract void Print();
}