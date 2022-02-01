using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        return Math.Sqrt(x * x + y * y) switch
        {
            var s when s <= 1 => 10,
            var s when s <= 5 => 5,
            var s when s <= 10 => 1,
            _ => 0
        };
    }
}
