using DesignPatternWorkshop.Factory;

namespace DesignPatternWorkshop.Interpretor.operators;

public class AndOperator(IExpression left, IExpression right): BinaryOperator(left, right)
{
    public override List<Vehicle> Evaluate(List<Vehicle> vehicles)
    {
        var lefResult = Left.Evaluate(vehicles);
        var rightResult = Right.Evaluate(lefResult);
        return rightResult;
    }
}