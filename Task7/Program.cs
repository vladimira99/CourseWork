using System;

namespace Task7
{
    class Program
    {  
      static void Main(string[] args)
            {
                double x;
                double y;
                Console.Write("Въведете x: ");
                Double.TryParse(Console.ReadLine(), out x);
                Console.Write("Въведете y: ");
                Double.TryParse(Console.ReadLine(), out y);

                Console.WriteLine("Число в интервала [{0},{1}] e: {2}", x, y, Program.Read(x, y).ToString("N2"));
                Console.ReadKey();
            }

            public static double Read(double x, double y)
            {
                if (y < x)
                {
                    if (x == 0)
                    {
                        return 0;
                    }
                    return x - (y / x);
                }
                if (y == 0)
                {
                    return 0;
                }

                return y - (x / y);
            }
        }
    }
