using System;
abstract class CuttingStrategy
{
    public abstract int CalculateRevenue(int rodLength, int[] prices);
}
// Scenario A: max revenue
class MaxRevenue : CuttingStrategy
{
    public override int CalculateRevenue(int rodLength, int[] prices)
    {
        if (rodLength == 0)
            return 0;

        int maxRevenue = prices[rodLength];

        for (int cut = 1; cut < rodLength; cut++)
        {
            int revenue = prices[cut] + CalculateRevenue(rodLength - cut, prices);

            if (revenue > maxRevenue)
                maxRevenue = revenue;
        }

        return maxRevenue;
    }
}
// Scenario B: fixed waste constraint
class WasteLimitStrategy : CuttingStrategy
{
    private int allowedWaste;

    public WasteLimitStrategy(int allowedWaste)
    {
        this.allowedWaste = allowedWaste;
    }

    public override int CalculateRevenue(int rodLength, int[] prices)
    {
        if (rodLength <= allowedWaste)
            return 0;

        int maxRevenue = 0;

        for (int cut = 1; cut <= rodLength; cut++)
        {
            int remaining = rodLength - cut;

            if (remaining >= allowedWaste)
            {
                int revenue = prices[cut] + CalculateRevenue(remaining, prices);

                if (revenue > maxRevenue)
                    maxRevenue = revenue;
            }
        }

        return maxRevenue;
    }
}
// Scenario C: minimal waste
sealed class BalancedStrategy : CuttingStrategy
{
    public override int CalculateRevenue(int rodLength, int[] prices)
    {
        if (rodLength == 0)
            return 0;

        int bestRevenue = 0;

        for (int cut = 1; cut <= rodLength; cut++)
        {
            int remaining = rodLength - cut;

            int revenue = prices[cut] + CalculateRevenue(remaining, prices);

            if (remaining <= 1)
                revenue += 1;

            if (revenue > bestRevenue)
                bestRevenue = revenue;
        }

        return bestRevenue;
    }
}
// Encapsulation
class PriceChart
{
    private int[] prices;

    public PriceChart(int[] prices)
    {
        this.prices = prices;
    }

    public int[] GetPrices()
    {
        return prices;
    }
}
class CustomManufacturingFurniture
{
    static void Main()
    {
        int rodLength = 12;
        int[] prices = { 0, 2, 6, 7, 10, 13, 17, 17, 20, 24, 30, 33, 36 };

        PriceChart chart = new PriceChart(prices);

        // Scenario A
        CuttingStrategy strategy = new MaxRevenue();
        Console.WriteLine("Revenue (scenario-A)= " + strategy.CalculateRevenue(rodLength, chart.GetPrices()));

        // Scenario B
        strategy = new WasteLimitStrategy(1);
        Console.WriteLine("Revenue (scenario-B)= " + strategy.CalculateRevenue(rodLength, chart.GetPrices()));

        // Scenario C
        strategy = new BalancedStrategy();
        Console.WriteLine("Revenue (scenario-C)= " + strategy.CalculateRevenue(rodLength, chart.GetPrices()));
    }
}
