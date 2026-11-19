namespace csharp_opdracht5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengte;
            int breedte;
            int oppervlakte;
            Console.WriteLine("Wat is de lengte en breedte van de rechthoek?");
            lengte = int.Parse(Console.ReadLine());
            breedte = int.Parse(Console.ReadLine());
            oppervlakte = lengte * breedte;
            Console.WriteLine($"De lengte is {lengte} en de breedte is {breedte}");
            Console.WriteLine($"De oppervlakte is {oppervlakte}");
            Console.ReadLine();
        }
    }
}