using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Data
    {
        public static DateTime SetDate()
        {
            Console.WriteLine("День:");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Месяц:");
            int mounth = int.Parse(Console.ReadLine());
            Console.WriteLine("Год:");
            int year = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, mounth, day);
            return date;
        }

        public static string Age(DateTime birthday, DateTime timeNow)
        {
            DateTime age = Inequality(birthday, timeNow);
            if (age.Day - 1 == 0 && age.Month - 1 == 0 && age.Year - 1 == 0)
            {
                return $"congratulations you are born";
            }

            return $"Вам {age.Day - 1} дня,{age.Month - 1} месяцев, {age.Year - 1} лет";
        }

        public static DateTime Inequality(DateTime date1, DateTime date2)
        {
            if (date1.Ticks <= date2.Ticks)
            {
                DateTime age = new DateTime(date2.Ticks - date1.Ticks);
                return age;
            }

            throw new Exception();
        }
    }
}