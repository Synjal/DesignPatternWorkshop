namespace DesignPatternWorkshop.Bridge;

public abstract class RegistrationForm(IFormImpl impl)
{
    protected string VehiclePlate = "";
    
    public void Display()
    {
        impl.DrawText("Formulaire d'immatriculation");
    }

    public void ManageInput()
    {
        impl.DrawText("Entrez la plaque :");
        VehiclePlate = impl.HandleInputField();
    }

    public abstract bool ValidateInput();

    public void GenerateDocument()
    {
        Console.WriteLine($"Plaque enregistrée : {VehiclePlate}");
    }
}