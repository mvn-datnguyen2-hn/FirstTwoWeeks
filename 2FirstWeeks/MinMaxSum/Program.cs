using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();


            long result = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                result += ar[i];
            }

            Console.Write("{0} {1}", result - ar.Max(), result - ar.Min());
        }
    }
}
