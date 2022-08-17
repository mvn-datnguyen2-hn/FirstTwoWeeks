using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    internal class Program
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alicePoint = 0;
            int bobPoint = 0;
            List<int> result = new List<int>();
            Hashtable alice = new Hashtable();
            Hashtable bob = new Hashtable();
            for (int i = 0; i < a.Count; i++)
            {
                alice.Add($"{i}", a[i]);
                bob.Add($"{i}", b[i]);
                if (Convert.ToInt32(alice[$"{i}"]) > Convert.ToInt32(bob[$"{i}"]))
                {
                    alicePoint += 1;
                }
                if (Convert.ToInt32(alice[$"{i}"]) < Convert.ToInt32(bob[$"{i}"]))
                {
                    bobPoint += 1;
                }
            }
            result.Add(alicePoint);
            result.Add(bobPoint);
            return result;


        }
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
