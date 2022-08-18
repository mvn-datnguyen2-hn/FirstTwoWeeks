using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLineJumps
{
    internal class Program
    {
        private static string Kangaroo(long x1, long v1, long x2, long v2)
        {
            string a;
            if ((x1 < x2 && v1 < v2) || (x2 < x1 && v2 < v1))//ở xa hơn,tốc độ kém hơn => k thể kịp
            {
                return "NO";
            }
            //ở xa hơn nhưng chỉ cần tốc độ cao hơn => chắc chắn sẽ kịp
            var numberOfJumps = Math.Abs(((double)(x1 - x2)) / (v2 - v1));

            if (numberOfJumps % 1 == 0)
                a = "YES";
            else
            {
                a = "NO";
            }
            return a;

        }
        static void Main(string[] args)
        {
              
              string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

              long xO = Convert.ToInt32(firstMultipleInput[0]);

              long vO = Convert.ToInt32(firstMultipleInput[1]);

              long xT = Convert.ToInt32(firstMultipleInput[2]);

              long vT = Convert.ToInt32(firstMultipleInput[3]);

              string result = Kangaroo(xO, vO, xT, vT);
        }
    }
}
