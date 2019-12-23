﻿using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class AgeC
    {
        public static DateTime ConsoleInputData()
        {
            Console.WriteLine("Напиши год своего рождения:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напиши месяц своего рождения:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напиши день своего рождения:");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime res = DatComp(new DateTime(year, month, day), DateTime.Now);
            return res;
        }

        public static DateTime DatComp(DateTime dat1, DateTime dat2)
        {
            if (dat1.Ticks < dat2.Ticks)
            {
                DateTime res = new DateTime(dat2.Ticks - dat1.Ticks);
                return res;
            }

            throw new Exception();
        }

        public static string Age(DateTime fromDate, DateTime toDate)
        {
            var dateCompar = DateCompare(fromDate, toDate);
            return $"Вам {dateCompar.Year - 1} лет, {dateCompar.Month - 1} месяцев и {dateCompar.Day - 1} дня";
        }

        public static string Age(DateTime dat)
        {
            return Age(dat, DateTime.Now);
        }
    }
}
