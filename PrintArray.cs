using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricsDemo
{
    internal class PrintArraY
    {
        class PrintArray<T>
        {
            public static void toPrint<T>(T[] inputArray)
            {
                foreach (T element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("----------------------------------");
            }

            //public static void toPrint(int[] inputArray)
            //{
            //    foreach (var element in inputArray)
            //    {
            //        Console.WriteLine(element);
            //    }
            //    Console.WriteLine("----------------------------------");
            //}
            //public static void toPrint(double[] inputArray)
            //{
            //    foreach (var element in inputArray)// 1,5,3,8,9
            //    {
            //        Console.WriteLine(element);
            //    }
            //    Console.WriteLine("----------------------------------");
            //}

            //public static void toPrint(char[] inputArray)
            //{
            //    foreach (var element in inputArray)
            //    {
            //        Console.WriteLine(element);
            //    }
            //    Console.WriteLine("-------------------------------------");
            //}
        }

    }
}
