using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] powers = new int[] { 0, 1, 32, 243, 1024, 3125, 7776, 16807, 32768, 59049 };

            List<int> results = new List<int>();

            //Sum of powers of 5 of 99999 is still higher than the number itself, but that
            //is no longer true at 999 999. Limit is then set arbitrarily between the 2, a little higher
            //than the sum for 99 999
            foreach(int n in Enumerable.Range(2, 300000))
            {
                int sum = 0;
                int i = n;
                while(i > 0)
                {
                    sum += powers[i % 10];
                    i = i / 10;
                }
                if (sum == n)
                    results.Add(n);
            }

            Console.WriteLine(results.Sum());
            Console.ReadLine();
        }
    }
}
