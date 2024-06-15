namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int winningNum = random.Next(0, 100);
            bool win = false;

            do
            {
                Console.WriteLine("Guess a random number between 1 and 100: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess > winningNum)
                {
                    Console.WriteLine("Too high, try again.");
                }
                else if (guess < winningNum)
                {
                    Console.WriteLine("Too low, try again.");
                }
                else
                {
                    guess = winningNum;
                    Console.WriteLine("Congratulations, you guessed correctly!!!");
                    win = true;
                }
                Console.WriteLine();
            }
            while (win == false);

            Console.WriteLine("Press any key to close the game.");
        }
    }
}