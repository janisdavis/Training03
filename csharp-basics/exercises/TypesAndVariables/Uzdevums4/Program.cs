using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevums4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int yearOfBirth;

            Console.WriteLine("Enter name");
            name = Console.ReadLine();

            Console.WriteLine("Enter year of birth");
            int.TryParse(s: Console.ReadLine(), out yearOfBirth);

            Console.WriteLine($"My name is {name} and i was born in {yearOfBirth}");
            Console.ReadKey();
        }
    }
}
