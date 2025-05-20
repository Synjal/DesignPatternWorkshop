using DesignPatternWorkshop;
using DesignPatternWorkshop.Builder;
using DesignPatternWorkshop.Factory;
using DesignPatternWorkshop.Factory.electric;
using DesignPatternWorkshop.Factory.petrol;

// -------------------- Factory --------------------
VehicleFactory electricFactory = new ElectricVehicleFactory();
VehicleFactory petrolFactory = new PetrolVehicleFactory();

var electricCatalog = new Catalog(electricFactory);
var petrolCatalog = new Catalog(petrolFactory);

Title("Factory");
SubTitle("Véhicules électriques");
electricCatalog.ShowProducts();
Spacer();
SubTitle("Véhicules essence");
petrolCatalog.ShowProducts();
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
return;

void Title(string title) { Console.WriteLine($"-------------------- {title} --------------------"); }
void SubTitle(string title) { Console.WriteLine($"-------- {title} --------"); }
void Spacer() { Console.WriteLine(""); }