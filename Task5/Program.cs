using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете координати на т.А");
            Console.Write("x:");
            double xA = double.Parse(Console.ReadLine());
            Console.Write("y:");
            double yA = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете координати на т.B");
            Console.Write("x:");
            double xB = double.Parse(Console.ReadLine());
            Console.Write("y:");
            double yB = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете координати на т.C");
            Console.Write("x:");
            double xC = double.Parse(Console.ReadLine());
            Console.Write("y:");
            double yC = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете координати на т.D");
            Console.Write("x:");
            double xD = double.Parse(Console.ReadLine());
            Console.Write("y:");
            double yD = double.Parse(Console.ReadLine());

            double a = Math.Sqrt(Math.Pow((yB - yA), 2) + Math.Pow((xB - xA), 2));
            double b = Math.Sqrt(Math.Pow((yC - yB), 2) + Math.Pow((xC - xB), 2));
            double c = Math.Sqrt(Math.Pow((yD - yC), 2) + Math.Pow((xD - xC), 2));
            double d = Math.Sqrt(Math.Pow((yA - yD), 2) + Math.Pow((xA - xD), 2));

            double p = (a + b + c + d) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c) * (p - d));

            Console.WriteLine($"S = {S}");

            Console.WriteLine("-------------------");
            Console.Write("Въведете а:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Въведете b:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Въведете c:");
            c = double.Parse(Console.ReadLine());
            Console.Write("Въведете d:");
            d = double.Parse(Console.ReadLine());
            Console.Write("Въведете d1:");
            double d1 = double.Parse(Console.ReadLine());
            double p1 = (a + b + d1) / 2;
            double firstTriangleS = Math.Sqrt(p * (p - a) * (p - b) * (p - d1));
            double p2 = (c + d + d1) / 2;
            double secondTriangleS = Math.Sqrt(p * (p - c) * (p - d) * (p - d1));
            double finalS = firstTriangleS + secondTriangleS;
            Console.WriteLine($"S = {finalS}");
        }
    }
}

