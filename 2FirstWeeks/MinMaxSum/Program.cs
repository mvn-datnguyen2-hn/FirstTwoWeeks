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

            long Max = 0;
            long Min = 0;
            if (ar.Min() != ar.Max())
            {
                for (int i = 1; i < ar.Count; i++)
                {
                    Min = Max += ar.Min();
                }
            }
            for (int i = 0; i < ar.Count; i++)
            {
                if (ar[i] != ar.Min())
                {
                    Max += ar[i];
                }
                if (ar[i] != ar.Max())
                {
                    Min += ar[i];
                }
            }
            Console.Write(Min + " " + Max);
        }
    }
}
