using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleOrange
{
    internal class Program
    {
        private static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appleCount = apples.Where(c => c + a >= s && c + a <= t).Count();
            int orangeCount = oranges.Where(c => c + b >= s && c + b <= t).Count();
            Console.WriteLine(appleCount);
            Console.Write(orangeCount);
        }
        static void Main(string[] args)
        {
              
              string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

              int s1 = Convert.ToInt32(firstMultipleInput[0]);

              int t1 = Convert.ToInt32(firstMultipleInput[1]);

              string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

              int a1 = Convert.ToInt32(secondMultipleInput[0]);

              int b1 = Convert.ToInt32(secondMultipleInput[1]);

              string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

              int m = Convert.ToInt32(thirdMultipleInput[0]);

              int n = Convert.ToInt32(thirdMultipleInput[1]);

              List<int> apple = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

              List<int> orange = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

              countApplesAndOranges(s1, t1, a1, b1, apple, orange);
        }
    }
}
