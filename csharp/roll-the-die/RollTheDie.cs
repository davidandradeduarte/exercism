using System;

public class Player
{
    private const int minDice = 1, maxDice = 18;
    
    public int RollDie() => new Random().Next(minDice, maxDice);

    public double GenerateSpellStrength() => new Random().NextDouble() * 100;
}
