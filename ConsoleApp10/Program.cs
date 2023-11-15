using System;
using System.Linq;
using System.Net.Http.Headers;

namespace ConsoleApp10
{
    internal class Program
    {
        public static int SumOfTwoMaxElements(int[] array)
        {
            int e = 0;

            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
            {
                e++;
            }

            int q = array[e - 1];
            int w = array[e - 2];

            int sum = q + w;

            return sum;
        }
            
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 2, 6, 3, 2, 78, 10 };

            int a = SumOfTwoMaxElements(array);
            Console.WriteLine(a);
        }
    }
}