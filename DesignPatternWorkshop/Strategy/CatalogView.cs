namespace DesignPatternWorkshop.Strategy;

public class CatalogView(ICatalogDrawingStrategy drawingStrategy)
{
    private ICatalogDrawingStrategy _drawingStrategy = drawingStrategy;

    public void SetStrategy(ICatalogDrawingStrategy strategy)
    {
        _drawingStrategy = strategy;
    }

    public void Draw()
    {
        _drawingStrategy.Draw();
    }
}