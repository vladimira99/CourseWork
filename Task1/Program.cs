using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2092;
            string binary = Convert.ToString(number, 2);
            string binary1 = Convert.ToString(number, 8);
            string binary2 = Convert.ToString(number, 16);
            Console.WriteLine(binary);
            Console.WriteLine(binary1);
            Console.WriteLine(binary2);
        }
    }
}
