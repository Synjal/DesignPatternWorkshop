namespace DesignPatternWorkshop.Bridge.countries;

public class LuxembourgRegistrationForm(IFormImpl impl) : RegistrationForm(impl)
{
    public override bool ValidateInput()
    {
        return VehiclePlate.All(char.IsDigit) && VehiclePlate.Length == 6;
    }
}