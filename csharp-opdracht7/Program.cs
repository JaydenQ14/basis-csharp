namespace csharp_opdracht7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo toets = Console.ReadKey();
            Console.WriteLine();
           
            if (toets.Key == ConsoleKey.D5)
            {
                Console.WriteLine("Correct! Mijn geluksgetal is 5!");
            }
            else if (toets.Key == ConsoleKey.D1 || toets.Key == ConsoleKey.D2 || toets.Key == ConsoleKey.D3 || toets.Key == ConsoleKey.D4 || toets.Key == ConsoleKey.D6 || toets.Key == ConsoleKey.D7 || toets.Key == ConsoleKey.D8 || toets.Key == ConsoleKey.D9)
            {
                Console.WriteLine($"{toets.Key} is niet juist.");
            }
            else
            {
                Console.WriteLine($" {toets.Key} is niet juist. Voer een cijfer in.");
            }

        }
    }
    } 

          


 