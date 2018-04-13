using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diaganol Difference
            //Calculate the difference of sums across the two diagonals of a square matrix
            int n = 3;
            int[][] x = new int[n][];

            x[0] = new int[3] { 11, 2, 4 };
            x[1] = new int[3] { 4, 5, 6 };
            x[2] = new int[3] { 10, 8, -12 };

            int result = 0;
            int reverseResult = 0;
            for (int i = 0; i < n; i++)
            {

                result += x[i][i];

            }
            int j = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                
                reverseResult += x[j][i];
                j++;
                //Console.WriteLine(reverseResult);
            }

            Console.WriteLine(result);
            Console.WriteLine(reverseResult);
            int difference = result - reverseResult;
            Console.WriteLine(Math.Abs(difference));
            Console.ReadKey();




        }
    }
}
