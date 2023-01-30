using ParserLib.Expression.Operator.Operands;

namespace ParserLib.Expression.Operator
{
    public interface Operator
    {
        public string Name { get; }
        public string Definition { get; }
        public Operand Evaluate(Operand a, Operand b);
    }
}
