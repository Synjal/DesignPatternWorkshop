namespace DesignPatternWorkshop.FactoryMethod.credit;

public class CreditOrder: Order
{
    public override bool Validate()
    {
        Console.WriteLine("Validation commande à crédit");
        return true;
    }

    public override void Pay()
    {
        Console.WriteLine("Paiement à crédit enregistré !");
    }
}