class Program
{
    static void Main()
    {
        Console.Write("Enter roundabout capacity: ");
        int roundaboutSize = int.Parse(Console.ReadLine());

        Console.Write("Enter waiting queue size: ");
        int queueSize = int.Parse(Console.ReadLine());

        TrafficManager manager = new TrafficManager(roundaboutSize, queueSize);

        while (true)
        {
            Console.WriteLine("\n1. Vehicle Arrives");
            Console.WriteLine("2. Vehicle Exits");
            Console.WriteLine("3. Show Roundabout");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            int chooseOption = int.Parse(Console.ReadLine());

            switch (chooseOption)
            {
                case 1:
                    Console.Write("Enter vehicle number: ");
                    int number = int.Parse(Console.ReadLine());
                    manager.VehicleArrives(number);
                    break;

                case 2:
                    manager.VehicleExits();
                    break;

                case 3:
                    manager.ShowStatus();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
