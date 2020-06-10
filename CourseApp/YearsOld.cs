using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class YearsOld
    {
        public static string Age(DateTime date)
        {
            return Age(date, DateTime.Now);
        }

        public static string Age(DateTime fromDate, DateTime toDate)
        {
            if (fromDate.Ticks < toDate.Ticks)
            {
                DateTime dateCompare = new DateTime(toDate.Ticks - fromDate.Ticks);
                return $"Вам {dateCompare.Year - 1} года(лет), {dateCompare.Month - 1} месяца(месяцев) и {dateCompare.Day - 1} дня(дней)";
            }

            throw new Exception();
        }

        public static DateTime YourAge()
        {
            int years = int.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            string result = Age(new DateTime(years, months, days), DateTime.Now);
            DateTime resultTime = DateTime.Parse(result);
            return resultTime;
        }
    }
}