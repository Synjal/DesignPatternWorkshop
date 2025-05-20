namespace DesignPatternWorkshop.Builder;

public abstract class Papers
{
    protected List<string> Documents = new List<string>();

    public void AddDocument(string document)
    {
        Documents.Add(document);
    }

    public abstract void Print();
}