using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading
{
    internal class Program
    {
        private static List<int> GradingStudents(List<int> grade)
        {
            for (int i = 0; i < grade.Count; i++)
            {
                int item = grade[i];
                if (item >= 38)
                {
                    int diff = 5 - (item % 5);
                    if (diff < 3)
                    {
                        grade[i] = item + diff;
                    }
                }
            }
            return grade;
        }
        static void Main(string[] args)
        {
              
              int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

              List<int> grades = new List<int>();

              for (int i = 0; i < gradesCount; i++)
              {
                  int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                  grades.Add(gradesItem);
              }

              List<int> result = GradingStudents(grades);
            Console.WriteLine("-----------------------");
              Console.WriteLine(String.Join("\n", result));
        }
    }
}
