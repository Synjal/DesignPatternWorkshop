using DesignPatternWorkshop;
using DesignPatternWorkshop.Builder;
using DesignPatternWorkshop.Decorator;
using DesignPatternWorkshop.Decorator.decorations;
using DesignPatternWorkshop.Factory;
using DesignPatternWorkshop.Factory.electric;
using DesignPatternWorkshop.Factory.petrol;
using DesignPatternWorkshop.FactoryMethod.cash;
using DesignPatternWorkshop.FactoryMethod.credit;

Factory();
Builder();
FactoryMethod();
Decorator();
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