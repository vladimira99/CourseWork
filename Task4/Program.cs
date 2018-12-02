using System;

namespace Task4
{ 
 class Program
{
    static void Main(string[] args)
    {
        Program.uslivieA();
        Program.uslivieB();
        Program.uslivieV();
        Program.uslivieG();
        Program.uslivieD();
        Program.uslivieE();
        Program.uslivieJ();
        Console.ReadKey();
    }

    public static void uslivieA()
    {
        int sum = 1;
        int i = 3;
        do
        {
            sum += i;
            i += 2;
        }
        while (i < 50);
        Console.WriteLine("A) Сумата на редицата е: {0}", sum);

    }

    public static void uslivieB()
    {
        double sum = 1;
        double i = 2;
        do
        {
            sum *= 1 / i;
            i += 2;
        }
        while (i <= 50);
        Console.WriteLine("B) Сумата на редицата е: {0}", sum);

    }

    public static void uslivieV()
    {
        double sum = 0;
        double x = 3;
        double y = 2;
        do
        {
            sum += 1 / Math.Pow(x, y);
            x += 3;
            y++;
        }
        while (x <= 51);
        Console.WriteLine("V) Сумата на редицата е: {0}", sum);

    }

    public static void uslivieG()
    {
        double sum = 0;
        double x = 1;
        do
        {
            sum += Math.Sqrt(x);
            x++;
        }
        while (x < 50);
        Console.WriteLine("G) Сумата на редицата е: {0}", sum);

    }

    public static void uslivieD()
    {
        double sum = 0;
        double x = 1;
        do
        {
            sum += x * Math.Pow(1, x);
            x++;
        }
        while (x < 50);
        Console.WriteLine("D) Сумата на редицата е: {0}", sum);

    }

    public static void uslivieE()
    {
        double sum = 0;
        double x = 48;
        do
        {
            sum += Math.Sqrt(x + Math.Sqrt(x + 1));
            x--;
        }
        while (x > 0);
        Console.WriteLine("E) Сумата на редицата е: {0}", sum);

    }

    public static void uslivieJ()
    {
        double sum = 0;
        double x = 99;
        do
        {
            sum += Math.Tan(x + Math.Tan(x + 1));
            x--;
        }
        while (x > 0);
        Console.WriteLine("J) Сумата на редицата е: {0}", sum);
    }
}
}


