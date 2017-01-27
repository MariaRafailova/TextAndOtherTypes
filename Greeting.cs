using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public class Greeting
    {
        public static void Main()
        {
            string first = Console.ReadLine();
            string last = Console.ReadLine();
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);
            Console.WriteLine($"Hello, {first} {last}. \r\nYou are {age} years old.");
        }
    }
}
