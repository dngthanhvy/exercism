using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        switch (balance) {
            case var _ when balance < 0:
                return 3.213f;
            case var _ when balance < 1000:
                return 0.5f;
            case var _ when balance >= 1000 && balance < 5000:
                return 1.621f;
            default:
                return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        return (decimal)InterestRate(balance)*balance/100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance) {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance) {
        int count = 0;
        while (balance < targetBalance) {
            balance = AnnualBalanceUpdate(balance);
            count++;
        }

        return count;
    }
}
