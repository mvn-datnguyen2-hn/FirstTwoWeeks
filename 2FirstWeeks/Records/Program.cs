using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{
    internal class Program
    {
        private static List<int> BreakingRecords(List<int> scores)
        {
            int win = 0;
            int lose = 0;
            int newRecord = 0;
            int low = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                if (i == 0)
                {
                    newRecord = scores[0];
                    low = scores[0];
                }
                else
                {
                    if (scores[i] > newRecord)
                    {
                        win++;
                        newRecord = scores[i];
                    }
                    if (scores[i] < low)
                    {
                        lose++;
                        low = scores[i];
                    }
                }
            }
            return new List<int>() { win, lose }; ;
        }
        static void Main(string[] args)
        {
             
              int n = Convert.ToInt32(Console.ReadLine().Trim());

              List<int> score = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

              List<int> result = BreakingRecords(score);

              Console.WriteLine(String.Join(" ", result));
        }
    }
}
