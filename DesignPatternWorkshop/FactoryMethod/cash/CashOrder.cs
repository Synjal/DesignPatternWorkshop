namespace DesignPatternWorkshop.FactoryMethod.cash;

public class CashOrder : Order
{
    public override bool Validate()
    {
        Console.WriteLine("Validation commande comptant");
        return true;
    }

    public override void Pay()
    {
        Console.WriteLine("Paiement comptant effectué !");
    }
}