class Lasagna
{
    private const int cookingTime = 40;

    public int ExpectedMinutesInOven() => cookingTime;
    public int RemainingMinutesInOven(int timeInOven) => cookingTime - timeInOven;
    public int PreparationTimeInMinutes(int layers) => layers * 2;
    public int ElapsedTimeInMinutes(int layers, int timeInOven) => (PreparationTimeInMinutes(layers) + timeInOven);
}
