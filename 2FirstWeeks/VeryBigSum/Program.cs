using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryBigSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long aVeryBigSum(int n, List<long> arr)
            {
                long finalSum = 0;
                for (int i = 0; i < n; i++)
                {
                    finalSum += arr[i];
                }
                return finalSum;
            }
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();
            long result = aVeryBigSum(arCount, ar);
            Console.WriteLine(result);
        }
    }
}
