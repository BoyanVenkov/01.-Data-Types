using System;

namespace TestApp
{
    public class LongerLine
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        public static void PrintLongerLine(double x1, double y1, double x2, double y2,
                                           double x3, double y3, double x4, double y4)
        {
            double firstLine = GetLineLength(x1, y1, x2, y2);
            double secondLine = GetLineLength(x3, y3, x4, y4);

            if (firstLine >= secondLine)
            {
                PrintCloserToCenterFirst(x1, y1, x2, y2);
            }
            else
            {
                PrintCloserToCenterFirst(x3, y3, x4, y4);
            }
        }

        private static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double sideX = x1 - x2;
            double sideY = y1 - y2;
            return Math.Sqrt(sideX * sideX + sideY * sideY);
        }

        private static void PrintCloserToCenterFirst(double x1, double y1, double x2, double y2)
        {
            double firstToCenter = GetDistanceToCenter(x1, y1);
            double secondToCenter = GetDistanceToCenter(x2, y2);

            if (firstToCenter <= secondToCenter)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        private static double GetDistanceToCenter(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}