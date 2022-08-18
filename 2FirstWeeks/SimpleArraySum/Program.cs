using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    internal class Program
    {
        private static int simpleArraySum(int n, List<int> arr)
        {
            int Sum = 0;
            for (int i = 0; i < n; i++)
            {
                Sum += arr[i];
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
            long result = simpleArraySum(arCount, ar);
            Console.WriteLine("Sum: ", result);
        }
    }
}
