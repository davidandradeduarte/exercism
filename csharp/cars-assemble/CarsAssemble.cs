using System;

static class AssemblyLine
{
    private const int carsProducedAtLowestSpeed = 221;

    public static double SuccessRate(int speed)
    {
        switch (speed)
        {
            case 0:
                return 0;
            case var n when (n >= 1 && n <= 4):
                return 1;
            case var n when (n >= 5 && n <= 8):
                return 0.9;
            case 9:
                return 0.8;
            case 10:
                return 0.77;
            default:
                throw new NotImplementedException();
        }
    }

    public static double ProductionRatePerHour(int speed)
    {
        return speed * carsProducedAtLowestSpeed * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return Convert.ToInt32(Math.Floor(ProductionRatePerHour(speed) / 60));
    }
}
