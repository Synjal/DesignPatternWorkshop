namespace DesignPatternWorkshop.FactoryMethod;

public abstract class Client
{
    public void NewOrder()
    {
        var order = CreateOrder();
        if(order.Validate()){ order.Pay(); }
        else { Console.WriteLine("Commande non validée."); }
    }

    protected abstract Order CreateOrder();
}