namespace csharp_opdracht12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("voer naam " + (i + 1) + " in:");
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("dit zijn uw namen:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}

