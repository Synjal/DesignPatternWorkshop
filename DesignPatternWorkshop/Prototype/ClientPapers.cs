using DesignPatternWorkshop.Builder;
using DesignPatternWorkshop.Singleton;

namespace DesignPatternWorkshop.Prototype;

public class ClientPapers
{
    private readonly List<IDocument> _documents = [];

    public ClientPapers(string clientInfo)
    {
        foreach (var doc in BlankPapers.Instance().Documents)
        {
            var copy = doc.Clone();
            copy.Fill(clientInfo);
            _documents.Add(copy);
        }
    }

    public void Show()
    {
        foreach (var doc in _documents) doc.Show();
    }

    public List<IDocument> getDocuments()
    {
        return _documents;
    }

    public void Print()
    {
        foreach (var doc in _documents) doc.Print();
    }
}