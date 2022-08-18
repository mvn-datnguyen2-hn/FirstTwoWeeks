using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayBar
{
    internal class Program
    {
        private static int BirthDay(List<int> s, int d, int m)
        {
            int count = 0;
            for (int i = 0; i < s.Count; i++)
            {
                int a = 0;
                for (int j = 0; j < m; j++)
                {
                    a += s[i];
                    i++;
                }
                if (a == d)
                {
                    count++;
                }
                for (int k = 0; k < m; k++)
                {
                    if (i != s.Count)
                    {
                        i--;
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s1 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d1 = Convert.ToInt32(firstMultipleInput[0]);

            int m1 = Convert.ToInt32(firstMultipleInput[1]);

            int result = BirthDay(s1, d1, m1);

            Console.WriteLine(result);
        }
    }
}
