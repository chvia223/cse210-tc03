using System;

namespace cse210_tc03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our collaborative program.");
            DisplayGreetingAvila();
            DisplayGreetingViazzo();
            DisplayGreetingSkalka();
            DisplayGreetingRoskelley();
        }
        static void DisplayGreetingAvila()
        {
            Console.WriteLine("Hello from Josue Avila.");
        }
        static void DisplayGreetingViazzo()
        {
            Console.WriteLine("Hello from Christian Viazzo.");
        }
        static void DisplayGreetingSkalka()
        {
            Console.WriteLine("Hello from Tyler Skalka");
        }
          static void DisplayGreetingRoskelley()
        {
            Console.WriteLine("Hello from Brighton Roskelley.");
        }
    }
}
