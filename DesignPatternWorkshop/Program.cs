using DesignPatternWorkshop;
using DesignPatternWorkshop.Bridge.countries;
using DesignPatternWorkshop.Bridge.formats;
using DesignPatternWorkshop.Builder;
using DesignPatternWorkshop.Composite;
using DesignPatternWorkshop.Decorator;
using DesignPatternWorkshop.Decorator.decorations;
using DesignPatternWorkshop.Factory;
using DesignPatternWorkshop.Factory.electric;
using DesignPatternWorkshop.Factory.petrol;
using DesignPatternWorkshop.FactoryMethod.cash;
using DesignPatternWorkshop.FactoryMethod.credit;
using DesignPatternWorkshop.Singleton;
using DesignPatternWorkshop.Strategy;
using DesignPatternWorkshop.Strategy.strategies;

Factory();
Builder();
FactoryMethod();
Decorator();
Singleton();
Strategy();
//Bridge(); Require user inputs
Composite();
return;

void Title(string title) { Console.WriteLine($"-------------------- {title} --------------------"); }
void SubTitle(string subtitle) { Console.WriteLine($"-------- {subtitle} --------"); }
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

void Strategy()
{
    Title("Strategy");
    SubTitle("Affichage : Un véhicule par lignes");
    new CatalogView(new OneVehiclePerLineStrategy()).Draw();
    SubTitle("Affichage : Trois véhicules par lignes");
    new CatalogView(new ThreeVehiclesPerLineStrategy()).Draw();
    Spacer();
}

void Bridge()
{
    var htmlForm = new FranceRegistrationForm(new HtmlFormImpl());
    var appleForm = new LuxembourgRegistrationForm(new AppleFormImpl());
    
    Title("Bridge");
    
    SubTitle("HTML France");
    htmlForm.Display();
    htmlForm.ManageInput();
    if (htmlForm.ValidateInput()) htmlForm.GenerateDocument();
    else Console.WriteLine("Plaque non valide.");
    Spacer();
    
    SubTitle("Apple Luxembourg");
    appleForm.Display();
    appleForm.ManageInput();
    if (appleForm.ValidateInput()) appleForm.GenerateDocument();
    else Console.WriteLine("Plaque non valide");
    Spacer();
}

void Composite()
{
    var company1 = new SimpleCompany();
    var company2 = new SimpleCompany();
    var holding = new ParentCompany();
    
    company1.AddVehicle(new ElectricCar(), new ElectricMotorcycle());
    company1.AddSubsidiary();
    company2.AddVehicle(new PetrolCar(), new PetrolMotorcycle());
    holding.AddSubsidiary(company1, company2);
    holding.AddVehicle(new ElectricCar());
    
    Title("Composite");
    SubTitle("Société sans filiales : véhicules électriques");
    Console.WriteLine($"Coût de l'entretien : {company1.MaintenanceCost()}€");
    SubTitle("Société sans filiales : véhicules à essence");
    Console.WriteLine($"Coût de l'entretien : {company2.MaintenanceCost()}€");
    SubTitle("Société mère avec une voiture électrique en plus");
    Console.WriteLine($"Coût total d'entretien : {holding.MaintenanceCost()}€");
}