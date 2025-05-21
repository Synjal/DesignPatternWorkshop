namespace DesignPatternWorkshop.Prototype;

public interface IDocument
{
    IDocument Clone();
    void Fill(string info);
    void Print();
    void Show();
}