using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Name?");
            var name = Console.ReadLine(); 
            
            Console.WriteLine("How many hours of sleep did you get last night?");
            var hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            if (hoursOfSleep > 8)
            {
                Console.WriteLine("You are well rested");
            }
            else
            {
                Console.WriteLine("You need more Sleep.");
            }
        }
    }
}
