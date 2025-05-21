using DesignPatternWorkshop.Prototype;

namespace DesignPatternWorkshop.Singleton;

public class BlankPapers
{
    private static BlankPapers? _instance;
    private static readonly Lock Lock = new();
    
    private readonly List<IDocument> _documents = [];
    
    private BlankPapers() {}

    public static BlankPapers Instance()
    {
        return _instance ??= CreateInstance();

        static BlankPapers CreateInstance()
        {
            lock (Lock)
            {
                return _instance ??= new BlankPapers();
            }
        }
    }

    public void Add(params IDocument[] document)
    {
        foreach (var doc in document)
        {
            _documents.Add(doc);
        }
    }

    public void Remove(params IDocument[] document)
    {
        foreach (var doc in document)
        {
            _documents.Remove(doc);
        }
    } 

    public void Print()
    {
        Console.WriteLine("Liasse vierge :");
        foreach (var doc in _documents)
        {
            Console.WriteLine("- " + doc);
        }
    }

    public void Clear() => _documents.Clear();
    
    public IReadOnlyList<IDocument> Documents => _documents;
}