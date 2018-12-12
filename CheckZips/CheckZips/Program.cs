using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int j;
            Write("\n\nRead and print elements of an array:\n");
            Write("-----------------------------------------\n");
            Write("Input 10 elements in the array");
            for (j = 0; j < 10; j++)
            {
                Write(" Please enter your zip code to see if you are in our area of work " + j + ">>");
                arr[j] = Convert.ToInt32(ReadLine());
            }
            for (int z = 0; z < arr.Length; z++)
            {
                WriteLine(" You are in our area because of this zip code " + arr[z]);
            }
        }
    }
}
