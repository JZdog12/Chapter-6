using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace temperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            int w;
            int subH = 80;
            int subL = 60;
            int zer = 1;
            int totalH;
            int totalL;
            int ave;
            int hig;
            int low;
            Write("\n\nRead and print elements of an array:\n");
            Write("-----------------------------------------\n");
            Write("Input 7 elements in the array");
            for (w = 1; w < 8; w++)
            {
                Write("Enter weather tempature of 7 days - " + w + ">>");
                arr[w] = Convert.ToInt32(ReadLine());

                totalH = subH - arr[w];
                totalL = subL - arr[w];
                ave = arr[w] * zer;
                hig = arr[w] * zer;
                low = arr[w] * zer;

                if (w > 80)
                {
                    Write("Day " + w + " the temperature is " + hig + " and it is " + totalH + " degrees away from average");
                }
                else if (w > 60)
                {
                    Write("Day " + w + " the temperature is " + ave + " in the average");
                }
                else if (w > 0)
                {
                    Write("Day " + w + " the temperature is " + low + " and it is " + totalL + " degrees away from average");
                }
                
            }
        }
    }
}
