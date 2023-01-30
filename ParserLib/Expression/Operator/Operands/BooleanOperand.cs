namespace ParserLib.Expression.Operator.Operands
{
    public class BooleanOperand : Operand
    {

        public bool GetValue => (bool) Value;
        

        public string Name => "Bool";

        public object Value { get; }

        public BooleanOperand(bool value)
        {
            Value = value ? true : false;
        }

        public static bool operator ==(BooleanOperand a, object b)
        {
            if(b is bool)
                return a.GetValue == ((bool) b);
            if (b is BooleanOperand)
                return a.GetValue == ((BooleanOperand)b).GetValue;
            return false;
        }
        public static bool operator !=(BooleanOperand a, object b)
        {
            if (b is bool)
                return a.GetValue != ((bool)b);
            if (b is BooleanOperand)
                return a.GetValue != ((BooleanOperand)b).GetValue;
            return false;
        }
        public static bool operator &(BooleanOperand a, object b)
        {
            if (b is bool)
                return a.GetValue & ((bool)b);
            if (b is BooleanOperand)
                return a.GetValue & ((BooleanOperand)b).GetValue;
            return false;
        }

        public static bool operator |(BooleanOperand a, object b)
        {
            if (b is bool)
                return a.GetValue | ((bool)b);
            if (b is BooleanOperand)
                return a.GetValue | ((BooleanOperand)b).GetValue;
            return false;
        }
        public static bool operator ^(BooleanOperand a, object b)
        {
            if (b is bool)
                return a.GetValue ^ ((bool)b);
            if (b is BooleanOperand)
                return a.GetValue ^ ((BooleanOperand)b).GetValue;
            return false;
        }

        public static implicit operator bool(BooleanOperand a) => a.GetValue;
        public static implicit operator BooleanOperand(bool a) => new BooleanOperand(a);

        public override string ToString()
        {
            return GetValue ? "True" : "False";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return GetValue ? 1 : 0;
        }
    }
}
