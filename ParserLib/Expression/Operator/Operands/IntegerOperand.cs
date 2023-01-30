namespace ParserLib.Expression.Operator.Operands
{
    public class IntegerOperand : RelativeOperand
    {
        public string Name => "Integer";
        public int GetValue => (int)Value;
        public object Value { get; }

        public IntegerOperand(int value)
        {
            Value = value;
        }

        #region Implicit/Explicit Casts
        public static implicit operator int(IntegerOperand value)
        {
            return value.GetValue;
        }

        public static explicit operator IntegerOperand(int value)
        {
            return new IntegerOperand(value);
        }

        public static implicit operator DoubleOperand(IntegerOperand value)
        {
            return new DoubleOperand(value.GetValue);
        }

        public static explicit operator IntegerOperand(DoubleOperand value)
        {
            return new IntegerOperand((int)value.Value);
        }
        #endregion


        #region Arithmetic Operators
        public static RelativeOperand operator +(IntegerOperand a, object b)
        {
            if (b is int)
                return new DoubleOperand(a.GetValue + ((int)b));
            if (b is double)
                return new DoubleOperand(a.GetValue + ((double)b));
            if (b is RelativeOperand)
                return new DoubleOperand(a.GetValue + ((DoubleOperand)b).GetValue);
            return null;
        }

        public static RelativeOperand operator -(IntegerOperand a, object b)
        {
            if (b is int)
                return new DoubleOperand(a.GetValue - ((int)b));
            if (b is double)
                return new DoubleOperand(a.GetValue - ((double)b));
            if (b is RelativeOperand)
                return new DoubleOperand(a.GetValue - ((DoubleOperand)b).GetValue);
            return null;
        }

        public static RelativeOperand operator *(IntegerOperand a, object b)
        {
            if (b is int)
                return new DoubleOperand(a.GetValue * ((int)b));
            if (b is double)
                return new DoubleOperand(a.GetValue * ((double)b));
            if (b is RelativeOperand)
                return new DoubleOperand(a.GetValue * ((DoubleOperand)b).GetValue);
            return null;
        }

        public static RelativeOperand operator /(IntegerOperand a, object b)
        {
            if (b is int)
                return new DoubleOperand(a.GetValue / ((int)b));
            if (b is double)
                return new DoubleOperand(a.GetValue / ((double)b));
            if (b is RelativeOperand)
                return new DoubleOperand(a.GetValue / ((DoubleOperand)b).GetValue);
            return null;
        }

        public static RelativeOperand operator %(IntegerOperand a, object b)
        {
            if (b is int)
                return new DoubleOperand(a.GetValue % ((int)b));
            if (b is double)
                return new DoubleOperand(a.GetValue % ((double)b));
            if (b is RelativeOperand)
                return new DoubleOperand(a.GetValue % ((DoubleOperand)b).GetValue);
            return null;
        }

        public static IntegerOperand operator ++(IntegerOperand a)
        {
            return new IntegerOperand(a.GetValue + 1);
        }

        public static IntegerOperand operator --(IntegerOperand a)
        {
            return new IntegerOperand(a.GetValue - 1);
        }
        public static RelativeOperand operator +(IntegerOperand a)
        {
            return new IntegerOperand(+a.GetValue);
        }

        public static RelativeOperand operator -(IntegerOperand a)
        {
            return new IntegerOperand(-a.GetValue);
        }
        #endregion

        #region Boolean Operators
        public static bool operator ==(IntegerOperand a, object b)
        {
            if (b is int)
                return a.GetValue == ((int)b);
            if (b is double)
                return a.GetValue == ((double)b);
            if (b is RelativeOperand)
                return a.GetValue == ((DoubleOperand)b).GetValue;
            return false;
        }

        public static bool operator !=(IntegerOperand a, object b)
        {
            if (b is int)
                return a.GetValue != ((int)b);
            if (b is double)
                return a.GetValue != ((double)b);
            if (b is RelativeOperand)
                return a.GetValue != ((DoubleOperand)b).GetValue;
            return false;
        }

        public static bool operator >(IntegerOperand a, object b)
        {
            if (b is int)
                return a.GetValue > ((int)b);
            if (b is double)
                return a.GetValue > ((double)b);
            if (b is RelativeOperand)
                return a.GetValue > ((DoubleOperand)b).GetValue;
            return false;
        }

        public static bool operator <(IntegerOperand a, object b)
        {
            if (b is int)
                return a.GetValue < ((int)b);
            if (b is double)
                return a.GetValue < ((double)b);
            if (b is RelativeOperand)
                return a.GetValue < ((DoubleOperand)b).GetValue;
            return false;
        }

        public static bool operator >=(IntegerOperand a, object b)
        {
            if (b is int)
                return a.GetValue >= ((int)b);
            if (b is double)
                return a.GetValue >= ((double)b);
            if (b is RelativeOperand)
                return a.GetValue >= ((DoubleOperand)b).GetValue;
            return false;
        }

        public static bool operator <=(IntegerOperand a, object b)
        {
            if (b is int)
                return a.GetValue <= ((int)b);
            if (b is double)
                return a.GetValue <= ((double)b);
            if (b is RelativeOperand)
                return a.GetValue <= ((DoubleOperand)b).GetValue;
            return false;
        }

        public static RelativeOperand operator !(IntegerOperand a)
        {
            return new IntegerOperand(a.GetValue == 0 ? 1 : 0);
        }

        #endregion
    }
}
