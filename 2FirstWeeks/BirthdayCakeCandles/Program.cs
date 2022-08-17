﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    internal class Program
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            int candle = candles.FindAll(c => c == max).Count;
            return candle;
        }
        static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = birthdayCakeCandles(candles);

            Console.WriteLine(result);
        }
    }
}
