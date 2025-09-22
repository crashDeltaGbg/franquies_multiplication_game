using System.Threading.Tasks.Sources;

internal class Program
{
    private static void Main(string[] args)
    {
        int score = 0;
        int atempts = 0;

        bool isGameOver = false;
        static int RollDice()
        {
            return new Random().Next(6) + 1;
        }

        static bool CheckAnswer(int answer, int product)
        {
            return answer == product;
        }

        void Continue()
        {
            Console.WriteLine("Tryck på mellanslag för att fortsätta.");

            while (Console.ReadKey().Key != ConsoleKey.Spacebar) { }

            atempts++;
        }


        do
        {
            Console.Clear();

            Console.WriteLine("Svara 'stopp' för att avsluta.\n");

            string input;

            int num1 = RollDice();
            int num2 = RollDice();

            int product = num1 * num2;

            Console.WriteLine($"Vad blir {num1} * {num2}?");
            Console.Write("\nSvar: ");
            input = Console.ReadLine().Trim();

            if (input == "stopp") { isGameOver = true; }

            bool isNumber = int.TryParse(input, out int answer);

            if (isNumber)
            {
                if (CheckAnswer(answer, product))
                {
                    Console.WriteLine("\nKorrekt!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("\nDet var tyvärr inte rätt svar.\n");
                }

                Continue();
            }
            else if (input == "stopp")
            {
                isGameOver = true;
            }
            else
            {
                Console.WriteLine("\nSkrev du verkligen in ett nummer?\n");

                Continue();
            }
        } while (!isGameOver);

        Console.WriteLine($"\nDu fick {score} poäng på {atempts} försök.");

        Console.WriteLine("\nTack för att du spelade!");
    }
}