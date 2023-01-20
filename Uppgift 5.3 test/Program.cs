using System;
namespace Uppgift_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in 3 heltal");
            int tal = int.Parse(Console.ReadLine());
            string[] taler = new string[tal];

            for (int i = 0; i < tal; i++)
            {
                Console.WriteLine("Skriv in dina heltal");
                taler[i] = Console.ReadLine();
            }

            Console.WriteLine("Här är de talen du skrev in");
            for (int i = 0; i < tal; i++)
            {
                Console.WriteLine(taler[i]);
            }
        }
    }
}