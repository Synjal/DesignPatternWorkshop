namespace DesignPatternWorkshop.Chain_Of_Responsibility.objects;

public class Brand : BaseObject
{
    protected override string? GetDescription()
    {
        return "Description de la marque";
    }
}