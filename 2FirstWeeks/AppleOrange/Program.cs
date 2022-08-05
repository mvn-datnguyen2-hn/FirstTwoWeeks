using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleOrange
{
    internal class Program
    {
        static void Main(string[] args)
        {
              void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
            {
                int appleCount = 0;
                int orangeCount = 0;
                //s là điểm đầu của ngôi nhà t là điểm cuối
                //a là vị trí cây táo,b là vị trí cây cam/
                
                for (int i = 0; i < apples.Count; i++)
                {
                    if ((a + apples[i]) >= s && (a + apples[i]) <= t)
                    {
                        appleCount++;
                    }
                }
                for (int i = 0; i < oranges.Count; i++)
                {
                    if ((b + oranges[i]) >= s && (b + oranges[i]) <= t)
                    {
                        orangeCount++;
                    }
                }
                Console.WriteLine(appleCount);
                Console.Write(orangeCount);
            }
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
