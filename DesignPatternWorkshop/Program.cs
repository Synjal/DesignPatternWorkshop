using DesignPatternWorkshop;
using DesignPatternWorkshop.Builder;
using DesignPatternWorkshop.Decorator;
using DesignPatternWorkshop.Decorator.decorations;
using DesignPatternWorkshop.Factory;
using DesignPatternWorkshop.Factory.electric;
using DesignPatternWorkshop.Factory.petrol;
using DesignPatternWorkshop.FactoryMethod.cash;
using DesignPatternWorkshop.FactoryMethod.credit;
using DesignPatternWorkshop.Singleton;

Factory();
Builder();
FactoryMethod();
Decorator();
Singleton();
return;

void Title(string title) { Console.WriteLine($"-------------------- {title} --------------------"); }
void SubTitle(string title) { Console.WriteLine($"-------- {title} --------"); }
void Spacer() { Console.WriteLine(); }

void Factory()
{
    VehicleFactory electricFactory = new ElectricVehicleFactory();
    VehicleFactory petrolFactory = new PetrolVehicleFactory();

    Title("Factory");
    SubTitle("Véhicules électriques");
    new Catalog(electricFactory).ShowProducts();
    Spacer();
    SubTitle("Véhicules essence");
    new Catalog(petrolFactory).ShowProducts();
    Spacer();
    Spacer();
}

void Builder()
{
    Title("Builder");
    SubTitle("Client HTML");
    _ = new VehicleClient(FileFormat.Html);
    Spacer();
    SubTitle("Client PDF");
    _ = new VehicleClient(FileFormat.Pdf);
    Spacer();
}

void FactoryMethod()
{
    Title("Factory Method");
    SubTitle("Client comptant");
    new CashClient().NewOrder();
    Spacer();
    SubTitle("Client à crédit");
    new CreditClient().NewOrder();
    Spacer();
}

void Decorator()
{
    Title("Decorator");
    VehicleGraphicalComponent decoratedVehicle =
        new BrandDecorator(
            new ModelDecorator(new VehicleView())
        );
    
    decoratedVehicle.Show();
    Spacer();
}

void Singleton()
{
    Title("Singleton");
    SubTitle("Ajout du bon de commande et de l'immatriculation");
    BlankPapers papers = BlankPapers.Instance();
    papers.Add("Bon de commande vierge");
    papers.Add("Demande d'immatriculation vierge");
    papers.Show();

    SubTitle("Retrait du bon de commande dans un autre objet");
    var otherRef = BlankPapers.Instance();
    otherRef.Remove("Bon de commande vierge");
    
    papers.Show();
    Spacer();
}