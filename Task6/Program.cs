using System;
using System.Linq;

namespace Task6
{
    class Program
    {
        static void Main()
        {
            byte[] a = new byte[31];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a["+i+"]=");
                a[i] = byte.Parse(Console.ReadLine());
            }
            Average(a);
            Console.WriteLine("Въведете n:");
            byte n = byte.Parse(Console.ReadLine());

            double[] A = new double[n];
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("A["+i+"]=");
                A[i] = double.Parse(Console.ReadLine());
            }
            double averageA = A.Average();
            Console.WriteLine("Средното количество валежи в станция А е: "+averageA);
            double[] B = new double[n];
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write("B["+i+"]=");
                B[i] = double.Parse(Console.ReadLine());
            }
            double averageB = B.Average();
            Console.WriteLine("Средното количество валежи в станция В е: "+averageB);
            double[] C = new double[n];
            for (int i = 0; i < C.Length; i++)
            {
                Console.Write("C[" + i + "]=");
                C[i] = double.Parse(Console.ReadLine());
            }
            double averageC = C.Average();
            Console.WriteLine("Средното количество валежи в станция В е: " + averageC);



        }
        static void Average(byte[] a)
        {
            double sum = 0;
            double number = 0;
            double avrg = 0;
            for (int i = 0; i < a.Length; i++)
            {   
                sum = sum + a[i];
                number = number + 1;
            }
            avrg = sum / number;
            Console.WriteLine("Средното количество валежи е:"+avrg);
        }
    }
}
