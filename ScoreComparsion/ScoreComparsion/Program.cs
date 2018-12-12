using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ScoreComparsion
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowscore;
            int enteredscore;
            string enteredscoreString;
            enteredscore = Convert.ToString(enteredscoreString);
            int[] arr = new int[5];
            int i;
            Write("\n\nRead and print elements of an array:\n");
            Write("-----------------------------------------\n");
            Write("Input 4 elements in the array");
            for (i = 1; i < 5; i++)
            {
                Write("Enter number - " + i + "<<");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            for (int j = 0; j < arr.Length; j++)
            {
                if (lowscore > enteredscore)
                {
                    Write(" The scores you entered " + arr[j] + " need work ");
                    lowscore = enteredscore;
                }
                else if (lowscore < enteredscore)
                {
                    Write(" keep up the good job on your score " + arr[j] + " it improved good");
                    lowscore = enteredscore;
                }
                else if (lowscore == enteredscore)
                {
                    Write(" You need to increase the score " + arr[j] + " and not let it stay the same");
                    lowscore = enteredscore;
                }
            }
        }
    }
}
