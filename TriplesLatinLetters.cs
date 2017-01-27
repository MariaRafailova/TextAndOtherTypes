using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesLatinLetters
{
    public class TriplesLatinLetters
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i =0; i<n; i++)
            {
                for (int j = 0; j<n; j++)
                {
                    for (int k = 0; k<n; k++)
                    {
                        var first = (char)(i + 'a');
                        var second = (char)(j + 'a');
                        var third = (char)(k + 'a');

                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
