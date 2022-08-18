using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    internal class Program
    {
        private static void plusMinus(List<int> arr)
        {
            decimal pos = arr.FindAll(c => c > 0).Count;
            decimal neg = arr.FindAll(c => c < 0).Count;
            decimal zero = arr.FindAll(c => c == 0).Count;

            Console.WriteLine((pos / arr.Count).ToString("N6"));
            Console.WriteLine((neg / arr.Count).ToString("N6"));
            Console.WriteLine((zero / arr.Count).ToString("N6"));
        }
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(ar);
        }
    }
}
