﻿using System;
using System.Globalization;

namespace _01._1.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"d-M-yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);

        }
    }
}
