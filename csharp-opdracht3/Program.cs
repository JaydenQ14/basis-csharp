namespace csharp_opdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoer = "42";
            int getal = int.Parse(invoer);
            int resultaat = getal * 2;
            Console.WriteLine($"Het dubbele is: {resultaat}"); // het verandert de string in een int en verdubbelt het getal
            Console.ReadLine();
        }
    }
}
