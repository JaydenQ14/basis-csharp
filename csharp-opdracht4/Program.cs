namespace csharp_opdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal = 2;

            if (getal >= 1 && getal <= 5)
            {
                Console.WriteLine("Het getal is binnen bereik");
            }
            else
            {
                Console.WriteLine("Het getal is buiten bereik");
            }
        }
    }
}