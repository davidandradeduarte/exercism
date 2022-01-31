using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        switch (balance)
        {
            case < 0:
                return 3.213f;
            case var b when b >= 0 && b < 1000:
                return 0.5f;
            case var b when b >= 1000 && b < 5000:
                return 1.621f;
            case >= 5000:
                return 2.475f;
            default:
                throw new NotImplementedException();
        }
    }

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)InterestRate(balance) * 0.01m;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var years = 0;
        while (balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
