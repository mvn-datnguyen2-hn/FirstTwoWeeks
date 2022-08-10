using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void plusMinus(List<int> arr)
            {
                decimal pos = 0;
                decimal neg = 0;
                decimal zero = 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] < 0)
                    {
                        neg += 1;
                    }
                    if (arr[i] > 0)
                    {
                        pos += 1;
                    }
                    if (arr[i] == 0)
                    {
                        zero += 1;
                    }
                }
                Console.WriteLine((pos / arr.Count).ToString("N6"));
                Console.WriteLine((neg / arr.Count).ToString("N6"));
                Console.WriteLine((zero / arr.Count).ToString("N6"));
            }
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(ar);
        }
    }
}
