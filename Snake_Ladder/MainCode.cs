namespace SnakeAndLadder
{
    class MainCode
    {
        static void Main(string[] args)
        {
            int playerPosition = 0;

            Console.WriteLine("Welcome to the Snake and Ladder game!");
            Console.WriteLine($"You are starting at position {playerPosition}.");
            Random random = new Random();

            Console.WriteLine("\nPress Enter to roll the dice...");
            Console.ReadLine();

            int diceRoll = random.Next(1, 7);
            Console.WriteLine($"You rolled a {diceRoll}.");

            int option = random.Next(0, 3);

            switch (option)
            {
                case 0: // No Play
                    Console.WriteLine("No Play. You stay in the same position.");
                    break;
                case 1: // Ladder
                    playerPosition += diceRoll;
                    Console.WriteLine($"Ladder! You move ahead by {diceRoll} positions to {playerPosition}.");
                    break;
                case 2: // Snake
                    playerPosition -= diceRoll;
                    if (playerPosition < 0)
                        playerPosition = 0; // Ensure position doesn't go negative
                    Console.WriteLine($"Snake! You move back by {diceRoll} positions to {playerPosition}.");
                    break;
            }


        }
    }
}
