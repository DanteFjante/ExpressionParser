using ParserLib.Expression.Operator.Operand;

namespace ParserLib.Expression.Operator
{
    public interface ArithmeticOperator : Operator
    {
        public RelativeOperand Evaluate(RelativeOperand a, RelativeOperand b);
    }
}
