using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int fsn;
            int[] arr = new int[1];
            int i;
            Write("\n\nRead and print elements of an array:\n");
            Write("-----------------------------------------\n");
            Write("Input 10 elements in the array");
            for (i = 0; i < 1; i++)
            {
                Write("Enter number - " + i + "<<");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] < 3)
                {
                    fsn = arr[j] * 200;
                    Write("The price for " + arr[j] + " night is " + arr[j]);
                }
                if (arr[j] < 5)
                {
                    Write("The price for " + arr[j] + " night is $180 ");
                }
                if (arr[j] >= 5)
                {
                    Write("The price for " + arr[j] + " night is $160 ");
                }
                if (arr[j] >= 8)
                {
                    Write("The price for " + arr[j] + " night is $145 ");
                }
            }
        }
    }
}
