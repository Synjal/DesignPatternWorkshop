using DesignPatternWorkshop.Factory;

namespace DesignPatternWorkshop.Interpretor.operators;

public class OrOperator(IExpression left, IExpression right) : BinaryOperator(left, right)
{
    public override List<Vehicle> Evaluate(List<Vehicle> vehicles)
    {
        var leftResult = Left.Evaluate(vehicles);
        var rightResult = Right.Evaluate(vehicles);

        return leftResult
            .Union(rightResult)
            .Distinct()
            .ToList();
    }
}