using LineComparison;

internal class Program
{
    private static void Main(string[] args)
    {
        CalculateItsLength calculateItsLength = new CalculateItsLength();
        calculateItsLength.Main(args);

        CheckEquality checkEquality = new CheckEquality();
        checkEquality.Main(args);
    }
}