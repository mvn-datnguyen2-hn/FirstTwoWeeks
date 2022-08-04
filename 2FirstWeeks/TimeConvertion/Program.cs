using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConvertion
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string timeConversion(string s)
            {
                var amOrPm = s.Substring(8);
                var hour = s.Substring(0, 2);
                var minuteSecond = s.Substring(2, 6);
                if (amOrPm == "AM" && hour == "12")
                {
                    hour = "00";
                }
                else if (amOrPm == "PM")
                {
                    var numericHourComponent = int.Parse(hour);
                    if (numericHourComponent != 12)
                    {
                        hour = Convert.ToString(12 + numericHourComponent);
                    }
                }
                return (hour + minuteSecond);
            }
            string gio = Console.ReadLine();

            string result = timeConversion(gio);
        }
    }
}
