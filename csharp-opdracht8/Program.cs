using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_opdracht8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gelukswoord = Console.ReadLine();
            gelukswoord = gelukswoord.ToUpper();
            Console.WriteLine(gelukswoord == "LUCKY" ? $"Je typte {gelukswoord} en dat is ... Correct!" :  $"Je typte {gelukswoord} en dat is ... Fout!");



        }
    }
}
