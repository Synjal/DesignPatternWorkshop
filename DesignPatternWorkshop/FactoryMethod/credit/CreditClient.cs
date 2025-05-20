namespace DesignPatternWorkshop.FactoryMethod.credit;

public class CreditClient : Client
{
    protected override Order CreateOrder()
    {
        return new CreditOrder();
    }
}