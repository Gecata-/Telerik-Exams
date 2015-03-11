using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenDifferences02
{
    class EvenDifferences02
    {
        static void Main()
        {
            string input = Console.ReadLine();
            long sum = 0;
            var numbers = new List<long>(input.Split(' ').Select(long.Parse).ToList());

            for (int i = 1; i < numbers.Count;)
            {

                long index = AbsoluteDiffernce(numbers[i], numbers[i - 1]);

                if (index%2==0)
                {
                    sum += index;
                }
                if (index%2 == 0)
                {
                    i += 2;
                }
                if (index%2 !=0)
                {
                    i++;
                }
                
            }
            Console.WriteLine(sum);
        }

        static long AbsoluteDiffernce(long a, long b)
        {
            long max = Math.Max(a, b);
            long min = Math.Min(a, b);
            long result = max - min;
            return result;
        }
    }
}
