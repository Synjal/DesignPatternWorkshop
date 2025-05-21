using DesignPatternWorkshop.Prototype;

namespace DesignPatternWorkshop.Adapter;

public class HtmlDocument: Document
{
    private string _content = string.Empty;

    public override void Fill(string info)
    {
        _content = info;
    }

    public override void Show()
    {
        Console.WriteLine("HTML Draw : ");
        Console.WriteLine($"<div>{_content}</div>");
    }

    public override void Print()
    {
        Console.WriteLine("HTML Print : ");
        Console.WriteLine(_content);
    }
}