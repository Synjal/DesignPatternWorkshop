using DesignPatternWorkshop;
using DesignPatternWorkshop.Builder;
using DesignPatternWorkshop.Factory;
using DesignPatternWorkshop.Factory.electric;
using DesignPatternWorkshop.Factory.petrol;
using DesignPatternWorkshop.FactoryMethod;
using DesignPatternWorkshop.FactoryMethod.cash;
using DesignPatternWorkshop.FactoryMethod.credit;

// -------------------- Factory --------------------
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

// -------------------- Builder --------------------
Title("Builder");
SubTitle("Client HTML");
_ = new VehicleClient(FileFormat.Html);
Spacer();
SubTitle("Client PDF");
_ = new VehicleClient(FileFormat.Pdf);
Spacer();

// -------------------- Factory Method --------------------
Title("Factory Method");
SubTitle("Client comptant");
new CashClient().NewOrder();
Spacer();
new CreditClient().NewOrder();
Spacer();


return;

void Title(string title) { Console.WriteLine($"-------------------- {title} --------------------"); }
void SubTitle(string title) { Console.WriteLine($"-------- {title} --------"); }
void Spacer() { Console.WriteLine(); }