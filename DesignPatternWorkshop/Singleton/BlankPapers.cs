namespace DesignPatternWorkshop.Singleton;

public class BlankPapers
{
    private static BlankPapers? _instance;
    private static readonly Lock Lock = new();
    
    private readonly List<string> _documents = [];
    
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

    public void Add(string document)
    {
        _documents.Add(document);
    }

    public void Remove(string document)
    {
        _documents.Remove(document);
    }

    public void Show()
    {
        Console.WriteLine("Liasse vierge :");
        foreach (var doc in _documents)
        {
            Console.WriteLine("- " + doc);
        }
    }
}