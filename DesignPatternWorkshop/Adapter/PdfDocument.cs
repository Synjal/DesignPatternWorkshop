using DesignPatternWorkshop.Prototype;

namespace DesignPatternWorkshop.Adapter;

public class PdfDocument: Document
{
    private readonly PdfComponent _pdfComponent = new();
    public override void Fill(string info)
    {
        _pdfComponent.PdfContentFix(info);
    }

    public override void Print()
    {
        _pdfComponent.PdfSendToPrinter();
    }

    public override void Show()
    {
        _pdfComponent.PdfPrepareShowing();
        _pdfComponent.PdfRefresh();
        _pdfComponent.FinishShowing();
    }
}