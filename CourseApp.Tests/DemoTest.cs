using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            Xunit.Assert.True(true);
        }

        [Fact]
        public void TestMyFunctionZeros()
        {
            var res = Program.MyFunction(0.0, 0.0);
            Xunit.Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void TestMyFunctionNonZeros()
        {
            double test = 1.52287874528034;
            var res = Program.MyFunction(1, 2);
            Xunit.Assert.Equal(test, res, 1);

            /* Хотел бы воспользоваться помощью!
            Когда в этом тесте пишу вместо 1, 2 в функции
            MyFuncion(5, 6), то ответ получается 2.91038304567337E+24
            И AssertEqual не работает ни с каким указанием точности,
            указывая, что значения не одинаковы, даже если просто списать его
            для проверки
            В чём дело? Слишком большое число? Или те самые проблемы языков с плавающей точкой?
            */
        }

        [Fact]
        public void TestTaskBNullMass()
        {
            List<double> mass = new List<double>();
            var res = Program.TaskB(1, mass);
            Xunit.Assert.Equal(mass, res);
        }

        [Fact]
        public void TestTaskB()
        {
            List<double> x = new List<double> { 1.28, 1.36, 2.47, 3.68, 4.56 };
            var res = Program.TaskB(1.6, x);
            List<double> expy = new List<double> { 2.54483385166692, 2.5615887682505, 11.2873629585646, 363.108837198182, 10971.2863691829 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }

        [Fact]
        public void TestTaskA0()
        {
            double a = 1.6;
            double xn = 1.2;
            double xk = 3.7;
            double dx = 0.5;
            var res = Program.TaskA(a, xn, xk, dx);
            List<double> expy = new List<double> { 2.58628588710697, 3.15454831838707, 6.49450906742811, 19.428489457705, 76.9595290357977 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }

        [Fact]
        public void TestTaskA1()
        {
            double a = 1.6;
            double xn = 1.2;
            double xk = 3.7;
            double dx = 0.5;
            var res = Program.TaskA(a, xn, xk, dx);
            List<double> expy = new List<double> { 2.58628588710697, 3.15454831838707, 6.49450906742811, 19.428489457705, 76.9595290357977 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }

        [Fact]
        public void TestTaskA2()
        {
            double a = 1.6;
            double xn = 1.2;
            double xk = 3.7;
            double dx = 0.5;
            var res = Program.TaskA(a, xn, xk, dx);
            List<double> expy = new List<double> { 2.58628588710697, 3.15454831838707, 6.49450906742811, 19.428489457705, 76.9595290357977 };
            for (int i = 0; i < 5; i++)
            {
                Xunit.Assert.Equal(expy[i], res[i], 3);
            }
        }
    }
}
