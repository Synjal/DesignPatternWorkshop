namespace DesignPatternWorkshop.FactoryMethod.cash;

public class CashClient : Client
{
    protected override Order CreateOrder()
    {
        return new CashOrder();
    }
}