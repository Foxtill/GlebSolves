public class MathExtended
{
    public static int lastCalculatedValue;
    public static int Clamp(int value, int min, int max)
    {
        return lastCalculatedValue  = value > max ? max : value < min ? min : value;
    }
}