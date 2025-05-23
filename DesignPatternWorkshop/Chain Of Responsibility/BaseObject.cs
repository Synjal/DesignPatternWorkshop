using DesignPatternWorkshop.Chain_Of_Responsibility.objects;
using DesignPatternWorkshop.Factory;
using DesignPatternWorkshop.Factory.electric;

namespace DesignPatternWorkshop.Chain_Of_Responsibility;

public abstract class BaseObject
{
    protected string DefaultDescription = "Description par défaut : Objet de base";
    protected BaseObject? Next;

    public void SetNext(BaseObject next)
    {
        Next = next;
    }
    protected abstract string? GetDescription();

    public string GiveDescription()
    {
        string? result = GetDescription();
        if (result != null) return result;
        return Next != null ? Next.GetDescription() : DefaultDescription;
    }
}