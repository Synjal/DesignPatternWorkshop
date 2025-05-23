using DesignPatternWorkshop;
using DesignPatternWorkshop.Adapter;
using DesignPatternWorkshop.Bridge.countries;
using DesignPatternWorkshop.Bridge.formats;
using DesignPatternWorkshop.Builder;
using DesignPatternWorkshop.Chain_Of_Responsibility.objects;
using DesignPatternWorkshop.Command;
using DesignPatternWorkshop.Composite;
using DesignPatternWorkshop.Decorator;
using DesignPatternWorkshop.Decorator.decorations;
using DesignPatternWorkshop.Facade;
using DesignPatternWorkshop.Facade.components;
using DesignPatternWorkshop.Factory;
using DesignPatternWorkshop.Factory.electric;
using DesignPatternWorkshop.Factory.petrol;
using DesignPatternWorkshop.FactoryMethod.cash;
using DesignPatternWorkshop.FactoryMethod.credit;
using DesignPatternWorkshop.Flyweight;
using DesignPatternWorkshop.Interpretor;
using DesignPatternWorkshop.Interpretor.operators;
using DesignPatternWorkshop.Prototype;
using DesignPatternWorkshop.Prototype.documents;
using DesignPatternWorkshop.Proxy;
using DesignPatternWorkshop.Singleton;
using DesignPatternWorkshop.Strategy;
using DesignPatternWorkshop.Strategy.strategies;

const string testCarBrand = "Toyota";

Factory();
Builder();
FactoryMethod();
Decorator();
Singleton();
Strategy();
//Bridge(); Require user inputs
Composite();
Prototype();
Adapter();
Facade();
Proxy();
Flyweight();
ChainOfResponsibility();
Command();
Interpretor();
return;

void Title(string title) { Console.WriteLine($"-------------------- {title} --------------------"); }
void SubTitle(string subtitle) { Console.WriteLine($"-------- {subtitle} --------"); }
void Spacer() { Console.WriteLine(); }

void Factory()
{
    VehicleFactory electricFactory = new ElectricVehicleFactory(testCarBrand, 12000);
    VehicleFactory petrolFactory = new PetrolVehicleFactory(testCarBrand, 16500);

    Title("Factory");
    SubTitle("Véhicules électriques");
    new Catalog().ShowProducts(electricFactory);
    Spacer();
    SubTitle("Véhicules essence");
    new Catalog().ShowProducts(petrolFactory);
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
            new ModelDecorator(new VehicleView(new AnimationProxy()))
        );
    
    decoratedVehicle.Show();
    Spacer();
}

void Singleton()
{
    IDocument commandOrder = new PurchaseOrder();
    Title("Singleton");
    SubTitle("Ajout du bon de commande et de l'immatriculation");
    var papers = BlankPapers.Instance();
    papers.Add(commandOrder);
    papers.Add(new RegistrationOrder());
    papers.Print();

    SubTitle("Retrait du bon de commande dans un autre objet");
    var otherRef = BlankPapers.Instance();
    otherRef.Remove(commandOrder);
    
    papers.Print();
    papers.Clear();
    Spacer();
}

void Strategy()
{
    Title("Strategy");
    SubTitle("Affichage : Un véhicule par lignes");
    new CatalogView(new OneVehiclePerLineStrategy()).Draw();
    Spacer();
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
    
    company1.AddVehicle(new ElectricCar(testCarBrand, 65000), new ElectricMotorcycle("Peugeot", 12500));
    company1.AddSubsidiary();
    company2.AddVehicle(new PetrolCar("Renault", 2500), new PetrolMotorcycle("Renault", 14750));
    holding.AddSubsidiary(company1, company2);
    holding.AddVehicle(new ElectricCar("Tesla", 55000));
    
    Title("Composite");
    SubTitle("Société sans filiales : véhicules électriques");
    Console.WriteLine($"Coût de l'entretien : {company1.MaintenanceCost()}€");
    Spacer();
    SubTitle("Société sans filiales : véhicules à essence");
    Console.WriteLine($"Coût de l'entretien : {company2.MaintenanceCost()}€");
    Spacer();
    SubTitle("Société mère avec une voiture électrique en plus");
    Console.WriteLine($"Coût total d'entretien : {holding.MaintenanceCost()}€");
    
    Spacer();
}

void Prototype()
{
    BlankPapers.Instance().Add(new PurchaseOrder(), new RegistrationOrder(), new CertificateTransferOrder());
    var clientPapers = new ClientPapers("M. John Doe - 21/05/2025");
    
    Title("Prototype");
    SubTitle("Affichage des documents");
    clientPapers.Show();
    Spacer();
    SubTitle("Impression des documents");
    clientPapers.Print();
    Spacer();
}

void Adapter()
{
    var html = new HtmlDocument();
    var pdf = new PdfDocument();
    
    Title("Adapter");
    SubTitle("Affichage HTML");
    html.Fill("Contenu HTML");
    html.Show();
    html.Print();
    Spacer();
    
    SubTitle("Affichage PDF");
    pdf.Fill("Contenu PDF");
    pdf.Show();
    pdf.Print();
    Spacer();
}

void Facade()
{
    var facade = new AutoWebService();
    var filteredVehicle = facade.SearchVehicles(15000, 5000);
    
    Title("Facade");
    SubTitle("Catalogue");
    foreach (var vehicle in filteredVehicle)
    {
        Console.WriteLine($"Marque : {vehicle.Brand}");
        Console.WriteLine($"Prix : {vehicle.Price}");
        Console.WriteLine($"Coût d'entretien : {vehicle.MaintenanceCost}");
        Spacer();
    }
    Spacer();
    
    SubTitle("Reprise véhicule");
    Console.WriteLine(facade.IsEligibleForRecovery(new ElectricCar(testCarBrand, 2500)) 
        ? "Eligible à la reprise" 
        : "Non éligible à la reprise");
    Spacer();
    
    SubTitle("Gestion des documents");
    foreach (var vehicle in filteredVehicle)
    {
        foreach (var doc in facade.GenerateClientPapers(vehicle.Brand + " - Client A"))
        {
            doc.Print();
        } 
        Spacer();
    }
    Spacer();

}

void Proxy()
{
    var view = new VehicleView(new AnimationProxy());
    
    Title("Proxy");
    SubTitle("Premier clique");
    view.Show();
    view.ClickOnAnimation();
    Spacer();
    
    SubTitle("Deuxième clique");
    view.ClickOnAnimation();
    Spacer();
}

void Flyweight()
{
    var fabric = new OptionFabric();

    var optionGps = fabric.GetOption("GPS");
    var optionClimatisation = fabric.GetOption("Climatisation");
    var optionGps2 = fabric.GetOption("GPS");

    var car = new VehicleOrder();
    car.AddOption(optionGps, 1200);
    car.AddOption(optionClimatisation, 800);
    car.AddOption(optionGps2, 1250);
    
    Title("Flyweight");
    car.ShowOptions();
}

void ChainOfResponsibility()
{
    var vehicle = new ElectricCar(testCarBrand, 1000);
    var model = new Model();
    var brand = new Brand();
    
    vehicle.SetNext(model);
    model.SetNext(brand);
    
    Title("Chain Of Responsibility");
    Console.WriteLine(vehicle.GiveDescription());
    Spacer();
}

void Command()
{
    var command = new OrderSettle(0, 50);
    var catalog = new Catalog();
    
    Title("Command");
    SubTitle("Nouvelle promotion");
    catalog.LaunchOrderSettle(command);
    Spacer();
    
    SubTitle("Annulation de la promotion");
    catalog.CancelOrderSettle();
    Spacer();
    
    SubTitle("Restoration de la promotion");
    catalog.RestoreOrderSettle();
    Spacer();
}

void Interpretor()
{
    var expression = new AndOperator(
        new AndOperator(
            new OrOperator(
                new Keyword("rouge"),
                new Keyword("bleu")
            ),
            new Keyword("essence")
        ),
        new Keyword("récent")
    );
    var result = expression.Evaluate(VehicleRepository.GetAll());
    
    Title("Interpretor");
    SubTitle("Recherche sur '(rouge ou bleu) et essence et récent'");
    
    if (result.Count == 0) Console.WriteLine("Aucun élément ne correspond à vos critères de recherche");
    foreach (var vehicle in result)
    {
        Console.WriteLine(vehicle);
    }
    Spacer();
    
    SubTitle("Recherche sur 'essence'");
    var expression2 = new Keyword("essence");
    result = expression2.Evaluate(VehicleRepository.GetAll());
    
    if (result.Count == 0) Console.WriteLine("Aucun élément ne correspond à vos critères de recherche");
    foreach (var vehicle in result)
    {
        Console.WriteLine(vehicle);
    }
    Spacer();
}