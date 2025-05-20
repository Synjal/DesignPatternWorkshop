using DesignPatternWorkshop;
using DesignPatternWorkshop.Factory;
using DesignPatternWorkshop.Factory.electric;
using DesignPatternWorkshop.Factory.petrol;

VehicleFactory electricFactory = new ElectricVehicleFactory();
VehicleFactory petrolFactory = new PetrolVehicleFactory();

var electricCatalog = new Catalog(electricFactory);
var petrolCatalog = new Catalog(petrolFactory);

Console.WriteLine("--- Véhicules électriques ---");
electricCatalog.ShowProducts();
Console.WriteLine("-----------------------------");

Console.WriteLine("--- Véhicules essence ---");
petrolCatalog.ShowProducts();
Console.WriteLine("-----------------------------");