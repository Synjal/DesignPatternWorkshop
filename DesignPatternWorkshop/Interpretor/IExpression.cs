using DesignPatternWorkshop.Factory;

namespace DesignPatternWorkshop.Interpretor;

public interface IExpression
{
    public List<Vehicle> Evaluate(List<Vehicle> vehicles);
}