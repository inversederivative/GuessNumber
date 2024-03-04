// 1. Generate a random number
// 2. Give the user a number of tries (statically defined)
// 3. In a while loop, ask the user to guess


namespace GuessingGame
{
    class GuessNumber
    {
        int GenerateNumber()
        {
            Random rnd = new Random();
            return rnd.Next(0, 10);
        }

        int GenerateNumber(int maxVal)
        {
            Random rnd = new Random();
            return rnd.Next(0, maxVal);
        }

        public static int Main(String[] args)
        {
            // Generate Number
            GuessNumber gn = new GuessNumber();
            int Number = gn.GenerateNumber();

            int NumOfTries = 3;

            Console.WriteLine("Welcone to the Guessing Game!");
            Console.WriteLine("Please guess a number from 0-10");

            while (NumOfTries > 0)
            {
                // Get User's Guess
                int Guess = Convert.ToInt32(Console.ReadLine());

                if (Number == Guess)
                {
                    Console.WriteLine("Well Done! You Guessed Correctly!");
                    return 0;
                }
                else if (NumOfTries != 1)
                {
                    NumOfTries--;
                    Console.WriteLine("Sorry, you guessed wrong. You have " + NumOfTries + " tries left.");
                }
                else
                {
                    NumOfTries--;
                    Console.WriteLine("Maximum Number of tries guessed...");
                }
            }
            Console.WriteLine("The number was: " + Number);
            return 1;
        }
    }
}