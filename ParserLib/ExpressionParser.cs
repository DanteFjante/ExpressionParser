using ParserLib.Expression.Operator;

namespace ParserLib
{
    public class ExpressionParser
    {
        public OperatorRegistry registry { get; }
        public ExpressionParser(OperatorRegistry registry)
        {
            this.registry = registry;
        }
    }
}
