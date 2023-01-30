
namespace ParserLib.Expression.Operator.Operands
{
    public class DoubleOperand : RelativeOperand
    {
        public string Name => "Double";
        
        public double GetValue => (double) Value;

        public object Value { get; }
        
        public DoubleOperand(double value)
        {
            Value = value;
        }


        #region Implicit/Explicit Casts
        public static implicit operator double(DoubleOperand value)
        {
            return value.GetValue;
        }

        public static explicit operator DoubleOperand(double value)
        {
            return new DoubleOperand(value);
        }

        public static implicit operator IntegerOperand(DoubleOperand value)
        {
            return new IntegerOperand((int)value.GetValue);
        }

        public static explicit operator DoubleOperand(IntegerOperand value)
        {
            return new DoubleOperand(value.GetValue);
        }
        #endregion


        #region Arithmetic Operators
        public static RelativeOperand operator +(DoubleOperand a, object b)
        {
            if (b is int)
                return new DoubleOperand(a.GetValue + ((int)b));
            if (b is double)
                return new DoubleOperand(a.GetValue + ((double)b));
            if (b is RelativeOperand)
                return new DoubleOperand(a.GetValue + ((DoubleOperand)b).GetValue);
            return null;
        }

        public static RelativeOperand operator -(DoubleOperand a, object b)
        {
            if (b is int)
                return new DoubleOperand(a.GetValue - ((int)b));
            if (b is double)
                return new DoubleOperand(a.GetValue - ((double)b));
            if (b is RelativeOperand)
                return new DoubleOperand(a.GetValue - ((DoubleOperand)b).GetValue);
            return null;
        }

        public static RelativeOperand operator *(DoubleOperand a, object b)
        {
            if (b is int)
                return new DoubleOperand(a.GetValue * ((int)b));
            if (b is double)
                return new DoubleOperand(a.GetValue * ((double)b));
            if (b is RelativeOperand)
                return new DoubleOperand(a.GetValue * ((DoubleOperand)b).GetValue);
            return null;
        }

        public static RelativeOperand operator /(DoubleOperand a, object b)
        {
            if (b is int)
                return new DoubleOperand(a.GetValue / ((int)b));
            if (b is double)
                return new DoubleOperand(a.GetValue / ((double)b));
            if (b is RelativeOperand)
                return new DoubleOperand(a.GetValue / ((DoubleOperand)b).GetValue);
            return null;
        }

        public static RelativeOperand operator %(DoubleOperand a, object b)
        {
            if (b is int)
                return new DoubleOperand(a.GetValue % ((int)b));
            if (b is double)
                return new DoubleOperand(a.GetValue % ((double)b));
            if (b is RelativeOperand)
                return new DoubleOperand(a.GetValue % ((DoubleOperand)b).GetValue);
            return null;
        }

        public static DoubleOperand operator ++(DoubleOperand a)
        {
            return new DoubleOperand(a.GetValue + 1);
        }

        public static DoubleOperand operator --(DoubleOperand a)
        {
            return new DoubleOperand(a.GetValue - 1);
        }
        public static RelativeOperand operator +(DoubleOperand a)
        {
            return new DoubleOperand(+a.GetValue);
        }

        public static RelativeOperand operator -(DoubleOperand a)
        {
            return new DoubleOperand(-a.GetValue);
        }
        #endregion

        #region Boolean Operators
        public static bool operator ==(DoubleOperand a, object b)
        {
            if (b is int)
                return a.GetValue == ((int)b);
            if (b is double)
                return a.GetValue == ((double)b);
            if (b is RelativeOperand)
                return a.GetValue == ((DoubleOperand)b).GetValue;
            return false;
        }

        public static bool operator !=(DoubleOperand a, object b)
        {
            if (b is int)
                return a.GetValue != ((int)b);
            if (b is double)
                return a.GetValue != ((double)b);
            if (b is RelativeOperand)
                return a.GetValue != ((DoubleOperand)b).GetValue;
            return false;
        }

        public static bool operator >(DoubleOperand a, object b)
        {
            if (b is int)
                return a.GetValue > ((int)b);
            if (b is double)
                return a.GetValue > ((double)b);
            if (b is RelativeOperand)
                return a.GetValue > ((DoubleOperand)b).GetValue;
            return false;
        }

        public static bool operator <(DoubleOperand a, object b)
        {
            if (b is int)
                return a.GetValue < ((int)b);
            if (b is double)
                return a.GetValue < ((double)b);
            if (b is RelativeOperand)
                return a.GetValue < ((DoubleOperand)b).GetValue;
            return false;
        }

        public static bool operator >=(DoubleOperand a, object b)
        {
            if (b is int)
                return a.GetValue >= ((int)b);
            if (b is double)
                return a.GetValue >= ((double)b);
            if (b is RelativeOperand)
                return a.GetValue >= ((DoubleOperand)b).GetValue;
            return false;
        }

        public static bool operator <=(DoubleOperand a, object b)
        {
            if (b is int)
                return a.GetValue <= ((int)b);
            if (b is double)
                return a.GetValue <= ((double)b);
            if (b is RelativeOperand)
                return a.GetValue <= ((DoubleOperand)b).GetValue;
            return false;
        }

        public static RelativeOperand operator !(DoubleOperand a)
        {
            return new DoubleOperand(a.GetValue == 0 ? 1 : 0);
        }

        #endregion
    }
}
