namespace DesignPatternWorkshop.FactoryMethod;

public abstract class Order
{
    public abstract bool Validate();
    public abstract void Pay();
}