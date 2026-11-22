namespace csharp_opdracht11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean run = true;

            while (run == true)
            {
                ConsoleKeyInfo toets = Console.ReadKey();
                Console.WriteLine();

                if (toets.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Menu 1");
                }
                else if (toets.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Menu 2");
                }
                else if (toets.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("programma sluit af");
                    run = false;
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze. Voer 1, 2 of 3 in");
                }
            }
        }
    }
}
