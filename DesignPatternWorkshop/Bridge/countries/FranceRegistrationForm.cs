using System.ComponentModel.DataAnnotations;

namespace DesignPatternWorkshop.Bridge.countries;

public class FranceRegistrationForm(IFormImpl impl) : RegistrationForm(impl)
{
    public override bool ValidateInput()
    {
        return VehiclePlate.Length == 9 && VehiclePlate.Contains("-");
    }
}