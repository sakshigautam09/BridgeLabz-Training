using System;
abstract class CuttingStrategy
{
    public abstract int CalculateRevenue(int rodLength, int[] prices);
}

// Optimized Strategy
class RecursiveStrategy : CuttingStrategy
{
    public override int CalculateRevenue(int rodLength, int[] prices)
    {
        // Base case
        if (rodLength == 0)
            return 0;

        int maxRevenue = prices[rodLength];

        // Try all possible cuts
        for (int cut = 1; cut < rodLength; cut++)
        {
            int revenue = CalculateRevenue(cut, prices) + CalculateRevenue(rodLength - cut, prices);

            if (revenue > maxRevenue)
                maxRevenue = revenue;
        }

        return maxRevenue;
    }
}

// Non-Optimized Strategy (Scenario C)
sealed class SimpleCutStrategy : CuttingStrategy
{
    public override int CalculateRevenue(int rodLength, int[] prices)
    {
        return prices[rodLength];
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

    public void UpdatePrice(int n, int newPrice)
    {
        prices[n] = newPrice;
    }
}
class MetalFactoryPipeCutting
{
    static void Main()
    {
        int rodLength = 8;

        int[] prices = { 0, 1, 5, 8, 9, 10, 17, 17, 20 };
        PriceChart chart = new PriceChart(prices);

        // Scenario A: optimized
        CuttingStrategy strategy = new RecursiveStrategy(); // upcasting
        int revA = strategy.CalculateRevenue(rodLength, chart.GetPrices());

        Console.WriteLine("Maximum Revenue (scenario-A)= " + revA);

        // Scenario B
        chart.UpdatePrice(3, 12);

        int revB = strategy.CalculateRevenue(rodLength, chart.GetPrices());

        Console.WriteLine("Maximum Revenue (scenario-B)= " + revB);

        // Scenario C: non-optimized
        strategy = new SimpleCutStrategy(); // polymorphism
        int recC = strategy.CalculateRevenue(rodLength, chart.GetPrices());

        Console.WriteLine("Revenue (scenario-C)= " + recC);
    }
}
