using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Initialize the game with the player at starting position 0
            int playerPosition = 0;
            const int winningPosition = 100;
            Random random = new Random();

            Console.WriteLine("Welcome to the Snake and Ladder game!");
            Console.WriteLine($"You are starting at position {playerPosition}.");

            
            while (playerPosition < winningPosition)
            {
                Console.WriteLine("\nPress Enter to roll the dice...");
                Console.ReadLine();

                int diceRoll = random.Next(1, 7); 
                Console.WriteLine($"You rolled a {diceRoll}.");

                // Step 3: Check for Options - No Play, Ladder, or Snake
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
                        if (playerPosition < 0) playerPosition = 0; 
                        Console.WriteLine($"Snake! You move back by {diceRoll} positions to {playerPosition}.");
                        break;
                }

                Console.WriteLine($"You are now on position {playerPosition}.");

                // Check if the player has won
                if (playerPosition >= winningPosition)
                {
                    Console.WriteLine("Congratulations! You have won the game!");
                }
            }
        }
    }
}
