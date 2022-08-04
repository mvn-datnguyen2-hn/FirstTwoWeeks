using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());
            int candle = 0;

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            int max = ar.Max();
            for (int i = 0; i < arCount; i++)
            {
                if (ar[i] == max)
                {
                    candle++;
                }
            }
            Console.WriteLine(candle);
        }
    }
}
