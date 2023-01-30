using ParserLib.Expression.Operator.Operand;

namespace ParserLib.Expression.Operator
{
    public interface BooleanOperator : Operator
    {
        public BooleanOperand Evaluate(BooleanOperand a, BooleanOperand b);
        
    }
}
