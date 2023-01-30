namespace ParserLib.Expression.Operator
{
    public class OperatorRegistry
    {
        public HashSet<Operator> Operators { get; }
        public OperatorRegistry()
        {
            Operators = new HashSet<Operator>();
        }
    }
}
