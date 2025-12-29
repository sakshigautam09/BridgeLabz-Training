using System;

class SnakeAndLadder
{
    static Random random = new Random();
    // Snake and Ladder positions
    static int[] start = { 3, 8, 16, 19, 25, 43, 52, 57, 61, 66, 72, 88, 94, 97, 99 };
    static int[] end   = {22, 30,  6, 39, 78, 59, 68, 49, 19, 64, 91, 24, 74, 77, 80 }; 

    static void Main()
    {
        Console.WriteLine("Snake and Ladder Game");

        int playersCount = TotalPlayers();
        // Initialize players and their positions
        string[] players = new string[playersCount];
        int[] positions = new int[playersCount];

        for (int i = 0; i < playersCount; i++)
        {
            Console.Write("Enter name of Player: ");
            players[i] = Console.ReadLine();
            positions[i] = 0;
        }

        bool won = false;

        while (!won)
        {
            for (int i = 0; i < playersCount; i++)
            {
                Console.WriteLine($"\n{players[i]}'s turn.");
                bool turnOver = false;  // Flag to check if turn is over

                while (!turnOver)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1. Roll Dice");
                    Console.WriteLine("2. Show Positions");
                    Console.WriteLine("3. Exit Game");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            int dice = RollDice();
                            Console.WriteLine($"Dice rolled: {dice}");

                            int oldPos = positions[i];
                            int newPos = Move(oldPos, dice);

                            if (newPos == oldPos)
                            {
                                Console.WriteLine("Move skipped (exceeds 100)");
                            }
                            else
                            {
                                newPos = SnakeOrLadder(newPos);
                                positions[i] = newPos;
                                Console.WriteLine($"Position: {oldPos} -> {newPos}");

                                if (CheckWin(newPos))
                                {
                                    Console.WriteLine($"\n{players[i]} wins the game!");
                                    won = true;
                                }
                            }
                            turnOver = true; // End turn after rolling dice
                            break;

                        case "2":
                            Console.WriteLine("Current Positions:");
                            for (int j = 0; j < playersCount; j++)
                                Console.WriteLine($"{players[j]}: {positions[j]}");
                            break;

                        case "3":
                            Console.WriteLine("Exiting game...");
                            return;

                        default:
                            Console.WriteLine("Invalid option! Try again.");
                            break;
                    }

                    if (won) break; // Exit if someone has won (for turn)
                }

                if (won) break; // Exit if someone has won (for final win inside while)
            }
        }
        Console.WriteLine("Game Over");
    }

    static int TotalPlayers()
    {
        int count = 0;
        while (count < 2 || count > 4)
        {
            Console.Write("Enter number of players (2 to 4): ");
            count = int.Parse(Console.ReadLine());
        }
        return count;
    }

    static int RollDice()
    {
        return random.Next(1, 7);
    }

    static int Move(int position, int dice)
    {
        int nextPos = position + dice;
        return nextPos > 100 ? position : nextPos;  
    }

    static int SnakeOrLadder(int position)
    {
        for (int i = 0; i < start.Length; i++)
        {
            if (position == start[i])
            {
                if (end[i] > position)
                    Console.WriteLine("Ladder found!");
                else
                    Console.WriteLine("Snake found!");
                return end[i];
            }
        }
        return position;
    }

    static bool CheckWin(int position)
    {
        return position == 100;
    }
}
