using Franquies_Multiplication_Game;
using System.Threading.Tasks.Sources;

internal class Program
{
    private static void Main(string[] args)
    {
        int score = 0;
        int atempts = 0;
        int faces = 0;

        string name = string.Empty;

        bool isGameOver = false;

        Die die;

        Console.Write("Vad heter du?: ");
        name = Console.ReadLine();
        Console.Write("Hur många sidor ska tärningarna ha?: ");
        bool isInt = Int32.TryParse(Console.ReadLine().Trim(), out faces);

        if (!isInt) faces = 6;

        die = new(faces);

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

            int num1 = die.Throw;
            int num2 = die.Throw;

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

        Console.WriteLine($"\nTack för att du spelade, {name}!");

        Console.ReadKey();
    }
}