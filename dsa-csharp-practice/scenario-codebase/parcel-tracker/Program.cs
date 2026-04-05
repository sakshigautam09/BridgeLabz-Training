class Program
{
    static void Main()
    {
        ParcelTracker tracker = new ParcelTracker();

        while (true)
        {
            Console.WriteLine("\n--- Parcel Tracker Menu ---");
            Console.WriteLine("1. Add Stage");
            Console.WriteLine("2. Insert Checkpoint");
            Console.WriteLine("3. Remove Stage");
            Console.WriteLine("4. Track Parcel");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();
            int choice;

            if (choice == 0)
            {
                Console.WriteLine("Exiting Parcel Tracker.");
                break;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter stage name to add: ");
                    string stage = Console.ReadLine();
                    tracker.AddStage(stage);
                    break;

                case 2:
                    Console.Write("Enter the stage after which to insert checkpoint: ");
                    string afterStage = Console.ReadLine();
                    Console.Write("Enter checkpoint name: ");
                    string checkpoint = Console.ReadLine();
                    tracker.InsertCheckpoint(afterStage, checkpoint);
                    break;

                case 3:
                    Console.Write("Enter stage name to remove: ");
                    string removeStage = Console.ReadLine();
                    tracker.RemoveStage(removeStage);
                    break;

                case 4:
                    tracker.TrackParcel();
                    break;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }
}