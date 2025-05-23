using DesignPatternWorkshop.Factory;

namespace DesignPatternWorkshop.Interpretor;

public abstract class BinaryOperator(IExpression left, IExpression right) : IExpression
{
    protected readonly IExpression Left = left;
    protected readonly IExpression Right = right;
    
    public abstract List<Vehicle> Evaluate(List<Vehicle> vehicles);
}