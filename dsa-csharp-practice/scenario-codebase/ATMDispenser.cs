using System;
public sealed class ATMDispenser
{
    private int[] denominations;
    // Constructor
    public ATMDispenser(int[] denominations)
    {
        this.denominations = denominations;
    }

    public Dictionary<int, int> Dispense(int amount)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();
        int remainingAmount = amount;

        for (int i = 0; i < denominations.Length; i++)
        {
            int note = denominations[i];
            if (remainingAmount >= note)
            {
                int count = remainingAmount / note;
                remainingAmount %= note;
                result[note] = count;
            }
        }

        // Scenario C: fallback
        if (remainingAmount != 0)
        {
            Console.WriteLine("Change not possible.");
            Console.WriteLine("Trying fallback\n");
            return DispenseFallback(amount);
        }

        return result;
    }
    private Dictionary<int, int> DispenseFallback(int amount)
    {
        while (amount > 0)
        {
            Dictionary<int, int> attempt = new Dictionary<int, int>();
            int remaining = amount;

            for (int i = 0; i < denominations.Length; i++)
            {
                int note = denominations[i];

                if (remaining >= note)
                {
                    int count = remaining / note;
                    remaining %= note;
                    attempt[note] = count;
                }
            }

            if (remaining == 0)
            {
                Console.WriteLine($"Dispensing nearest possible amount: ₹{amount}");
                return attempt;
            }

            amount--;
        }

        Console.WriteLine("No fallback possible.");
        return new Dictionary<int, int>();
    }

    // Display result
    public void Display(Dictionary<int, int> notes)
    {
        foreach (var entry in notes)
        {
            Console.WriteLine($"₹{entry.Key} x {entry.Value}");
        }
    }
    public static void Main()
    {
        // -------- Scenario A --------
        Console.WriteLine("Scenario A: Normal ATM (₹880)\n");

        int[] notesA = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        ATMDispenser atmA = new ATMDispenser(notesA);
        atmA.Display(atmA.Dispense(880));

        // -------- Scenario B --------
        Console.WriteLine("\nScenario B: ₹500 Removed\n");

        int[] notesB = { 200, 100, 50, 20, 10, 5, 2, 1 };
        ATMDispenser atmB = new ATMDispenser(notesB);
        atmB.Display(atmB.Dispense(880));

        // -------- Scenario C --------
        Console.WriteLine("\nScenario C: Exact Change Not Possible\n");

        int[] notesC = { 200, 100 };
        ATMDispenser atmC = new ATMDispenser(notesC);
        atmC.Display(atmC.Dispense(250));
    }
}
