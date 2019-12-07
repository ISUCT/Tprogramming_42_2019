﻿using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class Program
    {
        public static double Equat(double a, double b, double x)
        {
            return ((a * Math.Sqrt(x)) - (b * Math.Log(x, 5))) / Math.Log10(Math.Abs(x - 1));
        }

        public static List<double> TaskA(double a, double b, double xn, double xk, double dx)
        {
            if (xk < xn)
            {
                return new List<double>();
            }
            else
            {
                List<double> rtrn = new List<double>();
                for (double x = xn; x < (xk + 0.1); x += dx)
                {
                    rtrn.Add(Equat(a, b, x));
                }

                return rtrn;
            }
        }

        public static List<double> TaskB(double a, double b, List<double> xm)
        {
            List<double> rtrn = new List<double>();
            foreach (double item in xm)
            {
                rtrn.Add(Equat(a, b, item));
            }

            return rtrn;
        }

        public static void Main(string[] args)
        {
            double a = 4.1;
            double b = 2.7;
            List<double> mass = TaskA(a, b, 1.2, 5.2, 0.8);
            foreach (var item in mass)
            {
                Console.WriteLine(item);
            }

            List<double> mass2 = new List<double>() { 1.9, 2.15, 2.34, 2.73, 3.16 };
            mass2 = TaskB(a, b, mass2);
            foreach (var item in mass2)
            {
                Console.WriteLine(item);
            }

            Person[] masss = new Person[2];
            masss[0] = new Student(18, "Vasya", "Ivanov");
            masss[1] = new Employee(35, "Vasiliy", "Petrov");
            foreach (var item in masss)
            {
                Console.WriteLine(item.Relax());
            }

            Console.WriteLine(MyAge());
            Console.ReadKey();
        }

        public static string MyAge()
        {
            Console.WriteLine("Введите год своего рождения:");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц своего рождения:");
            int months = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите день своего рождения:");
            int days = int.Parse(Console.ReadLine());
            DateTime dayOfBirth = new DateTime(years, months, days);
            DateTime result = new DateTime(DateTime.Now.Ticks - dayOfBirth.Ticks);
            return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 1} дня";
        }

        public static string MyAge(int y, int m, int d)
        {
            DateTime dayOfBirth = new DateTime(y, m, d);
            if (dayOfBirth.Ticks < DateTime.Now.Ticks)
            {
                DateTime result = new DateTime(DateTime.Now.Ticks - dayOfBirth.Ticks);
                return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 1} дня";
            }

            throw new AgeException("Вы ещё не родились, ожидайте");
        }

        public static string MyAge(DateTime date)
        {
            if (date.Ticks < DateTime.Now.Ticks)
            {
                DateTime result = new DateTime(DateTime.Now.Ticks - date.Ticks);
                return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 1} дня";
            }

            throw new AgeException("Вы ещё не родились, ожидайте");
        }
    }
}
