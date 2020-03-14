using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string country;
            do
            {
                Console.WriteLine("Please Enter Your Name");
                name = Console.ReadLine();
            }
            while (!Regex.IsMatch(name, "^[a-z A-Z]+$"));
            Console.WriteLine("Please Enter Your Country");
            country = Console.ReadLine();

            Console.WriteLine("Helloo "+name+" From Country "+country);
            Console.Read();
        }
    }
}
