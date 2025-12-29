using System;
class SnakeAndLadderGame
{
    private Random diceValue;
    private int[] start;
    private int[] end;
    private string[] players;
    private int[] positions;
    private int playersCount;

    public SnakeAndLadderGame()
    {
        diceValue = new Random();

        start = new int[] { 3, 8, 16, 19, 25, 43, 52, 57, 61, 66, 72, 88, 94, 97, 99 };
        end = new int[] {22,30,  6, 39, 78, 59, 68, 49, 19, 64, 91, 24, 74, 77, 80 };

        playersCount = TotalPlayers();
        players = new string[playersCount];
        positions = new int[playersCount];

        for (int i = 0; i < playersCount; i++)
        {
            Console.Write("Enter player name: ");
            players[i] = Console.ReadLine();
            positions[i] = 0;
        }
    }
    public void StartGame()
    {
        bool won = false;

        while (!won)
        {
            for (int i = 0; i < playersCount; i++)
            {
                bool turnOver = false;
                while (!turnOver)
                {
                    Console.WriteLine($"{players[i]}'s turn. Choose an option:");
                    Console.WriteLine("1. Roll Dice");
                    Console.WriteLine("2. Show Positions");
                    Console.WriteLine("3. Exit Game");
                    Console.Write("Enter choice: ");
                    string chooseOne = Console.ReadLine();

                    switch (chooseOne)
                    {
                        case "1":
                            int dice = RollDice();
                            Console.WriteLine("Dice rolled: " + dice);

                            int oldPos = positions[i];
                            int newPos = Move(oldPos, dice);

                            if (newPos == oldPos)
                                Console.WriteLine("Move skipped (exceeds 100)");
                            else
                            {
                                newPos = SnakeOrLadder(newPos);
                                positions[i] = newPos;
                                Console.WriteLine("Position: " + oldPos + " -> " + newPos);

                                if (CheckWin(newPos))
                                {
                                    Console.WriteLine(players[i] + " WINS!");
                                    won = true;
                                }
                            }
                            turnOver = true; // end turn after rolling dice -> only once per person
                            break;

                        case "2":
                            Console.WriteLine("Current Positions:");
                            for (int j = 0; j < playersCount; j++)
                                Console.WriteLine($"{players[j]}: {positions[j]}");
                            break;

                        case "3":
                            Console.WriteLine("Exiting game...");
                            return;     // to exit, getting out of the StartGame method

                        default:
                            Console.WriteLine("Invalid choice, try again.");
                            break;
                    }
                    if (won) break; // exit if someone has won in a turn
                }
                if (won) break; // stop game loop if a player wins
            }
        }
        Console.WriteLine("Game Over");
    }

    int RollDice()
    {
        return random.Next(1, 7);
    }

    int Move(int pos, int dice)
    {
        return pos + dice > 100 ? pos : pos + dice;
    }

    int SnakeOrLadder(int pos)
    {
        for (int i = 0; i < start.Length; i++)
        {
            if (pos == start[i])
            {
                if (end[i] > pos)
                    Console.WriteLine("Ladder found!");
                else
                    Console.WriteLine("Snake found!");
                return end[i];
            }
        }
        return pos;
    }

    bool CheckWin(int pos)
    {
        return pos == 100;
    }

    int TotalPlayers()
    {
        int count = 0;
        while (count < 2 || count > 4)
        {
            Console.Write("Enter number of players (2-4): ");
            count = int.Parse(Console.ReadLine());
        }
        return count;
    }
}

class SnakeAndLadder
{
    static void Main()
    {
        // this now ensures two separate games can be played independently
        // using static it would be impossible as static members are shared across instances
        SnakeAndLadderGame game1 = new SnakeAndLadderGame();
        SnakeAndLadderGame game2 = new SnakeAndLadderGame();

        game1.StartGame();
        game2.StartGame();
    }
}

