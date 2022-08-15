using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifferent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diagonalDifference(List<List<int>> arr)
            {

                int sumL = 0;
                int sumR = 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    sumL += arr[i][i];
                    sumR += arr[i][arr.Count - i - 1];
                }
                return Math.Abs(sumL - sumR);
            }
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> ar = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                ar.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(ar);
            Console.WriteLine(result);
        }
    }
}
