using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете Х:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете У:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Въведете z:");
            double z = double.Parse(Console.ReadLine());
            double res = Math.Pow(x + 2, (Math.Pow(y + 1, z)));
            Console.WriteLine(res);
        }
    }
}
