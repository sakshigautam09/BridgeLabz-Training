public class RailwayReservation
{
    private Passenger[] arr = new Passenger[10];
    private int count = 0;
    public void AddPassenger()
    {
        if (count >= arr.Length)
        {
            Console.WriteLine("Passenger array is full!");
            return;
        }

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter PNR Number: ");
        int pnr = int.Parse(Console.ReadLine());

        Passenger passenger;

        if (age >= 60)
            passenger = new SeniorPassenger();
        else
            passenger = new NormalPassenger();

        passenger.Name = name;
        passenger.Age = age;
        passenger.PNR = pnr;

        arr[count++] = passenger;
        Console.WriteLine("Passenger added successfully!");
    }

    public void DeletePassenger()
    {
        Console.Write("Enter PNR to delete: ");
        int pnr = int.Parse(Console.ReadLine());

        int index = -1;
        for (int i = 0; i < count; i++)
        {
            if (arr[i].PNR == pnr)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            for (int i = index; i < count - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[--count] = null;
            Console.WriteLine("Passenger deleted successfully!");
        }
        else
        {
            Console.WriteLine("Passenger not found.");
        }
    }
    public void DisplayAll()
    {
        if (count == 0)
        {
            Console.WriteLine("No arr available.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            arr[i].Display();
        }
    }
    // bubble sort 
    public void SortByPNR()
    {
        for(int i = 0; i < count - 1; i++)
        {
            for(int j = 0;j < count - i - 1; j++)
            {
                if(arr[j].PNR > arr[j+1].PNR)
                {
                    Passenger temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        Console.WriteLine("Array sorted!!");
    }
    // binary search on sorted array
    public void SearchByPNR()
    {
        Console.Write("Enter PNR to search: ");
        int key = int.Parse(Console.ReadLine());

        int left = 0;
        int right = count - 1;
        bool found = false;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid].PNR == key)
            {
                Console.WriteLine("Passenger found:");
                arr[mid].Display();
                found = true;
                break;
            }
            else if (arr[mid].PNR < key)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        if (!found){
            Console.WriteLine("Passenger not found.");
        }
    }

    public void SearchByName()
    {
        Console.Write("Enter Name to search: ");
        string name = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (arr[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                arr[i].Display();
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No passenger found with this name.");
    }
}