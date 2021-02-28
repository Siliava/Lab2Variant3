using System;

namespace Lab2Variant3
{
    class Program
    {
        static double F (double x)
        {
            return ((2 * Math.Sin(2 / x)) / Math.Pow(x, 2)) + (2 * Math.Cos(1 / x) / Math.Pow(x, 2)) - 1 / Math.Pow(x, 2);
        }
        static double dF (double x)
        {
            return 2 * (2 * Math.Sin(2 / x) - 2 * Math.Cos(1 / x) + 1 + (Math.Sin(1 / x)) / x - 2 * Math.Cos(2 / x) / x) / Math.Pow(x, 3);
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            double X = random.Next(1, 2);
            double Xlast;
            double eps = 0.1;
            Console.WriteLine($"X0 = {X}");
            double dX = double.MaxValue;
            while (Math.Abs(dX) < eps)
            {
                Xlast = X;
                X -= F(Xlast) / dF(Xlast);
                dX = X - Xlast;
            }
            Console.WriteLine($"X = {X}");
            Console.WriteLine($"F(x) = {F(X)}");
            Console.ReadKey();
        }
    }
}
