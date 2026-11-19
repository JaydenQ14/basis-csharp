namespace csharp_opdracht6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je geboortejaar?");
            int year = int.Parse(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            int age = currentYear - year;
            Console.WriteLine($"Je bent {age} jaar oud.");
           
        }
    }
}
