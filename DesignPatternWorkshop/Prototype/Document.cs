namespace DesignPatternWorkshop.Prototype;

public abstract class Document : IDocument
{
    protected string Content = "";

    public IDocument Clone()
    {
        return (IDocument)MemberwiseClone();
    }

    public virtual void Fill(string info)
    {
        Content = info;
    }

    public abstract void Print();
    public abstract void Show();
}