namespace csharp_opdracht9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is uw gewenste drankmaat? small, medium of large");
            string keuze = Console.ReadLine().ToLower();
            switch (keuze)
            {
                case "small":
                    Console.WriteLine("2,00");
                    break;
                case "medium":
                    Console.WriteLine("2,50");
                    break;
                case "large":
                    Console.WriteLine("3,00");
                    break;
                default:
                    Console.WriteLine("ongeldige keuze");
                    break;
            }
            Console.ReadLine();
        }
    }
}
