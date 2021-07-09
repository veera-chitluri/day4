using System;

namespace country
{
    class Program
    {
        private static string india;

        static void Main(string[] args)
        {
            Console.WriteLine($"Enter country name:");
            var country = Console.ReadLine();

            Console.WriteLine($"Enter state name:");
            var state = Console.ReadLine();
            if (country == "india")
            {
              if (state == "kerala")
            }
             Console.WriteLine(true);
             else {
                 Console.WriteLine(false); 
             }


        }
    }
}
