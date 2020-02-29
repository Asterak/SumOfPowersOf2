using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Powers(8)));

            Console.WriteLine(string.Join(" ", Powers(1)));
            Console.WriteLine(string.Join(" ", Powers(2)));
            Console.WriteLine(string.Join(" ", Powers(6)));

            Console.WriteLine(string.Join(" ", Powers(int.MaxValue)));
        }

        public static int[] Powers(int n)
        {
            List<int> result = new List<int>();

            if (n % 2 != 0)
            {
                n--;
                result.Add(1);
            }

            int power = 0;
            while (n != 0)
            {
                power = (int)Math.Pow(2, (int)Math.Log(n, 2));
                result.Add(power);
                n -= power;
            }
            result.Sort();
            return result.ToArray();
        }
    }
}
