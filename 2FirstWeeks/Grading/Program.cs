using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading
{
    internal class Program
    {
        static void Main(string[] args)
        {
              List<int> GradingStudents(List<int> grade)
            {
                for (int i = 0; i < grade.Count; i++)
                {
                    if (grade[i] != 100 && grade[i] >= 38)
                    {
                        if (grade[i] == 38)
                        {
                            grade[i] += 2;
                        }
                        if (grade[i] > 38)
                        {
                            int a = Convert.ToInt32(grade[i].ToString().Substring(0, 1));
                            int b = Convert.ToInt32(grade[i].ToString().Substring(1, 1));
                            if (b > 2 && b < 5)
                            {
                                b = 5;
                                grade[i] = Convert.ToInt32(a.ToString() + b.ToString());
                            }
                            if (b > 7)
                            {
                                a += 1;
                                b = 0;
                                grade[i] = Convert.ToInt32(a.ToString() + b.ToString());
                            }
                        }
                    }
                }
                return grade;
            }
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
