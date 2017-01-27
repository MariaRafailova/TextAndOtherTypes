using System;

namespace SpecialNumbers
{
   public class SpecialNumbers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var currNum = i;
                var sum = 0;

                foreach (var symbol in currNum.ToString())
                {
                    var digit = symbol - '0';
                    sum += digit;
                }

                var result =
                    sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} -> {result}");
            }
        }
    }
}
